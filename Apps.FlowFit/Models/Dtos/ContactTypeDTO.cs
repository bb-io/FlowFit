namespace Apps.FlowFit.Models.Dtos;

public class ContactTypeDTO 
{
    public string Description { get; set; }
    public bool CanManage { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}