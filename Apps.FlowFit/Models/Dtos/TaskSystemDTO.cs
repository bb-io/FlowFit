namespace Apps.FlowFit.Models.Dtos;

public class TaskSystemDTO 
{
    public string Class { get; set; }
    public string? AssemblyLocation { get; set; }
    public string? Description { get; set; }
    public string? Parameters { get; set; }
    public bool? IsDeliverable { get; set; }
    public bool? IsAttachDocument { get; set; }
}