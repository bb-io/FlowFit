using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class LanguageActions : FlowFitInvocable
{
    public LanguageActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the languages", Description = "Returns a list of all the languages that have been created.")]
    public async Task GetLanguages()
    {
        var request = new FlowFitRequest("/api/v1/Languages", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<LanguageResult>>(request);
    }

    [Action("Create a new language", Description = "Creates a new language and returns the language result.")]
    public async Task PostLanguage()
    {
        var request = new FlowFitRequest("/api/v1/Languages", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<LanguageResult>(request);
    }

    [Action("Get a language", Description = "Returns all the details of a language.")]
    public async Task GetLanguage()
    {
        var request = new FlowFitRequest("/api/v1/Languages/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<LanguageResult>(request);
    }

    [Action("Update a language", Description = "Updates an existing language and returns the language result")]
    public async Task PutLanguage()
    {
        var request = new FlowFitRequest("/api/v1/Languages/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<LanguageResult>(request);
    }

    [Action("Delete a language", Description = "Deletes the given language. Will also delete all related entities.")]
    public async Task DeleteLanguage()
    {
        var request = new FlowFitRequest("/api/v1/Languages/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}