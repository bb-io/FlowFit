﻿using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Dtos;

public class EntitySimpleDto
{
    [Display("ID")]
    public string Id { get; set; }
    
    public string Description { get; set; }
}