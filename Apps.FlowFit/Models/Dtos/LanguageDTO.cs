namespace Apps.FlowFit.Models.Dtos;

public class LanguageDTO 
{
    public string Abrev { get; set; }
    public string Description { get; set; }
    public string IsoCode { get; set; }
    public string? OriginalSourceAbrev { get; set; }
    public string? IsoCodeValue { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}