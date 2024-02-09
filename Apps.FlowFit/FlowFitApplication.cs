using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit;

public class FlowFitApplication : IApplication
{
    public string Name
    {
        get => "FlowFit";
        set { }
    }

    public T GetInstance<T>() => throw new NotImplementedException();
}