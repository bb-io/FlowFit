namespace Apps.FlowFit.Models.Dtos;

public class UnavailabilityTypeDTO 
{
    public string? Description { get; set; }
    public string? Color { get; set; }
    public bool IsFreelancer { get; set; }
    public bool IsUnav { get; set; }
    public string WorkCodeId { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}