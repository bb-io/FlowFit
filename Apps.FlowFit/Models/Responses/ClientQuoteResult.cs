﻿using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ClientQuoteResult 
{
    public string Id { get; set; }
    public string? DisplayNumber { get; set; }
    public string ProjectId { get; set; }
    public string ClientId { get; set; }
    public string ClientDepartmentId { get; set; }
    public string ClientContactId { get; set; }
    public string? BillingAddress { get; set; }
    public string? ShippingAddress { get; set; }
    public string StatusId { get; set; }
    public string? Status { get; set; }
    public string CurrencyId { get; set; }
    public decimal Subtotal { get; set; }
    public decimal? MinimumCost { get; set; }
    public decimal NetTotal { get; set; }
    public decimal Total { get; set; }
    public string TaxId { get; set; }
    public decimal? Tax1Rate { get; set; }
    public decimal? Tax1Amount { get; set; }
    public decimal? Tax2Rate { get; set; }
    public decimal? Tax2Amount { get; set; }
    public string? CustomerComment { get; set; }
    public string? InternalComment { get; set; }
    public DateTime CreationDate { get; set; }
    public string CreatedByUserId { get; set; }
    public DateTime? ModificationDate { get; set; }
    public string ModifiedByUserId { get; set; }
    public DateTime? ValidityDate { get; set; }
    public DateTime? ValidationDate { get; set; }
    public string ValidatedByUserId { get; set; }
    public bool IsUrgent { get; set; }
    public string RefusedByUserId { get; set; }
    public DateTime? RefusalDate { get; set; }
    public string ApprovedByUserId { get; set; }
    public DateTime? ApprovalDate { get; set; }
    public string ClientPriceDefinitionId { get; set; }
    public string DocumentTemplateId { get; set; }
    public string CommunicationLanguageId { get; set; }
    public DateTime? SentDate { get; set; }
    public IEnumerable<ClientQuoteItemResult>? Items { get; set; }
}