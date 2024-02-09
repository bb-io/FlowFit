namespace Apps.FlowFit.Models.Dtos;

public class ProjectDocumentReferenceTypeDTO 
{
    public string Description { get; set; }
    public bool IsPublicClient { get; set; }
    public bool IsPublicFreelancer { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}