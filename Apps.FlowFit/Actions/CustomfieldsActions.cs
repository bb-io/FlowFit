using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class CustomfieldsActions : FlowFitInvocable
{
    public CustomfieldsActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get custom field value", Description = "Returns the value of the custom field using the parameter CustomFieldName, the ClassName and the ClassId.")]
    public async Task GetCustomFieldValue()
    {
        var request = new FlowFitRequest("/api/v1/CustomFields/GetCustomFieldValue", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<CustomFieldValueResult>(request);
    }

    [Action("Get custom field values", Description = "Returns a list of all custom field values for the sent object, using  the parameterClassId and ClassName.")]
    public async Task GetCustomFieldValues()
    {
        var request = new FlowFitRequest("/api/v1/CustomFields/GetCustomFieldValues", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<CustomFieldValueResult>>(request);
    }

    [Action("Post custom field values", Description = "Create or update custom field values, if there is already value for the custom field sent, update the value, if there is no value,")]
    public async Task PostCustomFieldValues()
    {
        var request = new FlowFitRequest("/api/v1/CustomFields/PostCustomFieldValues", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<CustomFieldValueResult>>(request);
    }

    [Action("Get custom field definition", Description = "Returns the definition for the custom field, using  the parameter CustomFieldName and ClassName, if it is a type LIST, returns all possible values for this list.")]
    public async Task GetCustomFieldDefinition()
    {
        var request = new FlowFitRequest("/api/v1/CustomFields/GetCustomFieldDefinition", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<CustomFieldDefinitionResult>(request);
    }

    [Action("Get custom field definitions", Description = "Returns all custom field definitions by ClassName and ClassId, if it is a type LIST, returns all possible values for this list.")]
    public async Task GetCustomFieldDefinitions()
    {
        var request = new FlowFitRequest("/api/v1/CustomFields/GetCustomFieldDefinitions", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<CustomFieldDefinitionResult>>(request);
    }

    [Action("Get custom field project definitions for the project", Description = "Returns all custom field definitions for the project, using the ProjectId as a parameter, if it is a type LIST, returns all possible values for this list.")]
    public async Task GetCustomFieldProjectDefinitions()
    {
        var request = new FlowFitRequest("/api/v1/CustomFields/GetCustomFieldProjectDefinitions", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<CustomFieldDefinitionResult>>(request);
    }

    [Action("Post custom field definition", Description = "Create a custom field definition.")]
    public async Task PostCustomFieldDefinition()
    {
        var request = new FlowFitRequest("/api/v1/CustomFields/PostCustomFieldDefinition", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<CustomFieldDefinitionResult>>(request);
    }

    [Action("Put (update) a custom field definition", Description = "Updates an existing custom field definition and returns the custom field definition result.")]
    public async Task PutCustomFieldDefinition()
    {
        var request = new FlowFitRequest("/api/v1/CustomFields/PutCustomFieldDefinition", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<CustomFieldDefinitionResult>(request);
    }
}