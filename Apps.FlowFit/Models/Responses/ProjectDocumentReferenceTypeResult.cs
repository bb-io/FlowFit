using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProjectDocumentReferenceTypeResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public bool IsPublicClient { get; set; }
    public bool IsPublicFreelancer { get; set; }
    public IEnumerable<ProjectDocumentReferenceTypeDictionaryDTO>? ProjectDocumentReferenceTypeDictionary { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
}