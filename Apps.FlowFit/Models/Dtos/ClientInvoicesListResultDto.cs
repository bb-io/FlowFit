namespace Apps.FlowFit.Models.Dtos;

public class ClientInvoicesListResultDto 
{
    public string Id { get; set; }
    public string? DisplayNumber { get; set; }
    public string ClientId { get; set; }
    public string? ClientName { get; set; }
    public string? StatusDescription { get; set; }
    public string? StatusColor { get; set; }
    public string? CurrencyIsoCode { get; set; }
    public decimal Total { get; set; }
    public decimal TotalConverted { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime? ValidityDate { get; set; }
    public string FileId { get; set; }
    public string? FileName { get; set; }
    public int? StatusDisplayOrder { get; set; }
    public string? Quotes { get; set; }
    public string? QuoteDisplayNumber { get; set; }
    public string ClientContactId { get; set; }
    public string? ClientContactName { get; set; }
    public IEnumerable<ClientInvoiceQuotesInformationDTO>? QuotesDetails { get; set; }
    public string? ProjectNumbers { get; set; }
    public string? ProjectDescription { get; set; }
    public IEnumerable<ClientInvoiceProjectInformationDTO>? Projects { get; set; }
    public decimal? Tax { get; set; }
    public bool IsLate { get; set; }
    public string SyncStatusId { get; set; }
    public string? SyncStatusName { get; set; }
    public DateTime? SyncDate { get; set; }
    public string? SyncMessage { get; set; }
    public string? SyncStatusColor { get; set; }
    public DateTime? LastSuccessfulSyncDate { get; set; }
}