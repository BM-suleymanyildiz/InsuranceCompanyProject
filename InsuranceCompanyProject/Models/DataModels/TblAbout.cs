//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InsuranceCompanyProject.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblAbout
    {
        public int AboutId { get; set; }
        public string AboutTitle { get; set; }
        public string AboutSubtitle { get; set; }
        public string AboutDescription1 { get; set; }
        public string AboutDescription2 { get; set; }
        public string AboutSlogan1 { get; set; }
        public string AboutSlogan2 { get; set; }
        public string AboutSlogan3 { get; set; }
        public Nullable<int> InsurancePoliciesCount { get; set; }
        public Nullable<int> AwardsCount { get; set; }
        public Nullable<int> SkilledAgentsCount { get; set; }
        public Nullable<int> TeamMembersCount { get; set; }
        public string ImageUrl { get; set; }
    }
}
