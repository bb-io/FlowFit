using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ClientDepartmentResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public string ClientId { get; set; }
    public string? Client { get; set; }
    public bool? IsActive { get; set; }
    public string DeliveryEmailTemplateId { get; set; }
}