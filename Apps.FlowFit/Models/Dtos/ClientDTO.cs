namespace Apps.FlowFit.Models.Dtos;

public class ClientDTO 
{
    public string Name { get; set; }
    public string? Code { get; set; }
    public string? Requirements { get; set; }
    public bool IsActive { get; set; }
    public string ClientGroupId { get; set; }
    public string ModuleId { get; set; }
    public string DomainId { get; set; }
    public string ProjectManagerId { get; set; }
    public string ProjectTemplateId { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? OtherPhoneNumber { get; set; }
    public string? Fax { get; set; }
    public string? LinkedInUrl { get; set; }
    public string? FacebookUrl { get; set; }
    public string? TwitterUrl { get; set; }
    public string? WebsiteUrl { get; set; }
    public string DeliveryEmailTemplateId { get; set; }
    public string? EmailDomains { get; set; }
    public string? BillingAddress { get; set; }
    public string? ShippingAddress { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? StateProvince { get; set; }
    public string? PostalZipCode { get; set; }
}