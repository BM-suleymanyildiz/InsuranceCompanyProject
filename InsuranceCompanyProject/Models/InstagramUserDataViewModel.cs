using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceCompanyProject.Models
{
    public class InstagramUserDataViewModel
    {
        public class Rootobject
        {
            public int pk { get; set; }
            public string username { get; set; }
            public string full_name { get; set; }
            public bool is_private { get; set; }
            public string profile_pic_url { get; set; }
            public string profile_pic_id { get; set; }
            public bool is_verified { get; set; }
            public int follower_count { get; set; }
            public int following_count { get; set; }
            public string biography { get; set; }
            public Hd_Profile_Pic_Url_Info hd_profile_pic_url_info { get; set; }
            public int account_type { get; set; }
            public Fan_Club_Info fan_club_info { get; set; }
            public bool can_hide_category { get; set; }
            public long fbid_v2 { get; set; }
            public string pk_id { get; set; }
            public bool show_text_post_app_switcher_badge { get; set; }
            public string strong_id__ { get; set; }
            public Biography_With_Entities biography_with_entities { get; set; }
            public int professional_conversion_suggested_account_type { get; set; }
            public Active_Standalone_Fundraisers active_standalone_fundraisers { get; set; }
            public bool has_chaining { get; set; }
            public Hd_Profile_Pic_Versions[] hd_profile_pic_versions { get; set; }
            public string live_subscription_status { get; set; }
            public Pinned_Channels_Info pinned_channels_info { get; set; }
            public bool auto_expand_chaining { get; set; }
            public Avatar_Status avatar_status { get; set; }
            public bool existing_user_age_collection_enabled { get; set; }
            public bool has_private_collections { get; set; }
            public bool has_public_tab_threads { get; set; }
            public bool include_direct_blacklist_status { get; set; }
            public long interop_messaging_user_fbid { get; set; }
            public bool is_direct_roll_call_enabled { get; set; }
            public bool is_profile_broadcast_sharing_enabled { get; set; }
            public bool is_profile_picture_expansion_enabled { get; set; }
            public bool is_remix_setting_enabled_for_posts { get; set; }
            public bool is_remix_setting_enabled_for_reels { get; set; }
            public Nametag nametag { get; set; }
            public bool open_external_url_with_in_app_browser { get; set; }
            public Recs_From_Friends recs_from_friends { get; set; }
            public bool show_account_transparency_details { get; set; }
            public bool show_post_insights_entry_point { get; set; }
            public Chaining_Results[] chaining_results { get; set; }
            public Chaining_Suggestions[] chaining_suggestions { get; set; }
            public Creator_Shopping_Info creator_shopping_info { get; set; }
        }

        public class Hd_Profile_Pic_Url_Info
        {
            public int width { get; set; }
            public int height { get; set; }
            public string url { get; set; }
        }

        public class Fan_Club_Info
        {
        }

        public class Biography_With_Entities
        {
            public string raw_text { get; set; }
        }

        public class Active_Standalone_Fundraisers
        {
        }

        public class Pinned_Channels_Info
        {
        }

        public class Avatar_Status
        {
            public bool has_avatar { get; set; }
        }

        public class Nametag
        {
            public int[] available_theme_colors { get; set; }
            public string background_image_url { get; set; }
            public string emoji { get; set; }
            public int emoji_color { get; set; }
            public int gradient { get; set; }
            public bool is_background_image_blurred { get; set; }
            public int mode { get; set; }
            public int selected_theme_color { get; set; }
            public int selfie_sticker { get; set; }
            public string selfie_url { get; set; }
            public Theme_Color theme_color { get; set; }
        }

        public class Theme_Color
        {
            public Available_Theme_Colors[] available_theme_colors { get; set; }
            public Selected_Theme_Color selected_theme_color { get; set; }
        }

        public class Selected_Theme_Color
        {
            public string display_label { get; set; }
            public int int_value { get; set; }
        }

        public class Available_Theme_Colors
        {
            public string display_label { get; set; }
            public int int_value { get; set; }
        }

        public class Recs_From_Friends
        {
            public string recs_from_friends_entry_point_type { get; set; }
        }

        public class Creator_Shopping_Info
        {
        }

        public class Hd_Profile_Pic_Versions
        {
            public int width { get; set; }
            public int height { get; set; }
            public string url { get; set; }
        }

        public class Chaining_Results
        {
            public Chaining_Info chaining_info { get; set; }
            public string profile_chaining_secondary_label { get; set; }
            public string social_context { get; set; }
            public long pk { get; set; }
            public string username { get; set; }
            public string full_name { get; set; }
            public bool is_private { get; set; }
            public string profile_pic_url { get; set; }
            public string profile_pic_id { get; set; }
            public bool is_verified { get; set; }
            public string pk_id { get; set; }
            public string strong_id__ { get; set; }
            public Avatar_Status1 avatar_status { get; set; }
        }

        public class Chaining_Info
        {
            public object algorithm { get; set; }
            public string sources { get; set; }
        }

        public class Avatar_Status1
        {
            public bool has_avatar { get; set; }
        }

        public class Chaining_Suggestions
        {
            public Chaining_Info1 chaining_info { get; set; }
            public string profile_chaining_secondary_label { get; set; }
            public string social_context { get; set; }
            public long pk { get; set; }
            public string username { get; set; }
            public string full_name { get; set; }
            public bool is_private { get; set; }
            public string profile_pic_url { get; set; }
            public string profile_pic_id { get; set; }
            public bool is_verified { get; set; }
            public string pk_id { get; set; }
            public string strong_id__ { get; set; }
            public Avatar_Status2 avatar_status { get; set; }
        }

        public class Chaining_Info1
        {
            public object algorithm { get; set; }
            public string sources { get; set; }
        }

        public class Avatar_Status2
        {
            public bool has_avatar { get; set; }
        }

    }
}