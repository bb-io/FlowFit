using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProfessionalExperienceResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public int? DisplayOrder { get; set; }
    public IEnumerable<ProfessionalExperienceDictionaryDTO>? ProfessionalExperienceDictionary { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
}