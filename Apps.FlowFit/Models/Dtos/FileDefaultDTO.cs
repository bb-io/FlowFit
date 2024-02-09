namespace Apps.FlowFit.Models.Dtos;

public class FileDefaultDTO 
{
    public string? Extension { get; set; }
    public string? FileName { get; set; }
    public string? FileContent { get; set; }
    public bool IsFinal { get; set; }
    public string? FolderPath { get; set; }
    public string GroupDocId { get; set; }
}