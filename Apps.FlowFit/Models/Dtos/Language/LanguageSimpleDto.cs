using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Dtos.Language;

public class LanguageSimpleDto
{
    [Display("ID")]
    public string Id { get; set; }
    
    public string Description { get; set; }
    
    [Display("Abbreviation")]
    public string Abrev { get; set; }
    
    [Display("ISO code")]
    public string IsoCode { get; set; }
}