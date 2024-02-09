using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ChargeCodeResult 
{
    public string Id { get; set; }
    public string? Code { get; set; }
    public string? Description { get; set; }
    public string ClientId { get; set; }
    public ClientResult? Client { get; set; }
    public string OfficeId { get; set; }
    public OfficeResult? Office { get; set; }
    public bool IsActive { get; set; }
    public IEnumerable<ChargeCodeDictionaryDTO>? ChargeCodeDictionary { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
    public string? CodeAndDescription { get; set; }
}