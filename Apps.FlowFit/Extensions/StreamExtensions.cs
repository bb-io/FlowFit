using Blackbird.Applications.Sdk.Utils.Extensions.Files;

namespace Apps.FlowFit.Extensions;

public static class StreamExtensions
{
    public static async Task<string> ConvertToBase64String(this Stream fileStream)
    {
        var bytes = await fileStream.GetByteData();
        return Convert.ToBase64String(bytes);
    }
}