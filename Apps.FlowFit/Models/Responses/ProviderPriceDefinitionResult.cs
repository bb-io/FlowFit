using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProviderPriceDefinitionResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public string CurrencyId { get; set; }
    public CurrencyResult? Currency { get; set; }
    public decimal? MinimumCost { get; set; }
    public string? Note { get; set; }
    public bool IsActive { get; set; }
    public bool IsDefault { get; set; }
    public IEnumerable<ProviderPriceDefinitionDictionaryDTO>? ProviderPriceDefinitionDictionary { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
}