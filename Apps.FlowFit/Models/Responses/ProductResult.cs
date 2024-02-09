using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProductResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public string ClientId { get; set; }
    public ClientResult? Client { get; set; }
    public string ProductAreaId { get; set; }
    public ProductAreaResult? ProductArea { get; set; }
    public bool IsActive { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
    public IEnumerable<ProductDictionaryDTO>? ProductDictionary { get; set; }
}