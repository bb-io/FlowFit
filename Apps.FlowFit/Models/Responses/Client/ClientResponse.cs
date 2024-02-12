using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Responses.Client;

public class ClientResponse : ClientSimpleResponse
{
    public string? Requirements { get; set; }
    
    [Display("Is active")]
    public bool IsActive { get; set; }
    
    [Display("Module ID")]
    public string ModuleId { get; set; }
    
    public string? Module { get; set; }
    
    [Display("Domain ID")]
    public string DomainId { get; set; }
    
    public string? Domain { get; set; }
    
    [Display("Project manager ID")]
    public string ProjectManagerId { get; set; }
    
    [Display("Project manager")]
    public string? ProjectManager { get; set; }
    
    [Display("Project template ID")]
    public string ProjectTemplateId { get; set; }
    
    [Display("Email domains")]
    public string? EmailDomains { get; set; }
    
    [Display("Last project created date")]
    public DateTime? LastProjectCreatedDate { get; set; }
    
    public string? Email { get; set; }
    
    [Display("Phone number")]
    public string? PhoneNumber { get; set; }
    
    [Display("Other phone number")]
    public string? OtherPhoneNumber { get; set; }
    
    public string? Fax { get; set; }
    
    [Display("LinkedIn URL")]
    public string? LinkedInUrl { get; set; }
    
    [Display("Facebook URL")]
    public string? FacebookUrl { get; set; }
    
    [Display("Twitter URL")]
    public string? TwitterUrl { get; set; }
    
    [Display("Website URL")]
    public string? WebsiteUrl { get; set; }
    
    [Display("Delivery email template ID")]
    public string DeliveryEmailTemplateId { get; set; }
    
    [Display("Billing address")]
    public string? BillingAddress { get; set; }
    
    [Display("Shipping address")]
    public string? ShippingAddress { get; set; }
    
    public string? City { get; set; }
    
    public string? Country { get; set; }
    
    [Display("State province")]
    public string? StateProvince { get; set; }
    
    [Display("Postal zip code")]
    public string? PostalZipCode { get; set; }
}