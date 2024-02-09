namespace Apps.FlowFit.Models.Dtos;

public class ChargeCodeDTO 
{
    public string Code { get; set; }
    public string? Description { get; set; }
    public string ClientId { get; set; }
    public string OfficeId { get; set; }
    public bool IsActive { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}