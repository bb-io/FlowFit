using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class SupervisorDetailsResult 
{
    public string SupervisorId { get; set; }
    public string? SupervisorColor { get; set; }
    public string? SupervisorCode { get; set; }
    public string? SupervisorFullName { get; set; }
    public bool SupervisorIsInternal { get; set; }
}