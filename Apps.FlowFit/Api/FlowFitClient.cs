using Apps.FlowFit.Constants;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Dtos.Error;
using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using Blackbird.Applications.Sdk.Utils.RestSharp;
using Newtonsoft.Json;
using RestSharp;

namespace Apps.FlowFit.Api;

public class FlowFitClient : BlackBirdRestClient
{
    private const string UtcTimeZoneId = "UTC";
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
        var error = JsonConvert.DeserializeObject<ErrorDto>(response.Content!);
        string errorMessage;

        if (error != null && (error.Title != null || error.Detail != null))
        {
            errorMessage = (error.Title ?? error.Type) ?? "Failed to execute the action";

            if (error.Detail != null)
                errorMessage += $": {error.Detail}";
        }
        else
        {
            var errorMessageDto = JsonConvert.DeserializeObject<ErrorMessageDto>(response.Content!);
            errorMessage = errorMessageDto!.Message;
        }

        return new(errorMessage);
    }

    private string GetAccessToken(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders)
    {
        var login = authenticationCredentialsProviders.First(p => p.KeyName == CredsNames.Login).Value;
        var password = authenticationCredentialsProviders.First(p => p.KeyName == CredsNames.Password).Value;

        var token = GetAccessToken(login, password, UtcTimeZoneId);
        return token;
        //var timeZoneId = GetTimeZoneId(token);
        //return GetAccessToken(login, password, timeZoneId);
    }

    private string GetAccessToken(string login, string password, string timeZoneId)
    {
        var request = new RestRequest("/api/v1/Authentication/AuthenticateUser", Method.Post)
            .WithJsonBody(new
            {
                login,
                password,
                culture = "en",
                timeZone = timeZoneId
            });
        var response = new RestClient(Urls.Api).Execute(request);
        
        if (!response.IsSuccessful)
            throw new("Failed to authorize. Please check the validity of your login and password.");
        
        var sessionToken = JsonConvert.DeserializeObject<SessionTokenDto>(response.Content!, JsonSettings);
        return sessionToken!.TokenValue;
    }

    private string GetTimeZoneId(string accessToken)
    {
        var client = new RestClient(Urls.Api);
        var getTimeZonesRequest = new RestRequest("/api/v1/TimeZone");
        getTimeZonesRequest.AddHeader("Authorization", $"Bearer {accessToken}");
        
        var timeZonesResponse = client.Execute(getTimeZonesRequest);
        var timeZones =
            JsonConvert.DeserializeObject<IEnumerable<TimeZoneDto>>(timeZonesResponse.Content!, JsonSettings)!;

        var localTimeZoneId = TimeZoneInfo.Local.Id;

        if (timeZones.All(timeZone => timeZone.Id != localTimeZoneId))
            return UtcTimeZoneId;

        return localTimeZoneId;
    }
}
