namespace Apps.FlowFit.Models.Dtos;

public class WorkCodeDTO 
{
    public string Code { get; set; }
    public string? Description { get; set; }
    public string? ChargeCode { get; set; }
    public string? ClientCode { get; set; }
    public bool IsActive { get; set; }
    public string ServiceGroupId { get; set; }
    public string ModuleId { get; set; }
    public bool IsMustBeLinkedToTask { get; set; }
    public bool IsWorkingHour { get; set; }
    public bool IsBillable { get; set; }
    public decimal? HourlyRate { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}