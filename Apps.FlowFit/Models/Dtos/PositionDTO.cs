﻿namespace Apps.FlowFit.Models.Dtos;

public class PositionDTO 
{
    public string Description { get; set; }
    public bool IsActive { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}