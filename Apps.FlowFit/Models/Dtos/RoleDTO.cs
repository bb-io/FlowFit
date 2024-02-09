namespace Apps.FlowFit.Models.Dtos;

public class RoleDTO 
{
    public string Description { get; set; }
    public bool IsAdmin { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}