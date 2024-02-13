namespace Apps.FlowFit.Extensions;

public static class StringExtensions
{
    public static int? ConvertToInt32(this string? value)
        => int.TryParse(value, out var intValue) ? intValue : null;
}