namespace Apps.FlowFit.Models.Dtos;

public class ClientDepartmentDTO 
{
    public string Description { get; set; }
    public string ClientId { get; set; }
    public string DeliveryEmailTemplateId { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}