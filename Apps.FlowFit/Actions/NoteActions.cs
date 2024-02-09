using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class NoteActions : FlowFitInvocable
{
    public NoteActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the notes", Description = "Returns a list of all the notes. Filters can be used to refine the search.")]
    public async Task GetNotes()
    {
        var request = new FlowFitRequest("/api/v1/Notes", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<NoteResult>>(request);
    }

    [Action("Create a new note", Description = "Creates a new note and returns the note result.")]
    public async Task PostNote()
    {
        var request = new FlowFitRequest("/api/v1/Notes", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<NoteResult>(request);
    }

    [Action("Get a note", Description = "Returns all the details of a note.")]
    public async Task GetNote()
    {
        var request = new FlowFitRequest("/api/v1/Notes/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<NoteResult>(request);
    }

    [Action("Update a note", Description = "Updates an existing note and returns the note result")]
    public async Task PutNote()
    {
        var request = new FlowFitRequest("/api/v1/Notes/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<NoteResult>(request);
    }

    [Action("Delete a note", Description = "Deletes the given note. Will also delete all related entities.")]
    public async Task DeleteNote()
    {
        var request = new FlowFitRequest("/api/v1/Notes/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}