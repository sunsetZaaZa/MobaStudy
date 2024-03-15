using System.Data;

using Npgsql;
using NpgsqlTypes;

namespace MobaGains.Rigging.Database.Repos;

public interface IGameplayRepo
{
    public Task<RuneSet?> GetRuneSet(Guid runeSetId);
    public Task<bool> SetRuneSet(RuneSet bundle);
    public Task<RuneSet?> ModifyRuneset(RuneSet bundle);

    public Task<SummonerSpells?> GetSummonerSpells(Guid summonerSpellId);
    public Task<bool> SetSummonerSpells(SummonerSpellSet bundle);
}

public class GameplayRepo : IGameplayRepo
{
    private DatabaseContext _activeDatabase { get; set; }
    public GameplayRepo(DatabaseContext database)
    {
        _activeDatabase = database;
    }

    public async Task<RuneSet?> GetRuneSet(Guid runeSetId)
    {
        using (NpgsqlConnection conn = await _activeDatabase.CreateConnection())
        {
            using (NpgsqlTransaction tran = await conn.BeginTransactionAsync())
            {
                using (NpgsqlCommand command = new NpgsqlCommand("get_runeSet", conn, tran))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@runeSetId", NpgsqlDbType.Uuid).Value = runeSetId;

                    try
                    {
                        NpgsqlDataReader dr = await command.ExecuteReaderAsync();
                        await tran.CommitAsync();

                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                return new RuneSet();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        await tran.RollbackAsync();
                        await tran.CommitAsync();
                    }
                    finally
                    {
                        await conn.CloseAsync();
                    }
                }
            }
        }

        return null;
    }

    public async Task<bool> SetRuneset(RuneSet bundle)
    {
        bool result = false;
        using (NpgsqlConnection conn = await _activeDatabase.CreateConnection())
        {
            using (NpgsqlTransaction tran = await conn.BeginTransactionAsync())
            {
                using (NpgsqlCommand command = new NpgsqlCommand("set_runeSet", conn, tran))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@runeSetId", NpgsqlDbType.Uuid).Value = bundle.runeSetId;

                    try
                    {
                        NpgsqlDataReader dr = await command.ExecuteReaderAsync();
                        await tran.CommitAsync();

                        if (dr.HasRows)
                        {
                            result = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        await tran.RollbackAsync();
                        await tran.CommitAsync();
                    }
                    finally
                    {
                        await conn.CloseAsync();
                    }
                }
            }
        }

        return result;
    }

    public async Task<RuneSet?> ModifyRuneset(RuneSet bundle)
    {

    }

    public async Task<SummonerSpells?> GetSummonerSpells(Guid summonerSpellId)
    {

    }

    public async Task<bool> SetSummonerSpells(SummonerSpellSet bundle)
    {

    }
}
