namespace RapidApiConsumeProject.Models
{
    public class HotelDetailViewModel
    {

       
            public string url { get; set; }
            public Payment_Detail payment_detail { get; set; }
            public int duplicate_rates_removed { get; set; }
            public string cc_required { get; set; }
            public Composite_Price_Breakdown composite_price_breakdown { get; set; }
            public int total_blocks { get; set; }
            public string city_in_trans { get; set; }
            public string address_trans { get; set; }
            public Room_Recommendation[] room_recommendation { get; set; }
            public Property_Highlight_Strip[] property_highlight_strip { get; set; }
            public string default_wishlist_name { get; set; }
            public int hotel_id { get; set; }
            public int soldout { get; set; }
            public Languages_Spoken languages_spoken { get; set; }
            public string rare_find_state { get; set; }
            public int b_legal_use_neutral_color_for_persuasion_legal { get; set; }
            public string plq_sensitivity { get; set; }
            public int ufi { get; set; }
            public string city_trans { get; set; }
            public int is_cash_accepted_check_enabled { get; set; }
            public float latitude { get; set; }
            public string accommodation_type_name { get; set; }
            public string hotel_name { get; set; }
            public int cant_book { get; set; }
            public int is_tpi_exclusive_property { get; set; }
            public Min_Room_Distribution min_room_distribution { get; set; }
            public float distance_to_cc { get; set; }
            public string average_room_size_for_ufi_m2 { get; set; }
            public int is_in_real_heart { get; set; }
            public int nr_bookings_today { get; set; }
            public Last_Reservation last_reservation { get; set; }
            public int b_blackout_android_prepayment_copy { get; set; }
            public int is_preferred_plus { get; set; }
            public Wifi_Review_Score wifi_review_score { get; set; }
            public string countrycode { get; set; }
            public Rooms rooms { get; set; }
            public int review_nr { get; set; }
            public string payment_product { get; set; }
            public int block_count { get; set; }
            public object[] tax_exceptions { get; set; }
            public string urgency_room_string { get; set; }
            public string[] family_facilities { get; set; }
            public int address_required { get; set; }
            public Booking_Home booking_home { get; set; }
            public string departure_date { get; set; }
            public string default_language { get; set; }
            public int is_hotel_ctrip { get; set; }
            public int is_closed { get; set; }
            public Hotel_Text hotel_text { get; set; }
            public string currency_code { get; set; }
            public string[] spoken_languages { get; set; }
            public int hotel_include_breakfast { get; set; }
            public string zip { get; set; }
      
            public string cc1 { get; set; }
            public int class_is_estimated { get; set; }
            public int check_only_x_left { get; set; }
            public Aggregated_Data aggregated_data { get; set; }
            public int is_family_friendly { get; set; }
            public string hotel_facilities { get; set; }
            public Breakfast_Review_Score breakfast_review_score { get; set; }
            public int available_rooms { get; set; }
            public int max_rooms_in_reservation { get; set; }
            public int is_preferred { get; set; }
            public string cvc_required { get; set; }
            public string arrival_date { get; set; }
            public string timezone { get; set; }
            public int mf_rate_selection { get; set; }
            public Block[] block { get; set; }
            public Top_Ufi_Benefits[] top_ufi_benefits { get; set; }
            public string country_trans { get; set; }
            public string address { get; set; }
            public B_Max_Los_Data b_max_los_data { get; set; }
            public int seen_cc_app_hp_missing_info { get; set; }
            public int has_theme_park_benefits { get; set; }
            public int is_cpv2_property { get; set; }
            public int is_city_center { get; set; }
            public string city { get; set; }
            public int[] districts { get; set; }
            public int can_show_room_filters { get; set; }
            public string hotel_name_trans { get; set; }
            public int b_sca_flow_property_user_ip { get; set; }
            public int is_crimea { get; set; }
            public int district_id { get; set; }
            public Only_X_Left only_x_left { get; set; }
            public string district { get; set; }
            public Facilities_Block facilities_block { get; set; }
            public string recommended_block_title { get; set; }
            public float longitude { get; set; }
            public string wl_dest_id { get; set; }
            public int accommodation_type { get; set; }
            public string city_name_en { get; set; }
            public object[] available_deal_descriptions { get; set; }
            public int seen_cc_app_rp_missing_fac { get; set; }
            public int qualifies_for_no_cc_reservation { get; set; }
            public int use_new_bui_icon_highlight { get; set; }
            public Preference[] preferences { get; set; }
            public object is_exclusive { get; set; }
            public int is_vp2_enrolled { get; set; }
    

        public class Payment_Detail
        {
            public string model { get; set; }
        }

        public class Composite_Price_Breakdown
        {
         
       
            public All_Inclusive_Amount all_inclusive_amount { get; set; }
        
        }

        public class Gross_Amount
        {
            public string amount_unrounded { get; set; }
            public string currency { get; set; }
            public string amount_rounded { get; set; }
            public float value { get; set; }
        }

        public class Included_Taxes_And_Charges_Amount
        {
            public string currency { get; set; }
            public string amount_unrounded { get; set; }
            public string amount_rounded { get; set; }
            public float value { get; set; }
        }

        public class All_Inclusive_Amount
        {
            public float value { get; set; }
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class Charges_Details
        {
            public Amount amount { get; set; }
            public string mode { get; set; }
            public string translated_copy { get; set; }
        }

        public class Amount
        {
            public string currency { get; set; }
            public float value { get; set; }
        }

        public class Client_Translations
        {
            public string tooltip_total_text { get; set; }
        }

        public class Excluded_Amount
        {
            public string currency { get; set; }
            public string amount_unrounded { get; set; }
            public string amount_rounded { get; set; }
            public float value { get; set; }
        }

        public class Gross_Amount_Per_Night
        {
            public float value { get; set; }
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class Gross_Amount_Hotel_Currency
        {
            public string currency { get; set; }
            public string amount_unrounded { get; set; }
            public int value { get; set; }
            public string amount_rounded { get; set; }
        }

        public class Net_Amount
        {
            public string amount_unrounded { get; set; }
            public string currency { get; set; }
            public string amount_rounded { get; set; }
            public float value { get; set; }
        }

        public class Item
        {
            public string name { get; set; }
            public string details { get; set; }
            public string kind { get; set; }
            public Base _base { get; set; }
            public Item_Amount item_amount { get; set; }
            public string inclusion_type { get; set; }
        }

        public class Base
        {
            public string kind { get; set; }
            public float percentage { get; set; }
            public float base_amount { get; set; }
        }

        public class Item_Amount
        {
            public string amount_unrounded { get; set; }
            public string currency { get; set; }
            public float value { get; set; }
            public string amount_rounded { get; set; }
        }

        public class Languages_Spoken
        {
            public string[] languagecode { get; set; }
        }

        public class Min_Room_Distribution
        {
            public object[] children { get; set; }
            public int adults { get; set; }
        }

        public class Last_Reservation
        {
            public object country { get; set; }
            public object countrycode { get; set; }
            public string time { get; set; }
        }

        public class Wifi_Review_Score
        {
            public float rating { get; set; }
        }

        public class Rooms
        {
            public _167616101 _167616101 { get; set; }
        }
    
        public class _167616101
        {
            public Private_Bathroom_Highlight private_bathroom_highlight { get; set; }
            public int private_bathroom_count { get; set; }
            public Facility[] facilities { get; set; }
            public object apartment_configuration { get; set; }
            public int photos_may_sorted { get; set; }
            public Highlight[] highlights { get; set; }
            public Bed_Configurations[] bed_configurations { get; set; }
            public Children_And_Beds_Text children_and_beds_text { get; set; }
            public int is_high_floor_guaranteed { get; set; }
            public Photo[] photos { get; set; }
    
        }

        public class Private_Bathroom_Highlight
        {
            public int has_highlight { get; set; }
            public string text { get; set; }
        }

        public class Children_And_Beds_Text
        {
            public Children_At_The_Property[] children_at_the_property { get; set; }
            public Cribs_And_Extra_Beds[] cribs_and_extra_beds { get; set; }
            public Age_Intervals[] age_intervals { get; set; }
            public int allow_children { get; set; }
        }

        public class Children_At_The_Property
        {
            public string text { get; set; }
            public int highlight { get; set; }
        }

        public class Cribs_And_Extra_Beds
        {
            public int highlight { get; set; }
            public string text { get; set; }
        }

        public class Age_Intervals
        {
            public int min_age { get; set; }
            public int max_age { get; set; }
            public string[][] types_by_price { get; set; }
            public Crib crib { get; set; }
            public Extra_Bed extra_bed { get; set; }
            public Group_By_Price group_by_price { get; set; }
        }

        public class Crib
        {
            public int price_type_n { get; set; }
            public int id { get; set; }
            public string price_type { get; set; }
            public int price { get; set; }
            public string price_mode { get; set; }
            public int price_mode_n { get; set; }
        }

        public class Extra_Bed
        {
            public string price_type { get; set; }
            public int id { get; set; }
            public int price_type_n { get; set; }
            public string price { get; set; }
            public int price_mode_n { get; set; }
            public string price_mode { get; set; }
        }

        public class Group_By_Price
        {
            public string[] freeper_night0 { get; set; }
            public string[] fixedper_night13890 { get; set; }
        }

        public class Facility
        {
            public int alt_facilitytype_id { get; set; }
            public string facilitytype_name { get; set; }
            public string name { get; set; }
            public string alt_facilitytype_name { get; set; }
            public int id { get; set; }
            public int facilitytype_id { get; set; }
        }

        public class Highlight
        {
            public string icon { get; set; }
            public string translated_name { get; set; }
            public int id { get; set; }
        }

        public class Bed_Configurations
        {
            public Bed_Types[] bed_types { get; set; }
        }

        public class Bed_Types
        {
            public int bed_type { get; set; }
            public string name { get; set; }
            public string description_imperial { get; set; }
            public string description { get; set; }
            public int count { get; set; }
            public string name_with_count { get; set; }
            public object description_localized { get; set; }
        }

        public class Photo
        {
            public int new_order { get; set; }
            public int photo_id { get; set; }
            public string last_update_date { get; set; }
            public string url_original { get; set; }
            public string url_square60 { get; set; }
            public float ratio { get; set; }
            public string url_max300 { get; set; }
            public string url_640x200 { get; set; }
        }

        public class Booking_Home
        {
        }

        public class Hotel_Text
        {
        }

        public class Aggregated_Data
        {
            public int has_kitchen { get; set; }
            public int has_seating { get; set; }
            public Common_Kitchen_Fac[] common_kitchen_fac { get; set; }
            public int has_nonrefundable { get; set; }
            public int has_refundable { get; set; }
        }

        public class Common_Kitchen_Fac
        {
            public string name { get; set; }
            public int id { get; set; }
        }

        public class Breakfast_Review_Score
        {
            public int review_count { get; set; }
            public string review_snippet { get; set; }
            public string review_score_word { get; set; }
            public float rating { get; set; }
            public float review_score { get; set; }
            public int review_number { get; set; }
        }

        public class B_Max_Los_Data
        {
            public string experiment { get; set; }
            public int default_los { get; set; }
            public int has_extended_los { get; set; }
            public int extended_los { get; set; }
            public int is_fullon { get; set; }
            public int max_allowed_los { get; set; }
        }

        public class Only_X_Left
        {
            public Microfunnel_Rooms_List microfunnel_rooms_list { get; set; }
            public Rooms_List rooms_list { get; set; }
            public Post_Select post_select { get; set; }
            public Room_Page room_page { get; set; }
            public Microfunnel_Rate_Selection microfunnel_rate_selection { get; set; }
        }

        public class Microfunnel_Rooms_List
        {
            public string _167616102 { get; set; }
            public string _167616103 { get; set; }
        }

        public class Rooms_List
        {
            public string _167616103_310333226_1_1_0 { get; set; }
            public string _167616103_310333226_0_1_0 { get; set; }
            public string _167616102_310333226_0_1_0 { get; set; }
        }

        public class Post_Select
        {
            public string _167616102_310333226_0_1_0 { get; set; }
            public string _167616103_310333226_0_1_0 { get; set; }
            public string _167616103_310333226_1_1_0 { get; set; }
        }

        public class Room_Page
        {
            public string _167616103_310333226_0_1_0 { get; set; }
            public string _167616103_310333226_1_1_0 { get; set; }
            public string _167616102_310333226_0_1_0 { get; set; }
        }

        public class Microfunnel_Rate_Selection
        {
        }

        public class Facilities_Block
        {
            public string name { get; set; }
            public string type { get; set; }
            public Facility1[] facilities { get; set; }
        }

        public class Facility1
        {
            public string name { get; set; }
            public string icon { get; set; }
        }

        public class Room_Recommendation
        {
            public float number_of_extra_beds { get; set; }
            public string block_id { get; set; }
            public int babies { get; set; }
            public int children { get; set; }
            public int total_extra_bed_price_in_hotel_currency { get; set; }
            public int total_extra_bed_price { get; set; }
            public int adults { get; set; }
        }

        public class Property_Highlight_Strip
        {
            public string name { get; set; }
            public Icon_List[] icon_list { get; set; }
        }

        public class Icon_List
        {
            public int size { get; set; }
            public string icon { get; set; }
        }

        public class Block
        {
            public int is_last_minute_deal { get; set; }
            public int nr_children { get; set; }
            public int package_id { get; set; }
            public int fc_deadline_till_midnight { get; set; }
            public string refundable_until { get; set; }
            public int refundable { get; set; }
            public string mealplan { get; set; }
            public int is_mobile_deal { get; set; }
            public int full_board { get; set; }
            public int max_children_free { get; set; }
            public int max_children_free_age { get; set; }
            public int roomtype_id { get; set; }
            public int breakfast_included { get; set; }
            public object extrabed_available_amount { get; set; }
            public Deals deals { get; set; }
            public int is_domestic_rate { get; set; }
            public int nr_adults { get; set; }
            public int dinner_included { get; set; }
            public int is_smart_deal { get; set; }
            public int lunch_included { get; set; }
            public int number_of_bathrooms { get; set; }
            public string max_occupancy { get; set; }
            public int is_dormitory { get; set; }
            public string name { get; set; }
            public object[] bh_room_highlights { get; set; }
            public int pod_ios_migrate_policies_to_smp_fullon { get; set; }
            public int room_id { get; set; }
            public int smoking { get; set; }
            public string room_name { get; set; }
           
            public int room_surface_in_m2 { get; set; }
            public Loyalty_Reward_Data loyalty_reward_data { get; set; }
            public int is_secret_deal { get; set; }
            public string block_id { get; set; }
            public int number_of_bedrooms { get; set; }
            public int half_board { get; set; }
            public Block_Text block_text { get; set; }
            public int all_inclusive { get; set; }
            public int must_reserve_free_parking { get; set; }
            public int is_flash_deal { get; set; }
            public Detail_Mealplan[] detail_mealplan { get; set; }
            public int babycots_available { get; set; }
            public int genius_discount_percentage { get; set; }
            public object is_genius_deal { get; set; }
            public object[] children_ages { get; set; }
            public int room_count { get; set; }
            public int deposit_required { get; set; }
            public int is_block_fit { get; set; }
            public int can_reserve_free_parking { get; set; }
            public string name_without_policy { get; set; }
            public int extrabed_available { get; set; }
            public float room_surface_in_feet2 { get; set; }
      
            public object[] b_bsb_campaigns { get; set; }
            public object babycots_available_amount { get; set; }
        }

        public class Deals
        {
            public Deal_Attributes deal_attributes { get; set; }
        }

        public class Deal_Attributes
        {
            public int has_secret_channel_option { get; set; }
        }

      

        public class Included_Taxes_And_Charges_Amount1
        {
            public float value { get; set; }
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class Gross_Amount1
        {
            public float value { get; set; }
            public string amount_rounded { get; set; }
            public string amount_unrounded { get; set; }
            public string currency { get; set; }
        }

        public class All_Inclusive_Amount1
        {
            public float value { get; set; }
            public string amount_rounded { get; set; }
            public string amount_unrounded { get; set; }
            public string currency { get; set; }
        }

        public class Excluded_Amount1
        {
            public float value { get; set; }
            public string amount_rounded { get; set; }
            public string amount_unrounded { get; set; }
            public string currency { get; set; }
        }

        public class Net_Amount1
        {
            public string currency { get; set; }
            public string amount_unrounded { get; set; }
            public float value { get; set; }
            public string amount_rounded { get; set; }
        }

        public class Gross_Amount_Hotel_Currency1
        {
            public string amount_unrounded { get; set; }
            public string currency { get; set; }
            public string amount_rounded { get; set; }
            public int value { get; set; }
        }

        public class Gross_Amount_Per_Night1
        {
            public string currency { get; set; }
            public string amount_unrounded { get; set; }
            public float value { get; set; }
            public string amount_rounded { get; set; }
        }

        public class Client_Translations1
        {
            public string tooltip_total_text { get; set; }
        }

        public class Charges_Details1
        {
            public string mode { get; set; }
            public string translated_copy { get; set; }
            public Amount1 amount { get; set; }
        }

        public class Amount1
        {
            public string currency { get; set; }
            public float value { get; set; }
        }

        public class Item1
        {
            public string name { get; set; }
            public string details { get; set; }
            public string kind { get; set; }
            public Item_Amount1 item_amount { get; set; }
            public Base1 _base { get; set; }
            public string inclusion_type { get; set; }
        }

        public class Item_Amount1
        {
            public string amount_unrounded { get; set; }
            public string currency { get; set; }
            public float value { get; set; }
            public string amount_rounded { get; set; }
        }

        public class Base1
        {
            public float percentage { get; set; }
            public string kind { get; set; }
            public float base_amount { get; set; }
        }

        public class Loyalty_Reward_Data
        {
            public object[] reward_detail { get; set; }
        }

        public class Block_Text
        {
            public Policy[] policies { get; set; }
        }

        public class Policy
        {
            public string content { get; set; }
            public string _class { get; set; }
            public string currencycode { get; set; }
            public float price { get; set; }
            public string mealplan_vector { get; set; }
        }

      


        public class Info
        {
            public string date_raw { get; set; }
            public string date { get; set; }
            public int refundable { get; set; }
            public DateTime refundable_date { get; set; }
            public string date_before { get; set; }
            public DateTime refundable_date_midnight { get; set; }
            public int is_midnight { get; set; }
            public string time_before_midnight { get; set; }
            public string time { get; set; }
            public string timezone { get; set; }
            public string date_before_raw { get; set; }
            public string timezone_offset { get; set; }
        }

        public class Timeline
        {
            public int nr_stages { get; set; }
            public string policygroup_instance_id { get; set; }
            public string u_currency_code { get; set; }
            public Stage[] stages { get; set; }
            public string currency_code { get; set; }
        }

        public class Stage
        {
            public int is_effective { get; set; }
            public string limit_until_time { get; set; }
            public string limit_from { get; set; }
            public string limit_from_date { get; set; }
            public string limit_until_raw { get; set; }
            public string limit_from_time { get; set; }
            public string text { get; set; }
            public int effective_number { get; set; }
            public string stage_fee_pretty { get; set; }
            public int stage_fee { get; set; }
            public string fee_remaining_pretty { get; set; }
            public string u_fee { get; set; }
            public string u_fee_remaining { get; set; }
            public string limit_until_date { get; set; }
            public string u_fee_pretty { get; set; }
            public string date_until { get; set; }
            public int current_stage { get; set; }
            public string limit_timezone { get; set; }
            public int fee { get; set; }
            public string limit_from_raw { get; set; }
            public int is_free { get; set; }
            public string u_stage_fee { get; set; }
            public string u_stage_fee_pretty { get; set; }
            public string text_refundable { get; set; }
            public float fee_rounded { get; set; }
            public string stage_translation { get; set; }
            public string fee_pretty { get; set; }
            public string b_state { get; set; }
            public int fee_remaining { get; set; }
            public string limit_until { get; set; }
            public int b_number { get; set; }
            public string u_fee_remaining_pretty { get; set; }
            public float amount { get; set; }
            public string amount_pretty { get; set; }
            public string date_from { get; set; }
        }

        public class Prepayment
        {
            public string type { get; set; }
            public string type_extended { get; set; }
            public Timeline1 timeline { get; set; }
            public string description { get; set; }
            public string type_translation { get; set; }
            public string extended_type_translation { get; set; }
            public Info1 info { get; set; }
            public string simple_translation { get; set; }
        }

        public class Timeline1
        {
            public string policygroup_instance_id { get; set; }
            public int nr_stages { get; set; }
            public string currency_code { get; set; }
            public string u_currency_code { get; set; }
            public Stage1[] stages { get; set; }
        }

        public class Stage1
        {
            public string b_state { get; set; }
            public string limit_until { get; set; }
            public string u_fee_remaining_pretty { get; set; }
            public int b_number { get; set; }
            public int fee_remaining { get; set; }
            public string fee_pretty { get; set; }
            public float fee_rounded { get; set; }
            public string u_stage_fee_pretty { get; set; }
            public int is_free { get; set; }
            public string limit_from_raw { get; set; }
            public string u_stage_fee { get; set; }
            public string amount_pretty { get; set; }
            public int fee { get; set; }
            public string limit_timezone { get; set; }
            public string u_fee_pretty { get; set; }
            public int current_stage { get; set; }
            public string limit_until_date { get; set; }
            public string u_fee { get; set; }
            public string u_fee_remaining { get; set; }
            public string fee_remaining_pretty { get; set; }
            public int stage_fee { get; set; }
            public int effective_number { get; set; }
            public string stage_fee_pretty { get; set; }
            public string amount { get; set; }
            public string text { get; set; }
            public string limit_from { get; set; }
            public string limit_from_date { get; set; }
            public string limit_until_raw { get; set; }
            public string limit_from_time { get; set; }
            public int is_effective { get; set; }
            public string limit_until_time { get; set; }
            public int after_checkin { get; set; }
        }

        public class Info1
        {
            public object time_before_midnight { get; set; }
            public object is_midnight { get; set; }
            public object date_before { get; set; }
            public object date { get; set; }
            public object time { get; set; }
            public string refundable { get; set; }
            public int prepayment_at_booktime { get; set; }
            public object timezone_offset { get; set; }
            public object timezone { get; set; }
        }

        public class Detail_Mealplan
        {
            public string title { get; set; }
            public string currency { get; set; }
            public float price { get; set; }
            public string icon { get; set; }
        }

        public class Top_Ufi_Benefits
        {
            public string translated_name { get; set; }
            public string icon { get; set; }
        }

        public class Preference
        {
            public string icon_name { get; set; }
            public string id { get; set; }
            public int is_disabled { get; set; }
            public string text { get; set; }
            public Choice[] choices { get; set; }
            public string[] room_ids { get; set; }
        }

        public class Choice
        {
            public int id { get; set; }
            public string text { get; set; }
            public int selected { get; set; }
            public string description { get; set; }
            public string on_select_text { get; set; }
        }

    }
}
