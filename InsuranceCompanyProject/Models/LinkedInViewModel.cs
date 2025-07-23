using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceCompanyProject.Models
{
    public class LinkedInViewModel
    {


        public class Rootobject
        {
            public bool success { get; set; }
            public string message { get; set; }
            public Data data { get; set; }
        }

        public class Data
        {
            public Basic_Info basic_info { get; set; }
            public Experience[] experience { get; set; }
            public Education[] education { get; set; }
            public Certification[] certifications { get; set; }
        }

        public class Basic_Info
        {
            public string fullname { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string headline { get; set; }
            public string public_identifier { get; set; }
            public string profile_picture_url { get; set; }
            public string about { get; set; }
            public Location location { get; set; }
            public object[] creator_hashtags { get; set; }
            public bool is_creator { get; set; }
            public bool is_influencer { get; set; }
            public bool is_premium { get; set; }
            public long created_timestamp { get; set; }
            public bool show_follower_count { get; set; }
            public string background_picture_url { get; set; }
            public string urn { get; set; }
            public int follower_count { get; set; }
            public int connection_count { get; set; }
            public string current_company { get; set; }
            public string current_company_urn { get; set; }
            public string current_company_url { get; set; }
            public object email { get; set; }
        }

        public class Location
        {
            public string country { get; set; }
            public string city { get; set; }
            public string full { get; set; }
            public string country_code { get; set; }
        }

        public class Experience
        {
            public string title { get; set; }
            public string company { get; set; }
            public string location { get; set; }
            public string duration { get; set; }
            public Start_Date start_date { get; set; }
            public End_Date end_date { get; set; }
            public bool is_current { get; set; }
            public string company_linkedin_url { get; set; }
            public string company_logo_url { get; set; }
            public string employment_type { get; set; }
            public string location_type { get; set; }
            public string[] skills { get; set; }
            public string company_id { get; set; }
            public string skills_url { get; set; }
        }

        public class Start_Date
        {
            public int year { get; set; }
            public string month { get; set; }
        }

        public class End_Date
        {
            public int year { get; set; }
            public string month { get; set; }
        }

        public class Education
        {
            public string school { get; set; }
            public string duration { get; set; }
            public string school_linkedin_url { get; set; }
            public string school_logo_url { get; set; }
            public Start_Date1 start_date { get; set; }
            public End_Date1 end_date { get; set; }
            public string school_id { get; set; }
        }

        public class Start_Date1
        {
            public int year { get; set; }
        }

        public class End_Date1
        {
            public int year { get; set; }
        }

        public class Certification
        {
            public string name { get; set; }
            public string issuer { get; set; }
            public string issued_date { get; set; }
        }


    }
}