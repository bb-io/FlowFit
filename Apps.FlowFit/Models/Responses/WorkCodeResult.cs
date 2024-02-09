using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class WorkCodeResult 
{
    public string Id { get; set; }
    public string? Code { get; set; }
    public string? Description { get; set; }
    public string? ChargeCode { get; set; }
    public string? ClientCode { get; set; }
    public bool IsActive { get; set; }
    public string ServiceGroupId { get; set; }
    public string? ServiceGroupDescription { get; set; }
    public bool IsMustBeLinkedToTask { get; set; }
    public bool IsWorkingHour { get; set; }
    public bool IsBillable { get; set; }
    public decimal? HourlyRate { get; set; }
    public string? WorkCodeAndDescription { get; set; }
    public string? ModuleDescription { get; set; }
    public string ModuleId { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
    public IEnumerable<WorkCodeDictionaryDTO>? WorkCodeDictionary { get; set; }
}