namespace Apps.FlowFit.Models.Responses.Document;

public record DocumentsResponse<T>(IEnumerable<T> Documents);