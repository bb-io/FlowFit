using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Dtos.Language;

public class LanguageSimpleDto : EntitySimpleDto
{
    [Display("Abbreviation")]
    public string Abrev { get; set; }
    
    [Display("ISO code")]
    public string IsoCode { get; set; }
}