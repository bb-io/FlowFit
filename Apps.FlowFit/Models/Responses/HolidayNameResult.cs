using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class HolidayNameResult 
{
    public string Id { get; set; }
    public string? Name { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
    public IEnumerable<HolidayNameDictionaryDTO>? HolidayNameDictionary { get; set; }
}