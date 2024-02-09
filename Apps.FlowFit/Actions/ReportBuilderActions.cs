using System.Collections;
using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ReportBuilderActions : FlowFitInvocable
{
    public ReportBuilderActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Gets report configurations", Description = "Returns all report configs of the application")]
    public async Task GetReportConfigs()
    {
        var request = new FlowFitRequest("/api/v1/ReportBuilder", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ReportConfigResult>>(request);
    }

    [Action("Gets a report configuration", Description = "Returns the report configuration associated with the given report config")]
    public async Task GetReportConfig()
    {
        var request = new FlowFitRequest("/api/v1/ReportBuilder/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ReportConfigResult>(request);
    }

    [Action("Get the data from a given report builder", Description = "Returns the report data associated with the given report config id")]
    public async Task GetData()
    {
        var request = new FlowFitRequest("/api/v1/ReportBuilder/{id}/data", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable>(request);
    }
}