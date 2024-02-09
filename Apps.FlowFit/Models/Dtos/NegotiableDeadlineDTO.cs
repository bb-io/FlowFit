namespace Apps.FlowFit.Models.Dtos;

public class NegotiableDeadlineDTO 
{
    public string Description { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}