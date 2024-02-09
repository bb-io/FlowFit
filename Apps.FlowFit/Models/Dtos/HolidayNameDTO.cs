namespace Apps.FlowFit.Models.Dtos;

public class HolidayNameDTO 
{
    public string Name { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}