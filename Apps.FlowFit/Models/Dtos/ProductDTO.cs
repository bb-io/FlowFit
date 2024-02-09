namespace Apps.FlowFit.Models.Dtos;

public class ProductDTO 
{
    public string Description { get; set; }
    public string ClientId { get; set; }
    public string ProductAreaId { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
    public bool IsActive { get; set; }
}