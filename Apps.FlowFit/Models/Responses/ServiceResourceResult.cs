using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ServiceResourceResult 
{
    public string Id { get; set; }
    public string ResourceId { get; set; }
    public string? Resource { get; set; }
    public string ServiceId { get; set; }
    public string? Service { get; set; }
    public string UnityOfMeasureId { get; set; }
    public decimal? UnitCost { get; set; }
    public bool IsUrgent { get; set; }
    public string ProjectTypeId { get; set; }
    public string? ProjectType { get; set; }
    public string DomainId { get; set; }
    public string? Domain { get; set; }
    public int? WordsPerHours { get; set; }
}