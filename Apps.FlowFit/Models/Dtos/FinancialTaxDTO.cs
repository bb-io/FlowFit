namespace Apps.FlowFit.Models.Dtos;

public class FinancialTaxDTO 
{
    public string Description { get; set; }
    public string Tax1Id { get; set; }
    public string Tax2Id { get; set; }
    public string? Comment { get; set; }
    public bool IsTax2AppliedOnTax1 { get; set; }
    public bool IsSimple { get; set; }
    public bool IsUsedAsSingleTax { get; set; }
    public bool IsActive { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}