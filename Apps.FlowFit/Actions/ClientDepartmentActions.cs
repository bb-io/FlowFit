using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ClientDepartmentActions : FlowFitInvocable
{
    public ClientDepartmentActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all client departments", Description = "Returns a list of client departments. Filters can be used to refine the search.")]
    public async Task GetClientDepartments()
    {
        var request = new FlowFitRequest("/api/v1/ClientDepartments", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ClientDepartmentResult>>(request);
    }

    [Action("Create a new client department", Description = "Creates a new client department and returns the client department result.")]
    public async Task PostClientDepartment()
    {
        var request = new FlowFitRequest("/api/v1/ClientDepartments", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ClientDepartmentResult>(request);
    }

    [Action("Get a client department", Description = "Returns all the details of a client department.")]
    public async Task GetClientDepartment()
    {
        var request = new FlowFitRequest("/api/v1/ClientDepartments/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ClientDepartmentResult>(request);
    }

    [Action("Update a client department", Description = "Updates an existing client department and returns the client department result.")]
    public async Task PutClientDepartment()
    {
        var request = new FlowFitRequest("/api/v1/ClientDepartments/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ClientDepartmentResult>(request);
    }

    [Action("Delete a client department", Description = "Deletes the given client department.")]
    public async Task DeleteClientDepartment()
    {
        var request = new FlowFitRequest("/api/v1/ClientDepartments/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}