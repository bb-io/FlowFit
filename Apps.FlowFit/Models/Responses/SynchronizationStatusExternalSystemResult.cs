using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class SynchronizationStatusExternalSystemResult 
{
    public string SyncStatusId { get; set; }
    public string? SyncStatusName { get; set; }
    public DateTime? SyncDate { get; set; }
    public string? SyncMessage { get; set; }
    public string? SyncStatusColor { get; set; }
    public DateTime? LastSuccessfulSyncDate { get; set; }
}