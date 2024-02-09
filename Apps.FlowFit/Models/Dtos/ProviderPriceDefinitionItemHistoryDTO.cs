namespace Apps.FlowFit.Models.Dtos;

public class ProviderPriceDefinitionItemHistoryDTO 
{
    public string ProviderPriceDefinitionItemId { get; set; }
    public decimal Cost { get; set; }
    public string UnitId { get; set; }
    public string DomainId { get; set; }
    public string ServiceId { get; set; }
    public DateTime ModificationDate { get; set; }
    public bool IsUrgent { get; set; }
    public string ModifiedByClassId { get; set; }
    public string ModifiedByClassName { get; set; }
}