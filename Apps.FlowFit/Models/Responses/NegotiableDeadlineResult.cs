using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class NegotiableDeadlineResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
    public IEnumerable<NegotiableDeadlineDictionaryDTO>? NegotiableDeadlineDictionary { get; set; }
}