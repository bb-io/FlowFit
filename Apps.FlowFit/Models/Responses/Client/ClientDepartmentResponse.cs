namespace Apps.FlowFit.Models.Responses.Client;

public class ClientDepartmentResponse 
{
    public string Id { get; set; }
    public string Description { get; set; }
    public string ClientId { get; set; }
    public string? Client { get; set; }
    public bool? IsActive { get; set; }
    public string DeliveryEmailTemplateId { get; set; }
}