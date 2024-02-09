namespace Apps.FlowFit.Models.Dtos;

public class CustomFieldValueDTO 
{
    public string ClassId { get; set; }
    public string ClassName { get; set; }
    public IEnumerable<CustomFieldValueItemDTO>? Values { get; set; }
}