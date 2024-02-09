using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ProfessionalExperienceActions : FlowFitInvocable
{
    public ProfessionalExperienceActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the professional experiences", Description = "Returns a list of all the professional experiences that have been created.")]
    public async Task GetProfessionalExperiences()
    {
        var request = new FlowFitRequest("/api/v1/ProfessionalExperiences", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProfessionalExperienceResult>>(request);
    }

    [Action("Create a new professional experience", Description = "Creates a new professional experience and returns the professional experience result.")]
    public async Task PostProfessionalExperience()
    {
        var request = new FlowFitRequest("/api/v1/ProfessionalExperiences", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ProfessionalExperienceResult>(request);
    }

    [Action("Get a professional experience", Description = "Returns all the details of a professional experience.")]
    public async Task GetProfessionalExperience()
    {
        var request = new FlowFitRequest("/api/v1/ProfessionalExperiences/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ProfessionalExperienceResult>(request);
    }

    [Action("Update a professional experience", Description = "Updates an existing professional experience and returns the professional experience result.")]
    public async Task PutProfessionalExperience()
    {
        var request = new FlowFitRequest("/api/v1/ProfessionalExperiences/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ProfessionalExperienceResult>(request);
    }

    [Action("Delete a professional experience", Description = "Deletes the given professional experience. Will also delete all related entities.")]
    public async Task DeleteProfessionalExperience()
    {
        var request = new FlowFitRequest("/api/v1/ProfessionalExperiences/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}