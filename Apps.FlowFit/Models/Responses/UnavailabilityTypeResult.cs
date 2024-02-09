using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class UnavailabilityTypeResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public string? Color { get; set; }
    public bool IsFreelancer { get; set; }
    public bool IsUnav { get; set; }
    public string WorkCodeId { get; set; }
    public string? WorkCodeStr { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
    public IEnumerable<UnavailabilityTypeDictionaryDTO>? UnavailabilityTypeDictionary { get; set; }
}