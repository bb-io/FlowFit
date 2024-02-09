using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ResourceResult 
{
    public string Id { get; set; }
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? Code { get; set; }
    public string? Position { get; set; }
    public bool IsInternal { get; set; }
    public string? Email { get; set; }
    public string? Commentary { get; set; }
    public string? Availability { get; set; }
    public bool? IsActive { get; set; }
    public string? InactivityReason { get; set; }
    public bool? IsSignedContract { get; set; }
    public bool IsTranslationAgency { get; set; }
    public string? AddressStreetName { get; set; }
    public string? AddressCity { get; set; }
    public string? AddressProvinceState { get; set; }
    public string? AddressPostalCode { get; set; }
    public string AddressCountryId { get; set; }
    public string? HomePhoneNumber { get; set; }
    public string? WorkPhoneNumber { get; set; }
    public string? FaxPhoneNumber { get; set; }
    public string? CellphoneNumber { get; set; }
    public string? EmailAddress1 { get; set; }
    public string? EmailAddress2 { get; set; }
    public string? EmailAddress3 { get; set; }
    public string? WindowsAccount { get; set; }
    public bool IsProjectManager { get; set; }
    public int? EvaluationRating { get; set; }
    public string? CompanyName { get; set; }
    public string? ContactName { get; set; }
    public int? CommunicationLanguage { get; set; }
    public bool IsUsingDefaultWorkingHours { get; set; }
    public decimal? MondayWorkingHours { get; set; }
    public decimal? TuesdayWorkingHours { get; set; }
    public decimal? WednesdayWorkingHours { get; set; }
    public decimal? ThursdayWorkingHours { get; set; }
    public decimal? FridayWorkingHours { get; set; }
    public decimal? SaturdayWorkingHours { get; set; }
    public decimal? SundayWorkingHours { get; set; }
    public bool IsValidationRequired { get; set; }
    public int? StyleRating { get; set; }
    public int? ReliabilityRating { get; set; }
    public string ProfessionalExperienceId { get; set; }
    public string? Signature { get; set; }
    public string FreelancerProfileId { get; set; }
    public string UserGroupId { get; set; }
    public DateTime? HiringDate { get; set; }
    public int ConnectionAttempt { get; set; }
    public int Status { get; set; }
    public string? Timezone { get; set; }
    public bool IsFavorite { get; set; }
    public string? LinkedinUrl { get; set; }
    public string? FacebookUrl { get; set; }
    public string? TwitterUrl { get; set; }
    public string CurrencyId { get; set; }
    public string? Color { get; set; }
    public bool IsCoordinator { get; set; }
    public string? ResourceDisableCommentary { get; set; }
    public bool? IsSuperUser { get; set; }
    public bool IsSystemUser { get; set; }
    public string? UserAD { get; set; }
    public string? CommunicationLang { get; set; }
}