using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Metadata;

namespace Apps.FlowFit;

public class FlowFitApplication : IApplication, ICategoryProvider
{
    public IEnumerable<ApplicationCategory> Categories
    {
        get => [ApplicationCategory.TranslationBusinessManagement];
        set { }
    }
    
    public string Name
    {
        get => "FlowFit";
        set { }
    }

    public T GetInstance<T>() => throw new NotImplementedException();
}