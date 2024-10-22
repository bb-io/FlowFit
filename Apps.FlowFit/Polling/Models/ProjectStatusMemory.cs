namespace Apps.FlowFit.Polling.Models;

public class ProjectStatusMemory
{
    public List<ProjectMemoryEntity> Entities { get; set; } = new();
}

public class ProjectMemoryEntity
{
    public string ProjectId { get; set; } = string.Empty;
    
    public string Status { get; set; } = string.Empty;
}