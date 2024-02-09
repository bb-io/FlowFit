using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class PaymentTermActions : FlowFitInvocable
{
    public PaymentTermActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the payment terms", Description = "Returns a list of all the payment terms that have been created.")]
    public async Task GetPaymentTerms()
    {
        var request = new FlowFitRequest("/api/v1/PaymentTerms", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<PaymentTermResult>>(request);
    }

    [Action("Get a payment term", Description = "Returns all the details of a payment term.")]
    public async Task GetPaymentTerm()
    {
        var request = new FlowFitRequest("/api/v1/PaymentTerms/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<PaymentTermResult>(request);
    }
}