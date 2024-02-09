using Apps.FlowFit.Api;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.FlowFit;

public class FlowFitInvocable : BaseInvocable
{
    protected readonly FlowFitClient Client;

    protected FlowFitInvocable(InvocationContext invocationContext) : base(invocationContext) 
    {
        Client = new(InvocationContext.AuthenticationCredentialsProviders);
    }
}