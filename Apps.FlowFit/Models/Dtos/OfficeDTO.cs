namespace Apps.FlowFit.Models.Dtos;

public class OfficeDTO 
{
    public string Description { get; set; }
    public bool IsActive { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}