using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using System.IO.Compression;

using Newtonsoft.Json;

using MobaGains.Rigging.Configs;

var builder = WebApplication.CreateBuilder(args);
{
    var services = builder.Services;
    var env = builder.Environment;

    // HTTP/S 3 : br - brotli
    services.AddResponseCompression(options =>
    {
        options.EnableForHttps = true;
        options.Providers.Add<BrotliCompressionProvider>();
    });

    services.Configure<BrotliCompressionProviderOptions>(options =>
    {
        options.Level = CompressionLevel.Fastest;
    });

    services.AddRequestDecompression();

    services.AddControllers().AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
        options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
    });

    services.AddHttpContextAccessor();

    services.Configure<DatabaseConfig>(builder.Configuration.GetSection("DatabaseSettings"), c => c.BindNonPublicProperties = true);
    services.Configure<UserRiotAPIConfig>(builder.Configuration.GetSection("UserRiotAPISettings"), c => c.BindNonPublicProperties = true);
    services.Configure<LCUConfig>(builder.Configuration.GetSection("LCUSettings"), c => c.BindNonPublicProperties = true);
    services.Configure<MetadataConfig>(builder.Configuration.GetSection("MetadataSettings"), c => c.BindNonPublicProperties = true);
    services.Configure<OverallConfig>(builder.Configuration.GetSection("OverallSettings"), c => c.BindNonPublicProperties = true);
}

builder.Services.AddHttpClient();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
builder.WebHost.ConfigureKestrel((context, options) => {
    options.Limits.Http2.KeepAlivePingTimeout = TimeSpan.FromSeconds(30);
    options.Limits.Http2.KeepAlivePingDelay = TimeSpan.FromMinutes(1);
    options.ListenAnyIP(5001, listenOptions => {
        listenOptions.Protocols = HttpProtocols.Http1AndHttp2AndHttp3;
        listenOptions.UseHttps();
    });
});

app.UseHttpsRedirection();

app.UseResponseCompression();

app.UseRequestDecompression();

app.MapControllers();

app.Run();
