namespace Apps.FlowFit.Models.Dtos;

public class CountryDTO 
{
    public string Description { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}