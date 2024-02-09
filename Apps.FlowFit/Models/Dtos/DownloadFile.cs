namespace Apps.FlowFit.Models.Dtos;

public class DownloadFile 
{
    public string? FileBytes { get; set; }
    public string? FileName { get; set; }
    public string? Extension { get; set; }
    public int ContentLength { get; set; }
    public bool MultipleFiles { get; set; }
    public string? Path { get; set; }
}