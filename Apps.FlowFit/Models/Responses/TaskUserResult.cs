using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class TaskUserResult 
{
    public string AssignToClassId { get; set; }
    public string? AssignToClassName { get; set; }
    public string? CompleteName { get; set; }
    public string? Color { get; set; }
    public string? Code { get; set; }
    public bool IsInternal { get; set; }
}