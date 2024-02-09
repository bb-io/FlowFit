using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class FinancialTaxResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public string Tax1Id { get; set; }
    public string Tax2Id { get; set; }
    public string? Comment { get; set; }
    public string? Code { get; set; }
    public bool IsTax2AppliedOnTax1 { get; set; }
    public bool IsSimple { get; set; }
    public bool IsUsedAsSingleTax { get; set; }
    public bool IsActive { get; set; }
    public IEnumerable<FinancialTaxDictionaryResult>? FinancialTaxsDictionary { get; set; }
    public IEnumerable<FinancialTaxHistoryResult>? FinancialTaxHistories { get; set; }
    public string? FinancialTaxDefaultLanguage { get; set; }
}