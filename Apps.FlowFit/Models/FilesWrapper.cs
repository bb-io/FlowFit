using Blackbird.Applications.Sdk.Common.Files;

namespace Apps.FlowFit.Models;

public class FilesWrapper
{
    public FilesWrapper() { }
    
    public FilesWrapper(IEnumerable<FileReference> files)
    {
        Files = files;
    }
    
    public IEnumerable<FileReference> Files { get; set; }
}