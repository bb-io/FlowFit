namespace Apps.FlowFit.Models.Dtos;

public class ServiceUnitDTO 
{
    public string Id { get; set; }
    public string? Code { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }
    public bool IsSystem { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}