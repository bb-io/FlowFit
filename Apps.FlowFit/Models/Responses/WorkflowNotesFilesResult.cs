using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class WorkflowNotesFilesResult 
{
    public string Id { get; set; }
    public string? OriginalFileName { get; set; }
    public string? FileName { get; set; }
    public string? Path { get; set; }
    public string? Extension { get; set; }
    public int Size { get; set; }
    public string NoteId { get; set; }
    public string? FileSizeInKb { get; set; }
}