namespace Apps.FlowFit.Models.Dtos;

public class TitleDTO 
{
    public bool IsActive { get; set; }
    public string Description { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}