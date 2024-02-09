using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ClientInvoicesListResult 
{
    public IEnumerable<ClientInvoicesListResultDto>? Value { get; set; }
    // public  Aggregates { get; set; }
    public int TotalResults { get; set; }
}