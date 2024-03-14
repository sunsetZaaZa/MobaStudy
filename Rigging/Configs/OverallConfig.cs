using System.Diagnostics.CodeAnalysis;

namespace MobaGains.Rigging.Configs;

public class OverallConfig
{
    [SetsRequiredMembers]
    public OverallConfig(bool offlineView, bool onlinePagination, int paginationLength, int paginationThreshold, int paginationThresholdFetch, int paginationStorage)
    {
        this.offlineView = offlineView;
        this.onlinePagination = onlinePagination;
        this.paginationLength = paginationLength;
        this.paginationThreshold = paginationThreshold;
        this.paginationThresholdFetch = paginationThresholdFetch;
        this.paginationStorage = paginationStorage;
    }

    public required bool offlineView { get; set; }
    public required bool onlinePagination { get; set; }
    public required int paginationLength { get; set; }
    public required int paginationThreshold { get; set; }
    public required int paginationThresholdFetch { get; set; }
    public required int paginationStorage { get; set; }
}
