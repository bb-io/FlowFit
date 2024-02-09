namespace Apps.FlowFit.Models.Dtos;

public class ProviderPriceDefinitionDTO 
{
    public string Description { get; set; }
    public string CurrencyId { get; set; }
    public decimal? MinimumCost { get; set; }
    public string? Note { get; set; }
    public bool IsActive { get; set; }
    public bool IsDefault { get; set; }
    public IEnumerable<ProviderPriceDefinitionItemDTO>? ProviderPriceDefinitionItems { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}