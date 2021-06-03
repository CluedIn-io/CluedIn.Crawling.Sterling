using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Sterling.Core.Models
{
    public class Address
    {

        [JsonProperty("addressLine")]
        public string AddressLine { get; set; }

        [JsonProperty("municipality")]
        public string Municipality { get; set; }

        [JsonProperty("regionCode")]
        public string RegionCode { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class AdditionalAddress
    {

        [JsonProperty("addressLine")]
        public string AddressLine { get; set; }

        [JsonProperty("municipality")]
        public string Municipality { get; set; }

        [JsonProperty("regionCode")]
        public string RegionCode { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }
    }

    public class Alias
    {

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("confirmedNoMiddleName")]
        public bool ConfirmedNoMiddleName { get; set; }
    }

    public class Degree
    {

        [JsonProperty("major")]
        public string Major { get; set; }

        [JsonProperty("degreeName")]
        public string DegreeName { get; set; }

        [JsonProperty("degreeType")]
        public string DegreeType { get; set; }

        [JsonProperty("graduationDate")]
        public string GraduationDate { get; set; }

        [JsonProperty("degreeCompleted")]
        public bool DegreeCompleted { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class EducationHistory
    {

        [JsonProperty("schoolName")]
        public string SchoolName { get; set; }

        [JsonProperty("schoolType")]
        public string SchoolType { get; set; }

        [JsonProperty("degree")]
        public Degree Degree { get; set; }

        [JsonProperty("schoolIDNumber")]
        public string SchoolIDNumber { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("aliasGivenName")]
        public string AliasGivenName { get; set; }

        [JsonProperty("aliasFamilyName")]
        public string AliasFamilyName { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class Salary
    {

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("startingSalary")]
        public string StartingSalary { get; set; }

        [JsonProperty("endingSalary")]
        public string EndingSalary { get; set; }
    }

    public class Verification
    {

        [JsonProperty("supervisorGivenName")]
        public string SupervisorGivenName { get; set; }

        [JsonProperty("supervisorFamilyName")]
        public string SupervisorFamilyName { get; set; }

        [JsonProperty("supervisorMiddleName")]
        public string SupervisorMiddleName { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }
    }

    public class EmploymentHistory
    {

        [JsonProperty("employerName")]
        public string EmployerName { get; set; }

        [JsonProperty("currentEmployer")]
        public bool CurrentEmployer { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("employmentType")]
        public string EmploymentType { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("permissionToContact")]
        public bool PermissionToContact { get; set; }

        [JsonProperty("reasonForLeaving")]
        public string ReasonForLeaving { get; set; }

        [JsonProperty("salary")]
        public Salary Salary { get; set; }

        [JsonProperty("verification")]
        public Verification Verification { get; set; }

        [JsonProperty("verifyEmployer")]
        public bool VerifyEmployer { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class IssuingAgency
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }
    }

    public class License
    {

        [JsonProperty("issuingAgency")]
        public IssuingAgency IssuingAgency { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class DriversLicense
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("licenseNumber")]
        public string LicenseNumber { get; set; }

        [JsonProperty("issuingAgency")]
        public string IssuingAgency { get; set; }
    }

    public class Candidate
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("clientReferenceId")]
        public string ClientReferenceId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("confirmedNoMiddleName")]
        public bool ConfirmedNoMiddleName { get; set; }

        [JsonProperty("dob")]
        public string Dob { get; set; }

        [JsonProperty("ssn")]
        public string Ssn { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("additionalAddresses")]
        public List<AdditionalAddress> AdditionalAddresses { get; set; }

        [JsonProperty("aliases")]
        public List<Alias> Aliases { get; set; }

        [JsonProperty("educationHistory")]
        public List<EducationHistory> EducationHistory { get; set; }

        [JsonProperty("employmentHistory")]
        public List<EmploymentHistory> EmploymentHistory { get; set; }

        [JsonProperty("licenses")]
        public List<License> Licenses { get; set; }

        [JsonProperty("screeningIds")]
        public List<object> ScreeningIds { get; set; }

        [JsonProperty("driversLicense")]
        public DriversLicense DriversLicense { get; set; }
    }


}
