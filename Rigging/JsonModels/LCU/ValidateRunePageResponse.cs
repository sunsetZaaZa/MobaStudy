namespace MobaGains.Rigging.JsonModels.LCU;

public class NameCheckRespsone
{
    public NameCheckRespsone(List<string> errors)
    {
        this.errors = errors;
    }

    public List<string> errors { get; set; }
}
public class ValidateRunePageResponse
{
    public ValidateRunePageResponse(NameCheckRespsone nameCheckResponse, bool success)
    {
        this.nameCheckResponse = nameCheckResponse;
        this.success = success;
    }

    public NameCheckRespsone nameCheckResponse { get; set; }
    public bool success { get; set; }
}
