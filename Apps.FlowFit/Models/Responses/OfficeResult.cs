﻿using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class OfficeResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
    public IEnumerable<OfficeDictionaryDTO>? OfficeDictionary { get; set; }
}