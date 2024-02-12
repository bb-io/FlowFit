using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Responses.Language;

public class LanguageSimpleResponse 
{
    [Display("Language ID")]
    public string Id { get; set; }
    
    [Display("Abbreviation")]
    public string Abrev { get; set; }
    
    public string Description { get; set; }
    
    [Display("ISO code")]
    public string IsoCode { get; set; }
}