namespace Apps.FlowFit.Extensions;

public static class StringExtensions
{
    public static int? ConvertToInt32(this string? value)
        => int.TryParse(value, out var intValue) ? intValue : null;

    public static Stream ConvertFromBase64String(this string base64)
    {
        var bytes = Convert.FromBase64String(base64);
        return new MemoryStream(bytes);
    } 
}