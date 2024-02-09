namespace Apps.FlowFit.Models.Dtos;

public class ProfessionalExperienceDTO 
{
    public string Description { get; set; }
    public int? DisplayOrder { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}