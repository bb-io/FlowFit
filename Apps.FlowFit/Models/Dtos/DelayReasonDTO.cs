namespace Apps.FlowFit.Models.Dtos;

public class DelayReasonDTO 
{
    public string Description { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}