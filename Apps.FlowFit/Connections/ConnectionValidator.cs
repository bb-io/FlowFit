using Apps.FlowFit.Api;
using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Common.Connections;

namespace Apps.FlowFit.Connections;

public class ConnectionValidator : IConnectionValidator
{
    public async ValueTask<ConnectionValidationResponse> ValidateConnection(
        IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders, 
        CancellationToken cancellationToken)
    {
        var client = new FlowFitClient(authenticationCredentialsProviders);
        var request = new FlowFitRequest("/api/v1/ChargeCodes");
        
        try
        {
            await client.ExecuteWithErrorHandling(request);
            return new ConnectionValidationResponse
            {
                IsValid = true
            };
        }
        catch (Exception exception)
        {
            return new ConnectionValidationResponse
            {
                IsValid = false,
                Message = exception.Message
            };
        }
    }
}