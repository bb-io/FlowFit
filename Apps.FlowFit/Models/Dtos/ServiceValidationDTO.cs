namespace Apps.FlowFit.Models.Dtos;

public class ServiceValidationDTO 
{
    public string? Description { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}