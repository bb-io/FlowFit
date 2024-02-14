using Apps.FlowFit.DataSourceHandlers.Client;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.FlowFit.Models.Identifiers;

public class ClientIdentifier
{
    [Display("Client ID")]
    [DataSource(typeof(ClientDataSourceHandler))]
    public string ClientId { get; set; }
}