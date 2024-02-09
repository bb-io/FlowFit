using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ModuleActions : FlowFitInvocable
{
    public ModuleActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the modules", Description = "Returns a list of all the modules that have been created.")]
    public async Task GetModules()
    {
        var request = new FlowFitRequest("/api/v1/Modules", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ModuleResult>>(request);
    }

    [Action("Create a new module", Description = "Creates a new module and returns the module result")]
    public async Task PostModule()
    {
        var request = new FlowFitRequest("/api/v1/Modules", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ModuleResult>(request);
    }

    [Action("Get a module", Description = "Returns all the details of a module")]
    public async Task GetModule()
    {
        var request = new FlowFitRequest("/api/v1/Modules/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ModuleResult>(request);
    }

    [Action("Update a module", Description = "Updates an existing module and returns the module result.")]
    public async Task PutModule()
    {
        var request = new FlowFitRequest("/api/v1/Modules/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ModuleResult>(request);
    }

    [Action("Delete a module", Description = "Deletes the given module. Will also delete all related entities.")]
    public async Task DeleteModule()
    {
        var request = new FlowFitRequest("/api/v1/Modules/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}