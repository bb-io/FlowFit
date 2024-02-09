using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class RoleActions : FlowFitInvocable
{
    public RoleActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the roles", Description = "Returns a list of all the roles that have been created.")]
    public async Task GetRoles()
    {
        var request = new FlowFitRequest("/api/v1/Roles", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<RoleResult>>(request);
    }

    [Action("Create a new role", Description = "Creates a new role and returns the role result.")]
    public async Task PostRole()
    {
        var request = new FlowFitRequest("/api/v1/Roles", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<RoleResult>(request);
    }

    [Action("Get a role", Description = "Returns all the details of a role.")]
    public async Task GetRole()
    {
        var request = new FlowFitRequest("/api/v1/Roles/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<RoleResult>(request);
    }

    [Action("Update a role", Description = "Update an existing role and returns the role result.")]
    public async Task PutRole()
    {
        var request = new FlowFitRequest("/api/v1/Roles/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<RoleResult>(request);
    }

    [Action("Delete a role", Description = "Deletes the given role. Will also delete all related entities.")]
    public async Task DeleteRole()
    {
        var request = new FlowFitRequest("/api/v1/Roles/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}