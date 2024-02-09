using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class CountryResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public IEnumerable<CountryDictionaryDTO>? CountryDictionary { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
}