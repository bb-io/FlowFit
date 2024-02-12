using Apps.FlowFit.Constants;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses.Error;
using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using Blackbird.Applications.Sdk.Utils.RestSharp;
using Newtonsoft.Json;
using RestSharp;

namespace Apps.FlowFit.Api;

public class FlowFitClient : BlackBirdRestClient
{
    protected override JsonSerializerSettings JsonSettings =>
        new() { MissingMemberHandling = MissingMemberHandling.Ignore };

    public FlowFitClient(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders)
        : base(new RestClientOptions
            { ThrowOnAnyError = false, BaseUrl = new Uri(Urls.Api) })
    {
        var accessToken = GetAccessToken(authenticationCredentialsProviders);
        this.AddDefaultHeader("Authorization", $"Bearer {accessToken}"); 
    }

    protected override Exception ConfigureErrorException(RestResponse response) 
    {
        var error = JsonConvert.DeserializeObject<ErrorResponse>(response.Content!);
        string errorMessage;

        if (error != null && (error.Title != null || error.Detail != null))
        {
            errorMessage = (error.Title ?? error.Type) ?? "Failed to execute the action";

            if (error.Detail != null)
                errorMessage += $": {error.Detail}";
        }
        else
        {
            var errorMessageDto = JsonConvert.DeserializeObject<ErrorMessageResponse>(response.Content!);
            errorMessage = errorMessageDto!.Message;
        }

        return new(errorMessage);
    }

    private string GetAccessToken(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders)
    {
        var login = authenticationCredentialsProviders.First(p => p.KeyName == CredsNames.Login).Value;
        var password = authenticationCredentialsProviders.First(p => p.KeyName == CredsNames.Password).Value;
        
        var request = new RestRequest("/api/v1/Authentication/AuthenticateUser", Method.Post)
            .WithJsonBody(new
            {
                login,
                password,
                culture = "en",
                timeZone = TimeZoneInfo.Local.Id
            });
        var response = new RestClient(Urls.Api).Execute(request);
        
        if (!response.IsSuccessful)
            throw new("Failed to authorize. Please check the validity of your login and password.");
        
        var sessionToken = JsonConvert.DeserializeObject<SessionTokenDto>(response.Content!, JsonSettings);
        return sessionToken!.TokenValue;
    }
}
