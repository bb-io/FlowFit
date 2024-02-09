using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class NoteResult 
{
    public string Id { get; set; }
    public string? Title { get; set; }
    public string? NoteContent { get; set; }
    public string ClassId { get; set; }
    public string? ClassName { get; set; }
    public string ProjectId { get; set; }
    public string WorkId { get; set; }
    public string CreatedById { get; set; }
    public string? CreatedByClass { get; set; }
    public int? UserIdTo { get; set; }
    public string? ClassTo { get; set; }
    public DateTime Date { get; set; }
    public string? SystemSource { get; set; }
}