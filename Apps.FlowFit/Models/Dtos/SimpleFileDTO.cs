namespace Apps.FlowFit.Models.Dtos;

public class SimpleFileDTO 
{
    public string Extension { get; set; }
    public string FileName { get; set; }
    public string FileContent { get; set; }
    public bool? DoNotExecutePretranslation { get; set; }
}