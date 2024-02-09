namespace Apps.FlowFit.Models.Dtos;

public class ProviderPriceDefinitionItemDTO 
{
    public string Id { get; set; }
    public string ProviderPriceDefinitionId { get; set; }
    public string ServiceId { get; set; }
    public decimal Cost { get; set; }
    public string UnitId { get; set; }
    public string DomainId { get; set; }
    public bool IsUrgent { get; set; }
    public string? CurrencySymbol { get; set; }
    public string? ServiceDescription { get; set; }
    public string? UnitDescription { get; set; }
    public string? DomainDescription { get; set; }
    public DateTime Date { get; set; }
    public string? CreatedByClassName { get; set; }
    public string CreatedByClassId { get; set; }
    public IEnumerable<ProviderPriceDefinitionItemHistoryDTO>? ProviderPriceDefinitionItemHistories { get; set; }
}