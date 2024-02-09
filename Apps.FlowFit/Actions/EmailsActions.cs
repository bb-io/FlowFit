using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class EmailsActions : FlowFitInvocable
{
    public EmailsActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the emails by classId and className", Description = "Returns a list of all the emails that have been created.")]
    public async Task GetAllEmails()
    {
        var request = new FlowFitRequest("/api/v1/Emails", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<EmailResult>>(request);
    }

    [Action("Get a email", Description = "Returns all the details of a email")]
    public async Task GetEmail()
    {
        var request = new FlowFitRequest("/api/v1/Emails/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<EmailResult>(request);
    }
}