using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class TaxExtendedResult 
{
    public string TaxId { get; set; }
    public string TaxHistoryId { get; set; }
    public string? TaxDescription { get; set; }
    public string? Code { get; set; }
    public int? Tax1 { get; set; }
    public string? TaxComment { get; set; }
    public int? Tax2 { get; set; }
    public decimal? TaxValue { get; set; }
    public string? Tax1Name { get; set; }
    public decimal? Tax1Value { get; set; }
    public string? Tax2Name { get; set; }
    public decimal? Tax2Value { get; set; }
    public bool IsSimple { get; set; }
    public bool IsActive { get; set; }
    public bool IsUsedAsSingleTax { get; set; }
    public bool IsTax2AppliedOnTax1 { get; set; }
    public DateTime? TaxDateStart { get; set; }
    public IEnumerable<FinancialTaxDictionaryResult>? FinancialTaxesDictionary { get; set; }
    public string? FinancialTaxDefaultLanguage { get; set; }
    public string? TaxValueString { get; set; }
}