using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ToolActions : FlowFitInvocable
{
    public ToolActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the tools", Description = "The a list of all the tools that have been created.")]
    public async Task GetTools()
    {
        var request = new FlowFitRequest("/api/v1/Tools", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ToolResult>>(request);
    }

    [Action("Create a new tool", Description = "Creates a new tool and returns the tool result")]
    public async Task PostTool()
    {
        var request = new FlowFitRequest("/api/v1/Tools", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ToolResult>(request);
    }

    [Action("Get a tool", Description = "Returns all the details of a tool.")]
    public async Task GetTool()
    {
        var request = new FlowFitRequest("/api/v1/Tools/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ToolResult>(request);
    }

    [Action("Update a tool", Description = "Updates an existing tool and returns the tool result.")]
    public async Task PutTool()
    {
        var request = new FlowFitRequest("/api/v1/Tools/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ToolResult>(request);
    }

    [Action("Delete a Tool", Description = "Deletes the given tool. Will also delete all related entities.")]
    public async Task DeleteTool()
    {
        var request = new FlowFitRequest("/api/v1/Tools/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}