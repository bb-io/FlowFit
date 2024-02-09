namespace Apps.FlowFit.Models.Dtos;

public class ServiceGroupDTO 
{
    public string Description { get; set; }
    public int? PrintOrder { get; set; }
    public string Abbreviation { get; set; }
    public bool? IsMandatory { get; set; }
    public int? ServiceType { get; set; }
    public IEnumerable<DictionaryDescriptionServiceGroupDTO>? DescriptionDictionary { get; set; }
}