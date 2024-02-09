﻿using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class TargetAudienceResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }
    public IEnumerable<TargetAudienceDictionaryDTO>? TargetAudienceDictionary { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
}