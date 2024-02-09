using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class WorkflowsActions : FlowFitInvocable
{
    public WorkflowsActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get a Workflows with filters", Description = "Returns a list of all the Workflows that have been created.")]
    public async Task GetWorkflows()
    {
        var request = new FlowFitRequest("/api/v1/Workflows", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<WorkflowResult>>(request);
    }

    [Action("Get an Workflow", Description = "Returns all the details of an Workflow.")]
    public async Task GetWorkflow()
    {
        var request = new FlowFitRequest("/api/v1/Workflows/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<WorkflowResult>(request);
    }

    [Action("Get all workflows without filters", Description = "Returns a list of all workflows without filters.")]
    public async Task GetAllWorkflows()
    {
        var request = new FlowFitRequest("/api/v1/Workflows/GetAllWorkflows", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<WorkflowListResult>>(request);
    }

    [Action("Get Workflows by projects", Description = "Returns a list of all the Workflows by projects.")]
    public async Task GetWorkflowsByProject()
    {
        var request = new FlowFitRequest("/api/v1/Workflows/GetWorkflowsByProject", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<WorkflowResult>>(request);
    }
}