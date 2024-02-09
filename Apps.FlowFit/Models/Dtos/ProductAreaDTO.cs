namespace Apps.FlowFit.Models.Dtos;

public class ProductAreaDTO 
{
    public bool IsActive { get; set; }
    public string Description { get; set; }
    public IEnumerable<int>? Clients { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}