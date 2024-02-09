using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class PaymentTermResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public int Days { get; set; }
}