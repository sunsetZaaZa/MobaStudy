using MobaGains.Entities.Metadata;
using MobaGains.Rigging.Utilities.Metadata;

namespace MobaGains.Rigging.Utilities;

public interface IMetadataParser
{
    ItemStats ExtractItemStats(string haystack);
    PerkStats ExtractPerkStats(string haystack);
    ChampionStats ExtractChampionStats(string haystack);
    ChampionSummary ExtractChampionSummary(string haystack);
    MapDetails ExtractMapDetails(string haystack);

    Item TransformIntoItem(ItemStats item);
}

public class MetadataParser : IMetadataParser
{
    public MetadataParser() { }

    public async ItemStats ExtractItemStats(string haystack)
    {

    }

    public async PerkStats ExtractPerkStats(string haystack)
    {

    }

    public async ChampionStats ExtractChampionStats(string haystack)
    {

    }


}
