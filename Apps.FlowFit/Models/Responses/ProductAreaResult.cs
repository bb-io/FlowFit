using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProductAreaResult 
{
    public string Id { get; set; }
    public bool IsActive { get; set; }
    public string? Description { get; set; }
    public IEnumerable<int>? Clients { get; set; }
    public IEnumerable<string>? ClientNames { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
    public IEnumerable<ProductAreaDictionaryDTO>? ProductAreaDictionary { get; set; }
    public string? ProductAreaDefaultLanguage { get; set; }
}