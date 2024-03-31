using System.Data;

using Npgsql;
using NpgsqlTypes;

using MobaGains.Entities.Gameplay;

namespace MobaGains.Rigging.Database.Repos;

public interface IGameplayRepo
{
    public Task<List<RuneSet>> ViewRuneSetRange(int index, int length);
    public Task<RuneSet?> GetRuneSet(Guid indexer);
    public Task<bool> SetRuneSet(RuneSet bundle);
    public Task<List<Playstyle>> ViewPlayStyleRange(int index, int length);
    public Task<bool> CreatePlayStyle(Playstyle payload);
    public Task<bool> RemovePlayStyle(Guid indexer);
    public Task<List<GearLayout>> ViewGearLayoutRange(int index, int length);
    public Task<List<GearLayout>> ViewGearLayoutByChampion(int championId, int index, int length);
    public Task<bool> CreateGearLayout(GearLayout payload);
    public Task<bool> RemoveGearLayout(Guid indexer);
    public Task<List<TailoredLoadout>> ViewTailoredLoadoutRange(int index, int length, bool? wip, bool? active);
    public Task<List<TailoredLoadout>> ViewTailoredLoadoutByChampion(int championId, int index, int length, bool? wip, bool? active);
    public Task<bool> CreateTailoredLoadout(TailoredLoadout payload);
    public Task<bool> ModifyTailoredLoadout(TailoredLoadout payload);
    public Task<bool> RemoveTailoredLoadout(Guid indexer);
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

}
