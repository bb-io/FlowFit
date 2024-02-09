namespace Apps.FlowFit.Models.Dtos;

public class ConversionRateDTO 
{
    public string SourceCurrencyId { get; set; }
    public string TargetCurrencyId { get; set; }
    public decimal Rate { get; set; }
    public DateTime Date { get; set; }
}