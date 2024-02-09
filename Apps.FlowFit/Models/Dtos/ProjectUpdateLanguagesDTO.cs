namespace Apps.FlowFit.Models.Dtos;

public class ProjectUpdateLanguagesDTO 
{
    public string SourceLanguageId { get; set; }
    public IEnumerable<int>? TargetLanguages { get; set; }
}