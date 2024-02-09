namespace Apps.FlowFit.Models.Dtos;

public class ServiceResourceDTO 
{
    public string ResourceId { get; set; }
    public string ServiceId { get; set; }
    public string UnityOfMeasureId { get; set; }
    public decimal? UnitCost { get; set; }
    public bool IsUrgent { get; set; }
    public string ProjectTypeId { get; set; }
    public string DomainId { get; set; }
    public int? WordsPerHours { get; set; }
}