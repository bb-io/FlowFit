using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ChargeCodeActions : FlowFitInvocable
{
    public ChargeCodeActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get charge codes", Description = "Returns a list of charge codes. Filters can be used to refine the search.")]
    public async Task GetChargeCodes()
    {
        var request = new FlowFitRequest("/api/v1/ChargeCodes", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ChargeCodeResult>>(request);
    }

    [Action("Create a new charge code", Description = "Creates a new charge code and returns the charge code result.")]
    public async Task PostChargeCode()
    {
        var request = new FlowFitRequest("/api/v1/ChargeCodes", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ChargeCodeResult>(request);
    }

    [Action("Get a charge code", Description = "Returns all the details of a charge code.")]
    public async Task GetChargeCode()
    {
        var request = new FlowFitRequest("/api/v1/ChargeCodes/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ChargeCodeResult>(request);
    }

    [Action("Update a charge code", Description = "Updates an existing charge code and returns the charge code result.")]
    public async Task PutChargeCode()
    {
        var request = new FlowFitRequest("/api/v1/ChargeCodes/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ChargeCodeResult>(request);
    }

    [Action("Patch a charge code", Description = "### Updates partial an existing charge code and returns the charge code result. ###")]
    public async Task PatchChargeCode()
    {
        var request = new FlowFitRequest("/api/v1/ChargeCodes/{id}", Method.Patch);
        var response = await Client.ExecuteWithErrorHandling<ChargeCodeResult>(request);
    }

    [Action("Delete a charge code", Description = "Deletes the given charge code. Will also delete all related entities.")]
    public async Task DeleteChargeCode()
    {
        var request = new FlowFitRequest("/api/v1/ChargeCodes/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling<bool>(request);
    }
}