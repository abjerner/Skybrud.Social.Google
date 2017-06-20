// This class is auto-generated based on metrics from the Google Analytics API. If you have suggestions for any
// changes, please create a new issue at https://github.com/abjerner/Skybrud.Social/issues/new

using System;

namespace Skybrud.Social.Google.Analytics.Models.Dimensions {

    /// <summary>
    /// Static class with constants for the various dimensions of the Google Analytics API.
    /// </summary>
    public static class AnalyticsDimensions {

        // ReSharper disable InconsistentNaming

        #region User

        /// <summary>
        /// A boolean indicating if a user is new or returning. Possible values: New Visitor, Returning Visitor (id: <code>ga:userType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_usertype</cref>
        /// </see>
        public static readonly AnalyticsDimension UserType = AnalyticsDimension.Register("ga:userType", "User");

        /// <summary>
        /// A boolean indicating if a user is new or returning. Possible values: New Visitor, Returning Visitor (id: <code>ga:visitorType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_visitortype</cref>
        /// </see>
        [Obsolete("Use ga:userType instead.")]
        public static readonly AnalyticsDimension VisitorType = AnalyticsDimension.Register("ga:visitorType", "User", true);

        /// <summary>
        /// Gets the session index for a user. Each session from a unique user will get its own incremental index starting from 1 for the first session. Subsequent sessions do not change previous session indicies. For example, if a certain user has 4 sessions to your website, sessionCount for that user will have 4 distinct values of '1' through '4' (id: <code>ga:sessionCount)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_sessioncount</cref>
        /// </see>
        public static readonly AnalyticsDimension SessionCount = AnalyticsDimension.Register("ga:sessionCount", "User");

        /// <summary>
        /// Gets the session index for a user. Each session from a unique user will get its own incremental index starting from 1 for the first session. Subsequent sessions do not change previous session indicies. For example, if a certain user has 4 sessions to your website, sessionCount for that user will have 4 distinct values of '1' through '4' (id: <code>ga:visitCount)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_visitcount</cref>
        /// </see>
        [Obsolete("Use ga:sessionCount instead.")]
        public static readonly AnalyticsDimension VisitCount = AnalyticsDimension.Register("ga:visitCount", "User", true);

        /// <summary>
        /// Gets the number of days elapsed since users last visited your property. Used to calculate user loyalty (id: <code>ga:daysSinceLastSession)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_dayssincelastsession</cref>
        /// </see>
        public static readonly AnalyticsDimension DaysSinceLastSession = AnalyticsDimension.Register("ga:daysSinceLastSession", "User");

        /// <summary>
        /// Gets the number of days elapsed since users last visited your property. Used to calculate user loyalty (id: <code>ga:daysSinceLastVisit)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_dayssincelastvisit</cref>
        /// </see>
        [Obsolete("Use ga:daysSinceLastSession instead.")]
        public static readonly AnalyticsDimension DaysSinceLastVisit = AnalyticsDimension.Register("ga:daysSinceLastVisit", "User", true);

        /// <summary>
        /// Gets the value provided when you define custom user segments for your property (id: <code>ga:userDefinedValue)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_userdefinedvalue</cref>
        /// </see>
        public static readonly AnalyticsDimension UserDefinedValue = AnalyticsDimension.Register("ga:userDefinedValue", "User");

        #endregion

        #region Session

        /// <summary>
        /// Gets the length of a session measured in seconds and reported in second increments. The value returned is a string (id: <code>ga:sessionDurationBucket)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_sessiondurationbucket</cref>
        /// </see>
        public static readonly AnalyticsDimension SessionDurationBucket = AnalyticsDimension.Register("ga:sessionDurationBucket", "Session");

        /// <summary>
        /// Gets the length of a session measured in seconds and reported in second increments. The value returned is a string (id: <code>ga:visitLength)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_visitlength</cref>
        /// </see>
        [Obsolete("Use ga:sessionDurationBucket instead.")]
        public static readonly AnalyticsDimension VisitLength = AnalyticsDimension.Register("ga:visitLength", "Session", true);

        #endregion

        #region Traffic Sources

        /// <summary>
        /// Gets the path of the referring URL (e.g. document.referrer). If someone places a link to your property on their website, this element contains the path of the page that contains the referring link (id: <code>ga:referralPath)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_referralpath</cref>
        /// </see>
        public static readonly AnalyticsDimension ReferralPath = AnalyticsDimension.Register("ga:referralPath", "Traffic Sources");

        /// <summary>
        /// Gets the full referring URL including the hostname and path (id: <code>ga:fullReferrer)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_fullreferrer</cref>
        /// </see>
        public static readonly AnalyticsDimension FullReferrer = AnalyticsDimension.Register("ga:fullReferrer", "Traffic Sources");

        /// <summary>
        /// When using manual campaign tracking, the value of the utm_campaign campaign tracking parameter. When using AdWords autotagging, the name(s) of the online ad campaign that you use for your property. Otherwise the value (not set) is used (id: <code>ga:campaign)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_campaign</cref>
        /// </see>
        public static readonly AnalyticsDimension Campaign = AnalyticsDimension.Register("ga:campaign", "Traffic Sources");

        /// <summary>
        /// Gets the source of referrals. When using manual campaign tracking, the value of the utm_source campaign tracking parameter. When using AdWords autotagging, the value is google. Otherwise the domain of the source referring the user (e.g. document.referrer). The value may also contain a port address. If the user arrived without a referrer, the value is (direct) (id: <code>ga:source)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_source</cref>
        /// </see>
        public static readonly AnalyticsDimension Source = AnalyticsDimension.Register("ga:source", "Traffic Sources");

        /// <summary>
        /// Gets the type of referrals. When using manual campaign tracking, the value of the utm_medium campaign tracking parameter. When using AdWords autotagging, the value is ppc. If the user comes from a search engine detected by Google Analytics, the value is organic. If the referrer is not a search engine, the value is referral. If the users came directly to the property, and document.referrer is empty, the value is (none) (id: <code>ga:medium)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_medium</cref>
        /// </see>
        public static readonly AnalyticsDimension Medium = AnalyticsDimension.Register("ga:medium", "Traffic Sources");

        /// <summary>
        /// Combined values of <code>ga:source</code> and <code>ga:medium</code> (id: <code>ga:sourceMedium)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_sourcemedium</cref>
        /// </see>
        public static readonly AnalyticsDimension SourceMedium = AnalyticsDimension.Register("ga:sourceMedium", "Traffic Sources");

        /// <summary>
        /// When using manual campaign tracking, the value of the utm_term campaign tracking parameter. When using AdWords autotagging or if a user used organic search to reach your property, the keywords used by users to reach your property. Otherwise the value is (not set) (id: <code>ga:keyword)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_keyword</cref>
        /// </see>
        public static readonly AnalyticsDimension Keyword = AnalyticsDimension.Register("ga:keyword", "Traffic Sources");

        /// <summary>
        /// When using manual campaign tracking, the value of the utm_content campaign tracking parameter. When using AdWords autotagging, the first line of the text for your online Ad campaign. If you are using mad libs for your AdWords content, this field displays the keywords you provided for the mad libs keyword match. Otherwise the value is (not set) (id: <code>ga:adContent)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_adcontent</cref>
        /// </see>
        public static readonly AnalyticsDimension AdContent = AnalyticsDimension.Register("ga:adContent", "Traffic Sources");

        /// <summary>
        /// Name of the social network. This can be related to the referring social network for traffic sources, or to the social network for social data hub activities. E.g. Google+, Blogger, etc (id: <code>ga:socialNetwork)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_socialnetwork</cref>
        /// </see>
        public static readonly AnalyticsDimension SocialNetwork = AnalyticsDimension.Register("ga:socialNetwork", "Traffic Sources");

        /// <summary>
        /// Indicates sessions that arrived to the property from a social source. The possible values are Yes or No where the first letter is capitalized (id: <code>ga:hasSocialSourceReferral)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_hassocialsourcereferral</cref>
        /// </see>
        public static readonly AnalyticsDimension HasSocialSourceReferral = AnalyticsDimension.Register("ga:hasSocialSourceReferral", "Traffic Sources");

        /// <summary>
        /// When using manual campaign tracking, the value of the utm_id campaign tracking parameter (id: <code>ga:campaignCode)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_campaigncode</cref>
        /// </see>
        public static readonly AnalyticsDimension CampaignCode = AnalyticsDimension.Register("ga:campaignCode", "Traffic Sources");

        #endregion

        #region Adwords

        /// <summary>
        /// Gets the name of your AdWords ad group (id: <code>ga:adGroup)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adgroup</cref>
        /// </see>
        public static readonly AnalyticsDimension AdGroup = AnalyticsDimension.Register("ga:adGroup", "Adwords");

        /// <summary>
        /// Gets the location of the advertisement on the hosting page (Top, RHS, or not set) (id: <code>ga:adSlot)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adslot</cref>
        /// </see>
        public static readonly AnalyticsDimension AdSlot = AnalyticsDimension.Register("ga:adSlot", "Adwords");

        /// <summary>
        /// This dimension is deprecated and will be removed soon (id: <code>ga:adSlotPosition)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adslotposition</cref>
        /// </see>
        [Obsolete]
        public static readonly AnalyticsDimension AdSlotPosition = AnalyticsDimension.Register("ga:adSlotPosition", "Adwords", true);

        /// <summary>
        /// Gets the networks used to deliver your ads (Content, Search, Search partners, etc.) (id: <code>ga:adDistributionNetwork)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_addistributionnetwork</cref>
        /// </see>
        public static readonly AnalyticsDimension AdDistributionNetwork = AnalyticsDimension.Register("ga:adDistributionNetwork", "Adwords");

        /// <summary>
        /// Gets the match types applied for the search term the user had input(Phrase, Exact, Broad, etc.). Ads on the content network are identified as "Content network". Details: https://support.google.com/adwords/answer/2472708?hl=en (id: <code>ga:adMatchType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_admatchtype</cref>
        /// </see>
        public static readonly AnalyticsDimension AdMatchType = AnalyticsDimension.Register("ga:adMatchType", "Adwords");

        /// <summary>
        /// Gets the match types applied to your keywords (Phrase, Exact, Broad). Details: https://support.google.com/adwords/answer/2472708?hl=en (id: <code>ga:adKeywordMatchType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adkeywordmatchtype</cref>
        /// </see>
        public static readonly AnalyticsDimension AdKeywordMatchType = AnalyticsDimension.Register("ga:adKeywordMatchType", "Adwords");

        /// <summary>
        /// Gets the search queries that triggered impressions of your AdWords ads (id: <code>ga:adMatchedQuery)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_admatchedquery</cref>
        /// </see>
        public static readonly AnalyticsDimension AdMatchedQuery = AnalyticsDimension.Register("ga:adMatchedQuery", "Adwords");

        /// <summary>
        /// Gets the domains where your ads on the content network were placed (id: <code>ga:adPlacementDomain)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adplacementdomain</cref>
        /// </see>
        public static readonly AnalyticsDimension AdPlacementDomain = AnalyticsDimension.Register("ga:adPlacementDomain", "Adwords");

        /// <summary>
        /// Gets the URLs where your ads on the content network were placed (id: <code>ga:adPlacementUrl)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adplacementurl</cref>
        /// </see>
        public static readonly AnalyticsDimension AdPlacementUrl = AnalyticsDimension.Register("ga:adPlacementUrl", "Adwords");

        /// <summary>
        /// Your AdWords ad formats (Text, Image, Flash, Video, etc.) (id: <code>ga:adFormat)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adformat</cref>
        /// </see>
        public static readonly AnalyticsDimension AdFormat = AnalyticsDimension.Register("ga:adFormat", "Adwords");

        /// <summary>
        /// Gets how your AdWords ads were targeted (keyword, placement, and vertical targeting, etc.) (id: <code>ga:adTargetingType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adtargetingtype</cref>
        /// </see>
        public static readonly AnalyticsDimension AdTargetingType = AnalyticsDimension.Register("ga:adTargetingType", "Adwords");

        /// <summary>
        /// Gets how you manage your ads on the content network. Values are Automatic placements or Managed placements (id: <code>ga:adTargetingOption)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adtargetingoption</cref>
        /// </see>
        public static readonly AnalyticsDimension AdTargetingOption = AnalyticsDimension.Register("ga:adTargetingOption", "Adwords");

        /// <summary>
        /// Gets the URLs your AdWords ads displayed (id: <code>ga:adDisplayUrl)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_addisplayurl</cref>
        /// </see>
        public static readonly AnalyticsDimension AdDisplayUrl = AnalyticsDimension.Register("ga:adDisplayUrl", "Adwords");

        /// <summary>
        /// Gets the URLs to which your AdWords ads referred traffic (id: <code>ga:adDestinationUrl)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_addestinationurl</cref>
        /// </see>
        public static readonly AnalyticsDimension AdDestinationUrl = AnalyticsDimension.Register("ga:adDestinationUrl", "Adwords");

        /// <summary>
        /// A string. Corresponds to AdWords API AccountInfo.customerId (id: <code>ga:adwordsCustomerID)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adwordscustomerid</cref>
        /// </see>
        public static readonly AnalyticsDimension AdwordsCustomerID = AnalyticsDimension.Register("ga:adwordsCustomerID", "Adwords");

        /// <summary>
        /// A string. Corresponds to AdWords API Campaign.id (id: <code>ga:adwordsCampaignID)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adwordscampaignid</cref>
        /// </see>
        public static readonly AnalyticsDimension AdwordsCampaignID = AnalyticsDimension.Register("ga:adwordsCampaignID", "Adwords");

        /// <summary>
        /// A string. Corresponds to AdWords API AdGroup.id (id: <code>ga:adwordsAdGroupID)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adwordsadgroupid</cref>
        /// </see>
        public static readonly AnalyticsDimension AdwordsAdGroupID = AnalyticsDimension.Register("ga:adwordsAdGroupID", "Adwords");

        /// <summary>
        /// A string. Corresponds to AdWords API Ad.id (id: <code>ga:adwordsCreativeID)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adwordscreativeid</cref>
        /// </see>
        public static readonly AnalyticsDimension AdwordsCreativeID = AnalyticsDimension.Register("ga:adwordsCreativeID", "Adwords");

        /// <summary>
        /// A string corresponding to the AdWords API Criterion.id. The geographical targeting Criteria IDs can be found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid (id: <code>ga:adwordsCriteriaID)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adwordscriteriaid</cref>
        /// </see>
        public static readonly AnalyticsDimension AdwordsCriteriaID = AnalyticsDimension.Register("ga:adwordsCriteriaID", "Adwords");

        /// <summary>
        /// Gets the number of words in the search query (id: <code>ga:adQueryWordCount)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adquerywordcount</cref>
        /// </see>
        public static readonly AnalyticsDimension AdQueryWordCount = AnalyticsDimension.Register("ga:adQueryWordCount", "Adwords");

        /// <summary>
        /// 'Yes' or 'No' - Indicates whether the ad is an AdWords TrueView video ad (id: <code>ga:isTrueViewVideoAd)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_istrueviewvideoad</cref>
        /// </see>
        public static readonly AnalyticsDimension IsTrueViewVideoAd = AnalyticsDimension.Register("ga:isTrueViewVideoAd", "Adwords");

        #endregion

        #region Goal Conversions

        /// <summary>
        /// Gets the page path or screen name that matched any destination type goal completion (id: <code>ga:goalCompletionLocation)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalcompletionlocation</cref>
        /// </see>
        public static readonly AnalyticsDimension GoalCompletionLocation = AnalyticsDimension.Register("ga:goalCompletionLocation", "Goal Conversions");

        /// <summary>
        /// Gets the page path or screen name that matched any destination type goal, one step prior to the goal completion location (id: <code>ga:goalPreviousStep1)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalpreviousstep1</cref>
        /// </see>
        public static readonly AnalyticsDimension GoalPreviousStep1 = AnalyticsDimension.Register("ga:goalPreviousStep1", "Goal Conversions");

        /// <summary>
        /// Gets the page path or screen name that matched any destination type goal, two steps prior to the goal completion location (id: <code>ga:goalPreviousStep2)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalpreviousstep2</cref>
        /// </see>
        public static readonly AnalyticsDimension GoalPreviousStep2 = AnalyticsDimension.Register("ga:goalPreviousStep2", "Goal Conversions");

        /// <summary>
        /// Gets the page path or screen name that matched any destination type goal, three steps prior to the goal completion location (id: <code>ga:goalPreviousStep3)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalpreviousstep3</cref>
        /// </see>
        public static readonly AnalyticsDimension GoalPreviousStep3 = AnalyticsDimension.Register("ga:goalPreviousStep3", "Goal Conversions");

        #endregion

        #region Platform or Device

        /// <summary>
        /// Gets the names of browsers used by users to your website. For example, Internet Explorer or Firefox (id: <code>ga:browser)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_browser</cref>
        /// </see>
        public static readonly AnalyticsDimension Browser = AnalyticsDimension.Register("ga:browser", "Platform or Device");

        /// <summary>
        /// Gets the browser versions used by users to your website. For example, 2.0.0.14 (id: <code>ga:browserVersion)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_browserversion</cref>
        /// </see>
        public static readonly AnalyticsDimension BrowserVersion = AnalyticsDimension.Register("ga:browserVersion", "Platform or Device");

        /// <summary>
        /// Gets the operating system used by your users. For example, Windows, Linux , Macintosh, iPhone, iPod (id: <code>ga:operatingSystem)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_operatingsystem</cref>
        /// </see>
        public static readonly AnalyticsDimension OperatingSystem = AnalyticsDimension.Register("ga:operatingSystem", "Platform or Device");

        /// <summary>
        /// Gets the version of the operating system used by your users, such as XP for Windows or PPC for Macintosh (id: <code>ga:operatingSystemVersion)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_operatingsystemversion</cref>
        /// </see>
        public static readonly AnalyticsDimension OperatingSystemVersion = AnalyticsDimension.Register("ga:operatingSystemVersion", "Platform or Device");

        /// <summary>
        /// This dimension is deprecated and will be removed soon. Please use <code>ga:deviceCategory</code> instead (e.g., <code>ga:deviceCategory</code>==mobile) (id: <code>ga:isMobile)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_ismobile</cref>
        /// </see>
        [Obsolete]
        public static readonly AnalyticsDimension IsMobile = AnalyticsDimension.Register("ga:isMobile", "Platform or Device", true);

        /// <summary>
        /// This dimension is deprecated and will be removed soon. Please use <code>ga:deviceCategory</code> instead (e.g., <code>ga:deviceCategory</code>==tablet) (id: <code>ga:isTablet)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_istablet</cref>
        /// </see>
        [Obsolete]
        public static readonly AnalyticsDimension IsTablet = AnalyticsDimension.Register("ga:isTablet", "Platform or Device", true);

        /// <summary>
        /// Mobile manufacturer or branded name (id: <code>ga:mobileDeviceBranding)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_mobiledevicebranding</cref>
        /// </see>
        public static readonly AnalyticsDimension MobileDeviceBranding = AnalyticsDimension.Register("ga:mobileDeviceBranding", "Platform or Device");

        /// <summary>
        /// Mobile device model (id: <code>ga:mobileDeviceModel)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_mobiledevicemodel</cref>
        /// </see>
        public static readonly AnalyticsDimension MobileDeviceModel = AnalyticsDimension.Register("ga:mobileDeviceModel", "Platform or Device");

        /// <summary>
        /// Selector used on the mobile device (e.g.: touchscreen, joystick, clickwheel, stylus) (id: <code>ga:mobileInputSelector)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_mobileinputselector</cref>
        /// </see>
        public static readonly AnalyticsDimension MobileInputSelector = AnalyticsDimension.Register("ga:mobileInputSelector", "Platform or Device");

        /// <summary>
        /// Gets the branding, model, and marketing name used to identify the mobile device (id: <code>ga:mobileDeviceInfo)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_mobiledeviceinfo</cref>
        /// </see>
        public static readonly AnalyticsDimension MobileDeviceInfo = AnalyticsDimension.Register("ga:mobileDeviceInfo", "Platform or Device");

        /// <summary>
        /// Gets the marketing name used for the mobile device (id: <code>ga:mobileDeviceMarketingName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_mobiledevicemarketingname</cref>
        /// </see>
        public static readonly AnalyticsDimension MobileDeviceMarketingName = AnalyticsDimension.Register("ga:mobileDeviceMarketingName", "Platform or Device");

        /// <summary>
        /// Gets the type of device: desktop, tablet, or mobile (id: <code>ga:deviceCategory)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_devicecategory</cref>
        /// </see>
        public static readonly AnalyticsDimension DeviceCategory = AnalyticsDimension.Register("ga:deviceCategory", "Platform or Device");

        /// <summary>
        /// Gets the data source of a hit. By default, hits sent from ga.js and analytics.js are reported as "web". Hits sent from the mobile SDKs are reported as "app". These values can be overridden in the Measurement Protocol (id: <code>ga:dataSource)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_datasource</cref>
        /// </see>
        public static readonly AnalyticsDimension DataSource = AnalyticsDimension.Register("ga:dataSource", "Platform or Device");

        #endregion

        #region Geo Network

        /// <summary>
        /// Gets the continents of users, derived from IP addresses or Geographical IDs (id: <code>ga:continent)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_continent</cref>
        /// </see>
        public static readonly AnalyticsDimension Continent = AnalyticsDimension.Register("ga:continent", "Geo Network");

        /// <summary>
        /// Gets the sub-continent of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe (id: <code>ga:subContinent)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_subcontinent</cref>
        /// </see>
        public static readonly AnalyticsDimension SubContinent = AnalyticsDimension.Register("ga:subContinent", "Geo Network");

        /// <summary>
        /// Gets the country of users, derived from IP addresses or Geographical IDs (id: <code>ga:country)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_country</cref>
        /// </see>
        public static readonly AnalyticsDimension Country = AnalyticsDimension.Register("ga:country", "Geo Network");

        /// <summary>
        /// Gets the region of users, derived from IP addresses or Geographical IDs. In the U.S., a region is a state, such as New York (id: <code>ga:region)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_region</cref>
        /// </see>
        public static readonly AnalyticsDimension Region = AnalyticsDimension.Register("ga:region", "Geo Network");

        /// <summary>
        /// Gets the Designated Market Area (DMA) from where traffic arrived (id: <code>ga:metro)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_metro</cref>
        /// </see>
        public static readonly AnalyticsDimension Metro = AnalyticsDimension.Register("ga:metro", "Geo Network");

        /// <summary>
        /// Gets the cities of users, derived from IP addresses or Geographical IDs (id: <code>ga:city)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_city</cref>
        /// </see>
        public static readonly AnalyticsDimension City = AnalyticsDimension.Register("ga:city", "Geo Network");

        /// <summary>
        /// Gets the approximate latitude of the user's city. Derived from IP addresses or Geographical IDs. Locations north of the equator are represented by positive values and locations south of the equator by negative values (id: <code>ga:latitude)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_latitude</cref>
        /// </see>
        public static readonly AnalyticsDimension Latitude = AnalyticsDimension.Register("ga:latitude", "Geo Network");

        /// <summary>
        /// Gets the approximate longitude of the user's city. Derived from IP addresses or Geographical IDs. Locations east of the meridian are represented by positive values and locations west of the meridian by negative values (id: <code>ga:longitude)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_longitude</cref>
        /// </see>
        public static readonly AnalyticsDimension Longitude = AnalyticsDimension.Register("ga:longitude", "Geo Network");

        /// <summary>
        /// Gets the domain name of the ISPs used by users. This is derived from the domain name registered to the IP address (id: <code>ga:networkDomain)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_networkdomain</cref>
        /// </see>
        public static readonly AnalyticsDimension NetworkDomain = AnalyticsDimension.Register("ga:networkDomain", "Geo Network");

        /// <summary>
        /// Gets the name of service providers used to reach your property. For example, if most users to your website come via the major service providers for cable internet, you will see the names of those cable service providers in this element (id: <code>ga:networkLocation)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_networklocation</cref>
        /// </see>
        public static readonly AnalyticsDimension NetworkLocation = AnalyticsDimension.Register("ga:networkLocation", "Geo Network");

        /// <summary>
        /// Gets the city IDs of users, derived from IP addresses or Geographical IDs. The city IDs are the same as the Criteria IDs found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid (id: <code>ga:cityId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_cityid</cref>
        /// </see>
        public static readonly AnalyticsDimension CityId = AnalyticsDimension.Register("ga:cityId", "Geo Network");

        /// <summary>
        /// Gets the country ISO code of users, derived from IP addresses or Geographical IDs. Values are given as an ISO-3166-1 alpha-2 code (id: <code>ga:countryIsoCode)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_countryisocode</cref>
        /// </see>
        public static readonly AnalyticsDimension CountryIsoCode = AnalyticsDimension.Register("ga:countryIsoCode", "Geo Network");

        /// <summary>
        /// Gets the region ID of users, derived from IP addresses or Geographical IDs. In the U.S., a region is a state, such as New York. The region IDs are the same as the Criteria IDs found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid (id: <code>ga:regionId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_regionid</cref>
        /// </see>
        public static readonly AnalyticsDimension RegionId = AnalyticsDimension.Register("ga:regionId", "Geo Network");

        /// <summary>
        /// Gets the region ISO code of users, derived from IP addresses or Geographical IDs. Values are given as an ISO-3166-2 code (id: <code>ga:regionIsoCode)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_regionisocode</cref>
        /// </see>
        public static readonly AnalyticsDimension RegionIsoCode = AnalyticsDimension.Register("ga:regionIsoCode", "Geo Network");

        /// <summary>
        /// Gets the sub-continent code of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe. Values are given as a UN M.49 code (id: <code>ga:subContinentCode)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_subcontinentcode</cref>
        /// </see>
        public static readonly AnalyticsDimension SubContinentCode = AnalyticsDimension.Register("ga:subContinentCode", "Geo Network");

        #endregion

        #region System

        /// <summary>
        /// Gets the versions of Flash supported by users' browsers, including minor versions (id: <code>ga:flashVersion)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=system&amp;jump=ga_flashversion</cref>
        /// </see>
        public static readonly AnalyticsDimension FlashVersion = AnalyticsDimension.Register("ga:flashVersion", "System");

        /// <summary>
        /// Indicates Java support for users' browsers. The possible values are Yes or No where the first letter must be capitalized (id: <code>ga:javaEnabled)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=system&amp;jump=ga_javaenabled</cref>
        /// </see>
        public static readonly AnalyticsDimension JavaEnabled = AnalyticsDimension.Register("ga:javaEnabled", "System");

        /// <summary>
        /// Gets the language provided by the HTTP Request for the browser. Values are given as an ISO-639 code (e.g. en-gb for British English) (id: <code>ga:language)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=system&amp;jump=ga_language</cref>
        /// </see>
        public static readonly AnalyticsDimension Language = AnalyticsDimension.Register("ga:language", "System");

        /// <summary>
        /// Gets the color depth of users' monitors, as retrieved from the DOM of the user's browser. For example 4-bit, 8-bit, 24-bit, or undefined-bit (id: <code>ga:screenColors)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=system&amp;jump=ga_screencolors</cref>
        /// </see>
        public static readonly AnalyticsDimension ScreenColors = AnalyticsDimension.Register("ga:screenColors", "System");

        /// <summary>
        /// Source property display name of roll-up properties. This is valid only for roll-up properties (id: <code>ga:sourcePropertyDisplayName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=system&amp;jump=ga_sourcepropertydisplayname</cref>
        /// </see>
        public static readonly AnalyticsDimension SourcePropertyDisplayName = AnalyticsDimension.Register("ga:sourcePropertyDisplayName", "System");

        /// <summary>
        /// Source property tracking ID of roll-up properties. This is valid only for roll-up properties (id: <code>ga:sourcePropertyTrackingId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=system&amp;jump=ga_sourcepropertytrackingid</cref>
        /// </see>
        public static readonly AnalyticsDimension SourcePropertyTrackingId = AnalyticsDimension.Register("ga:sourcePropertyTrackingId", "System");

        /// <summary>
        /// Gets the screen resolution of users' screens. For example: 1024x738 (id: <code>ga:screenResolution)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=system&amp;jump=ga_screenresolution</cref>
        /// </see>
        public static readonly AnalyticsDimension ScreenResolution = AnalyticsDimension.Register("ga:screenResolution", "System");

        #endregion

        #region Social Activities

        /// <summary>
        /// For a social data hub activity, this value represents the URL of the social activity (e.g. the Google+ post URL, the blog comment URL, etc.) (id: <code>ga:socialActivityEndorsingUrl)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivityendorsingurl</cref>
        /// </see>
        public static readonly AnalyticsDimension SocialActivityEndorsingUrl = AnalyticsDimension.Register("ga:socialActivityEndorsingUrl", "Social Activities");

        /// <summary>
        /// For a social data hub activity, this value represents the title of the social activity posted by the social network user (id: <code>ga:socialActivityDisplayName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivitydisplayname</cref>
        /// </see>
        public static readonly AnalyticsDimension SocialActivityDisplayName = AnalyticsDimension.Register("ga:socialActivityDisplayName", "Social Activities");

        /// <summary>
        /// For a social data hub activity, this value represents the content of the social activity posted by the social network user (e.g. The message content of a Google+ post) (id: <code>ga:socialActivityPost)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivitypost</cref>
        /// </see>
        public static readonly AnalyticsDimension SocialActivityPost = AnalyticsDimension.Register("ga:socialActivityPost", "Social Activities");

        /// <summary>
        /// For a social data hub activity, this value represents when the social activity occurred on the social network (id: <code>ga:socialActivityTimestamp)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivitytimestamp</cref>
        /// </see>
        public static readonly AnalyticsDimension SocialActivityTimestamp = AnalyticsDimension.Register("ga:socialActivityTimestamp", "Social Activities");

        /// <summary>
        /// For a social data hub activity, this value represents the social network handle (e.g. name or ID) of the user who initiated the social activity (id: <code>ga:socialActivityUserHandle)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivityuserhandle</cref>
        /// </see>
        public static readonly AnalyticsDimension SocialActivityUserHandle = AnalyticsDimension.Register("ga:socialActivityUserHandle", "Social Activities");

        /// <summary>
        /// For a social data hub activity, this value represents the URL of the photo associated with the user's social network profile (id: <code>ga:socialActivityUserPhotoUrl)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivityuserphotourl</cref>
        /// </see>
        public static readonly AnalyticsDimension SocialActivityUserPhotoUrl = AnalyticsDimension.Register("ga:socialActivityUserPhotoUrl", "Social Activities");

        /// <summary>
        /// For a social data hub activity, this value represents the URL of the associated user's social network profile (id: <code>ga:socialActivityUserProfileUrl)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivityuserprofileurl</cref>
        /// </see>
        public static readonly AnalyticsDimension SocialActivityUserProfileUrl = AnalyticsDimension.Register("ga:socialActivityUserProfileUrl", "Social Activities");

        /// <summary>
        /// For a social data hub activity, this value represents the URL shared by the associated social network user (id: <code>ga:socialActivityContentUrl)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivitycontenturl</cref>
        /// </see>
        public static readonly AnalyticsDimension SocialActivityContentUrl = AnalyticsDimension.Register("ga:socialActivityContentUrl", "Social Activities");

        /// <summary>
        /// For a social data hub activity, this is a comma-separated set of tags associated with the social activity (id: <code>ga:socialActivityTagsSummary)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivitytagssummary</cref>
        /// </see>
        public static readonly AnalyticsDimension SocialActivityTagsSummary = AnalyticsDimension.Register("ga:socialActivityTagsSummary", "Social Activities");

        /// <summary>
        /// For a social data hub activity, this value represents the type of social action associated with the activity (e.g. vote, comment, +1, etc.) (id: <code>ga:socialActivityAction)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivityaction</cref>
        /// </see>
        public static readonly AnalyticsDimension SocialActivityAction = AnalyticsDimension.Register("ga:socialActivityAction", "Social Activities");

        /// <summary>
        /// For a social data hub activity, this value represents the type of social action and the social network where the activity originated (id: <code>ga:socialActivityNetworkAction)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivitynetworkaction</cref>
        /// </see>
        public static readonly AnalyticsDimension SocialActivityNetworkAction = AnalyticsDimension.Register("ga:socialActivityNetworkAction", "Social Activities");

        #endregion

        #region Page Tracking

        /// <summary>
        /// Gets the hostname from which the tracking request was made (id: <code>ga:hostname)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_hostname</cref>
        /// </see>
        public static readonly AnalyticsDimension Hostname = AnalyticsDimension.Register("ga:hostname", "Page Tracking");

        /// <summary>
        /// A page on your website specified by path and/or query parameters. Use in conjunction with hostname to get the full URL of the page (id: <code>ga:pagePath)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pagepath</cref>
        /// </see>
        public static readonly AnalyticsDimension PagePath = AnalyticsDimension.Register("ga:pagePath", "Page Tracking");

        /// <summary>
        /// This dimension rolls up all the page paths in the first hierarchical level in pagePath (id: <code>ga:pagePathLevel1)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pagepathlevel1</cref>
        /// </see>
        public static readonly AnalyticsDimension PagePathLevel1 = AnalyticsDimension.Register("ga:pagePathLevel1", "Page Tracking");

        /// <summary>
        /// This dimension rolls up all the page paths in the second hierarchical level in pagePath (id: <code>ga:pagePathLevel2)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pagepathlevel2</cref>
        /// </see>
        public static readonly AnalyticsDimension PagePathLevel2 = AnalyticsDimension.Register("ga:pagePathLevel2", "Page Tracking");

        /// <summary>
        /// This dimension rolls up all the page paths in the third hierarchical level in pagePath (id: <code>ga:pagePathLevel3)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pagepathlevel3</cref>
        /// </see>
        public static readonly AnalyticsDimension PagePathLevel3 = AnalyticsDimension.Register("ga:pagePathLevel3", "Page Tracking");

        /// <summary>
        /// This dimension rolls up all the page paths into hierarchical levels. Up to 4 pagePath levels maybe specified. All additional levels in the pagePath hierarchy are also rolled up in this dimension (id: <code>ga:pagePathLevel4)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pagepathlevel4</cref>
        /// </see>
        public static readonly AnalyticsDimension PagePathLevel4 = AnalyticsDimension.Register("ga:pagePathLevel4", "Page Tracking");

        /// <summary>
        /// Gets the title of a page. Keep in mind that multiple pages might have the same page title (id: <code>ga:pageTitle)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pagetitle</cref>
        /// </see>
        public static readonly AnalyticsDimension PageTitle = AnalyticsDimension.Register("ga:pageTitle", "Page Tracking");

        /// <summary>
        /// Gets the first page in a user's session, or landing page (id: <code>ga:landingPagePath)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_landingpagepath</cref>
        /// </see>
        public static readonly AnalyticsDimension LandingPagePath = AnalyticsDimension.Register("ga:landingPagePath", "Page Tracking");

        /// <summary>
        /// Gets the second page in a user's session (id: <code>ga:secondPagePath)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_secondpagepath</cref>
        /// </see>
        public static readonly AnalyticsDimension SecondPagePath = AnalyticsDimension.Register("ga:secondPagePath", "Page Tracking");

        /// <summary>
        /// Gets the last page in a user's session, or exit page (id: <code>ga:exitPagePath)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_exitpagepath</cref>
        /// </see>
        public static readonly AnalyticsDimension ExitPagePath = AnalyticsDimension.Register("ga:exitPagePath", "Page Tracking");

        /// <summary>
        /// A page that was visited before another page on the same property. Typically used with the pagePath dimension (id: <code>ga:previousPagePath)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_previouspagepath</cref>
        /// </see>
        public static readonly AnalyticsDimension PreviousPagePath = AnalyticsDimension.Register("ga:previousPagePath", "Page Tracking");

        /// <summary>
        /// This dimension is deprecated and will be removed soon. Please use <code>ga:pagePath</code> instead (id: <code>ga:nextPagePath)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_nextpagepath</cref>
        /// </see>
        [Obsolete]
        public static readonly AnalyticsDimension NextPagePath = AnalyticsDimension.Register("ga:nextPagePath", "Page Tracking", true);

        /// <summary>
        /// Gets the number of pages visited by users during a session. The value is a histogram that counts pageviews across a range of possible values. In this calculation, all sessions will have at least one pageview, and some percentage of sessions will have more (id: <code>ga:pageDepth)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pagedepth</cref>
        /// </see>
        public static readonly AnalyticsDimension PageDepth = AnalyticsDimension.Register("ga:pageDepth", "Page Tracking");

        #endregion

        #region Content Grouping

        /// <summary>
        /// Content group of a user's landing page (id: <code>ga:landingContentGroupXX)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=content_grouping&amp;jump=ga_landingcontentgroupxx</cref>
        /// </see>
        public static readonly AnalyticsDimension LandingContentGroupXX = AnalyticsDimension.Register("ga:landingContentGroupXX", "Content Grouping");

        /// <summary>
        /// Refers to content group that was visited before another content group (id: <code>ga:previousContentGroupXX)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=content_grouping&amp;jump=ga_previouscontentgroupxx</cref>
        /// </see>
        public static readonly AnalyticsDimension PreviousContentGroupXX = AnalyticsDimension.Register("ga:previousContentGroupXX", "Content Grouping");

        /// <summary>
        /// Content group on a property. A content group is a collection of content providing a logical structure that can be determined by tracking code or page title/url regex match, or predefined rules (id: <code>ga:contentGroupXX)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=content_grouping&amp;jump=ga_contentgroupxx</cref>
        /// </see>
        public static readonly AnalyticsDimension ContentGroupXX = AnalyticsDimension.Register("ga:contentGroupXX", "Content Grouping");

        /// <summary>
        /// This dimension is deprecated and will be removed soon. Please use <code>ga:contentGroupXX</code> instead (id: <code>ga:nextContentGroupXX)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=content_grouping&amp;jump=ga_nextcontentgroupxx</cref>
        /// </see>
        [Obsolete]
        public static readonly AnalyticsDimension NextContentGroupXX = AnalyticsDimension.Register("ga:nextContentGroupXX", "Content Grouping", true);

        #endregion

        #region Internal Search

        /// <summary>
        /// A boolean to distinguish whether internal search was used in a session. Values are Visits With Site Search and Visits Without Site Search (id: <code>ga:searchUsed)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchused</cref>
        /// </see>
        public static readonly AnalyticsDimension SearchUsed = AnalyticsDimension.Register("ga:searchUsed", "Internal Search");

        /// <summary>
        /// Search terms used by users within your property (id: <code>ga:searchKeyword)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchkeyword</cref>
        /// </see>
        public static readonly AnalyticsDimension SearchKeyword = AnalyticsDimension.Register("ga:searchKeyword", "Internal Search");

        /// <summary>
        /// Subsequent keyword search terms or strings entered by users after a given initial string search (id: <code>ga:searchKeywordRefinement)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchkeywordrefinement</cref>
        /// </see>
        public static readonly AnalyticsDimension SearchKeywordRefinement = AnalyticsDimension.Register("ga:searchKeywordRefinement", "Internal Search");

        /// <summary>
        /// Gets the categories used for the internal search if you have this enabled for your profile. For example, you might have product categories such as electronics, furniture, or clothing (id: <code>ga:searchCategory)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchcategory</cref>
        /// </see>
        public static readonly AnalyticsDimension SearchCategory = AnalyticsDimension.Register("ga:searchCategory", "Internal Search");

        /// <summary>
        /// A page where the user initiated an internal search (id: <code>ga:searchStartPage)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchstartpage</cref>
        /// </see>
        public static readonly AnalyticsDimension SearchStartPage = AnalyticsDimension.Register("ga:searchStartPage", "Internal Search");

        /// <summary>
        /// Gets the page the user immediately visited after performing an internal search on your site. (Usually the search results page) (id: <code>ga:searchDestinationPage)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchdestinationpage</cref>
        /// </see>
        public static readonly AnalyticsDimension SearchDestinationPage = AnalyticsDimension.Register("ga:searchDestinationPage", "Internal Search");

        /// <summary>
        /// A page that the user visited after performing an internal search on your site (id: <code>ga:searchAfterDestinationPage)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchafterdestinationpage</cref>
        /// </see>
        public static readonly AnalyticsDimension SearchAfterDestinationPage = AnalyticsDimension.Register("ga:searchAfterDestinationPage", "Internal Search");

        #endregion

        #region App Tracking

        /// <summary>
        /// ID of the installer (e.g., Google Play Store) from which the app was downloaded. By default, the app installer id is set based on the PackageManager#getInstallerPackageName method (id: <code>ga:appInstallerId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_appinstallerid</cref>
        /// </see>
        public static readonly AnalyticsDimension AppInstallerId = AnalyticsDimension.Register("ga:appInstallerId", "App Tracking");

        /// <summary>
        /// Gets the version of the application (id: <code>ga:appVersion)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_appversion</cref>
        /// </see>
        public static readonly AnalyticsDimension AppVersion = AnalyticsDimension.Register("ga:appVersion", "App Tracking");

        /// <summary>
        /// Gets the name of the application (id: <code>ga:appName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_appname</cref>
        /// </see>
        public static readonly AnalyticsDimension AppName = AnalyticsDimension.Register("ga:appName", "App Tracking");

        /// <summary>
        /// Gets the ID of the application (id: <code>ga:appId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_appid</cref>
        /// </see>
        public static readonly AnalyticsDimension AppId = AnalyticsDimension.Register("ga:appId", "App Tracking");

        /// <summary>
        /// Gets the name of the screen (id: <code>ga:screenName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_screenname</cref>
        /// </see>
        public static readonly AnalyticsDimension ScreenName = AnalyticsDimension.Register("ga:screenName", "App Tracking");

        /// <summary>
        /// Gets the number of screenviews per session reported as a string. Can be useful for historgrams (id: <code>ga:screenDepth)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_screendepth</cref>
        /// </see>
        public static readonly AnalyticsDimension ScreenDepth = AnalyticsDimension.Register("ga:screenDepth", "App Tracking");

        /// <summary>
        /// Gets the name of the first screen viewed (id: <code>ga:landingScreenName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_landingscreenname</cref>
        /// </see>
        public static readonly AnalyticsDimension LandingScreenName = AnalyticsDimension.Register("ga:landingScreenName", "App Tracking");

        /// <summary>
        /// Gets the name of the screen when the user exited the application (id: <code>ga:exitScreenName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_exitscreenname</cref>
        /// </see>
        public static readonly AnalyticsDimension ExitScreenName = AnalyticsDimension.Register("ga:exitScreenName", "App Tracking");

        #endregion

        #region Event Tracking

        /// <summary>
        /// Gets the category of the event (id: <code>ga:eventCategory)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_eventcategory</cref>
        /// </see>
        public static readonly AnalyticsDimension EventCategory = AnalyticsDimension.Register("ga:eventCategory", "Event Tracking");

        /// <summary>
        /// Gets the action of the event (id: <code>ga:eventAction)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_eventaction</cref>
        /// </see>
        public static readonly AnalyticsDimension EventAction = AnalyticsDimension.Register("ga:eventAction", "Event Tracking");

        /// <summary>
        /// Gets the label of the event (id: <code>ga:eventLabel)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_eventlabel</cref>
        /// </see>
        public static readonly AnalyticsDimension EventLabel = AnalyticsDimension.Register("ga:eventLabel", "Event Tracking");

        #endregion

        #region Ecommerce

        /// <summary>
        /// Gets the transaction ID for the shopping cart purchase as supplied by your ecommerce tracking method (id: <code>ga:transactionId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactionid</cref>
        /// </see>
        public static readonly AnalyticsDimension TransactionId = AnalyticsDimension.Register("ga:transactionId", "Ecommerce");

        /// <summary>
        /// Typically used to designate a supplying company or brick and mortar location; product affiliation (id: <code>ga:affiliation)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_affiliation</cref>
        /// </see>
        public static readonly AnalyticsDimension Affiliation = AnalyticsDimension.Register("ga:affiliation", "Ecommerce");

        /// <summary>
        /// Gets the number of sessions between users' purchases and the related campaigns that lead to the purchases (id: <code>ga:sessionsToTransaction)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_sessionstotransaction</cref>
        /// </see>
        public static readonly AnalyticsDimension SessionsToTransaction = AnalyticsDimension.Register("ga:sessionsToTransaction", "Ecommerce");

        /// <summary>
        /// Gets the number of sessions between users' purchases and the related campaigns that lead to the purchases (id: <code>ga:visitsToTransaction)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_visitstotransaction</cref>
        /// </see>
        [Obsolete("Use ga:sessionsToTransaction instead.")]
        public static readonly AnalyticsDimension VisitsToTransaction = AnalyticsDimension.Register("ga:visitsToTransaction", "Ecommerce", true);

        /// <summary>
        /// Gets the number of days between users' purchases and the related campaigns that lead to the purchases (id: <code>ga:daysToTransaction)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_daystotransaction</cref>
        /// </see>
        public static readonly AnalyticsDimension DaysToTransaction = AnalyticsDimension.Register("ga:daysToTransaction", "Ecommerce");

        /// <summary>
        /// Gets the product sku for purchased items as you have defined them in your ecommerce tracking application (id: <code>ga:productSku)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productsku</cref>
        /// </see>
        public static readonly AnalyticsDimension ProductSku = AnalyticsDimension.Register("ga:productSku", "Ecommerce");

        /// <summary>
        /// Gets the product name for purchased items as supplied by your ecommerce tracking application (id: <code>ga:productName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productname</cref>
        /// </see>
        public static readonly AnalyticsDimension ProductName = AnalyticsDimension.Register("ga:productName", "Ecommerce");

        /// <summary>
        /// Any product variations (size, color) for purchased items as supplied by your ecommerce application. Not compatible with Enhanced Ecommerce (id: <code>ga:productCategory)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productcategory</cref>
        /// </see>
        public static readonly AnalyticsDimension ProductCategory = AnalyticsDimension.Register("ga:productCategory", "Ecommerce");

        /// <summary>
        /// Gets the local currency code of the transaction based on ISO 4217 standard (id: <code>ga:currencyCode)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_currencycode</cref>
        /// </see>
        public static readonly AnalyticsDimension CurrencyCode = AnalyticsDimension.Register("ga:currencyCode", "Ecommerce");

        /// <summary>
        /// User options specified during the checkout process, e.g., FedEx, DHL, UPS for delivery options or Visa, MasterCard, AmEx for payment options. This dimension should be used along with <code>ga:shoppingStage</code> (Enhanced Ecommerce) (id: <code>ga:checkoutOptions)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_checkoutoptions</cref>
        /// </see>
        public static readonly AnalyticsDimension CheckoutOptions = AnalyticsDimension.Register("ga:checkoutOptions", "Ecommerce");

        /// <summary>
        /// Gets the creative content designed for a promotion (Enhanced Ecommerce) (id: <code>ga:internalPromotionCreative)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_internalpromotioncreative</cref>
        /// </see>
        public static readonly AnalyticsDimension InternalPromotionCreative = AnalyticsDimension.Register("ga:internalPromotionCreative", "Ecommerce");

        /// <summary>
        /// Gets the ID of the promotion (Enhanced Ecommerce) (id: <code>ga:internalPromotionId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_internalpromotionid</cref>
        /// </see>
        public static readonly AnalyticsDimension InternalPromotionId = AnalyticsDimension.Register("ga:internalPromotionId", "Ecommerce");

        /// <summary>
        /// Gets the name of the promotion (Enhanced Ecommerce) (id: <code>ga:internalPromotionName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_internalpromotionname</cref>
        /// </see>
        public static readonly AnalyticsDimension InternalPromotionName = AnalyticsDimension.Register("ga:internalPromotionName", "Ecommerce");

        /// <summary>
        /// Gets the position of the promotion on the web page or application screen (Enhanced Ecommerce) (id: <code>ga:internalPromotionPosition)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_internalpromotionposition</cref>
        /// </see>
        public static readonly AnalyticsDimension InternalPromotionPosition = AnalyticsDimension.Register("ga:internalPromotionPosition", "Ecommerce");

        /// <summary>
        /// Code for the order-level coupon (Enhanced Ecommerce) (id: <code>ga:orderCouponCode)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_ordercouponcode</cref>
        /// </see>
        public static readonly AnalyticsDimension OrderCouponCode = AnalyticsDimension.Register("ga:orderCouponCode", "Ecommerce");

        /// <summary>
        /// Gets the brand name under which the product is sold (Enhanced Ecommerce) (id: <code>ga:productBrand)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productbrand</cref>
        /// </see>
        public static readonly AnalyticsDimension ProductBrand = AnalyticsDimension.Register("ga:productBrand", "Ecommerce");

        /// <summary>
        /// Gets the hierarchical category in which the product is classified (Enhanced Ecommerce) (id: <code>ga:productCategoryHierarchy)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productcategoryhierarchy</cref>
        /// </see>
        public static readonly AnalyticsDimension ProductCategoryHierarchy = AnalyticsDimension.Register("ga:productCategoryHierarchy", "Ecommerce");

        /// <summary>
        /// Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce) (id: <code>ga:productCategoryLevelXX)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productcategorylevelxx</cref>
        /// </see>
        public static readonly AnalyticsDimension ProductCategoryLevelXX = AnalyticsDimension.Register("ga:productCategoryLevelXX", "Ecommerce");

        /// <summary>
        /// Code for the product-level coupon (Enhanced Ecommerce) (id: <code>ga:productCouponCode)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productcouponcode</cref>
        /// </see>
        public static readonly AnalyticsDimension ProductCouponCode = AnalyticsDimension.Register("ga:productCouponCode", "Ecommerce");

        /// <summary>
        /// Gets the name of the product list in which the product appears (Enhanced Ecommerce) (id: <code>ga:productListName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productlistname</cref>
        /// </see>
        public static readonly AnalyticsDimension ProductListName = AnalyticsDimension.Register("ga:productListName", "Ecommerce");

        /// <summary>
        /// Gets the position of the product in the product list (Enhanced Ecommerce) (id: <code>ga:productListPosition)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productlistposition</cref>
        /// </see>
        public static readonly AnalyticsDimension ProductListPosition = AnalyticsDimension.Register("ga:productListPosition", "Ecommerce");

        /// <summary>
        /// Gets the specific variation of a product, e.g., XS, S, M, L for size or Red, Blue, Green, Black for color (Enhanced Ecommerce) (id: <code>ga:productVariant)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productvariant</cref>
        /// </see>
        public static readonly AnalyticsDimension ProductVariant = AnalyticsDimension.Register("ga:productVariant", "Ecommerce");

        /// <summary>
        /// Various stages of the shopping experience that users completed in a session, e.g., PRODUCT_VIEW, ADD_TO_CART, CHECKOUT, etc. (Enhanced Ecommerce) (id: <code>ga:shoppingStage)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_shoppingstage</cref>
        /// </see>
        public static readonly AnalyticsDimension ShoppingStage = AnalyticsDimension.Register("ga:shoppingStage", "Ecommerce");

        #endregion

        #region Social Interactions

        /// <summary>
        /// For social interactions, a value representing the social network being tracked (id: <code>ga:socialInteractionNetwork)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_interactions&amp;jump=ga_socialinteractionnetwork</cref>
        /// </see>
        public static readonly AnalyticsDimension SocialInteractionNetwork = AnalyticsDimension.Register("ga:socialInteractionNetwork", "Social Interactions");

        /// <summary>
        /// For social interactions, a value representing the social action being tracked (e.g. +1, bookmark) (id: <code>ga:socialInteractionAction)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_interactions&amp;jump=ga_socialinteractionaction</cref>
        /// </see>
        public static readonly AnalyticsDimension SocialInteractionAction = AnalyticsDimension.Register("ga:socialInteractionAction", "Social Interactions");

        /// <summary>
        /// For social interactions, a value representing the concatenation of the socialInteractionNetwork and socialInteractionAction action being tracked at this hit level (e.g. Google: +1) (id: <code>ga:socialInteractionNetworkAction)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_interactions&amp;jump=ga_socialinteractionnetworkaction</cref>
        /// </see>
        public static readonly AnalyticsDimension SocialInteractionNetworkAction = AnalyticsDimension.Register("ga:socialInteractionNetworkAction", "Social Interactions");

        /// <summary>
        /// For social interactions, a value representing the URL (or resource) which receives the social network action (id: <code>ga:socialInteractionTarget)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_interactions&amp;jump=ga_socialinteractiontarget</cref>
        /// </see>
        public static readonly AnalyticsDimension SocialInteractionTarget = AnalyticsDimension.Register("ga:socialInteractionTarget", "Social Interactions");

        /// <summary>
        /// Engagement type. Possible values are "Socially Engaged" or "Not Socially Engaged" (id: <code>ga:socialEngagementType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_interactions&amp;jump=ga_socialengagementtype</cref>
        /// </see>
        public static readonly AnalyticsDimension SocialEngagementType = AnalyticsDimension.Register("ga:socialEngagementType", "Social Interactions");

        #endregion

        #region User Timings

        /// <summary>
        /// A string for categorizing all user timing variables into logical groups for easier reporting purposes (id: <code>ga:userTimingCategory)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user_timings&amp;jump=ga_usertimingcategory</cref>
        /// </see>
        public static readonly AnalyticsDimension UserTimingCategory = AnalyticsDimension.Register("ga:userTimingCategory", "User Timings");

        /// <summary>
        /// Gets the name of the resource's action being tracked (id: <code>ga:userTimingLabel)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user_timings&amp;jump=ga_usertiminglabel</cref>
        /// </see>
        public static readonly AnalyticsDimension UserTimingLabel = AnalyticsDimension.Register("ga:userTimingLabel", "User Timings");

        /// <summary>
        /// A value that can be used to add flexibility in visualizing user timings in the reports (id: <code>ga:userTimingVariable)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user_timings&amp;jump=ga_usertimingvariable</cref>
        /// </see>
        public static readonly AnalyticsDimension UserTimingVariable = AnalyticsDimension.Register("ga:userTimingVariable", "User Timings");

        #endregion

        #region Exceptions

        /// <summary>
        /// Gets the description for the exception (id: <code>ga:exceptionDescription)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=exceptions&amp;jump=ga_exceptiondescription</cref>
        /// </see>
        public static readonly AnalyticsDimension ExceptionDescription = AnalyticsDimension.Register("ga:exceptionDescription", "Exceptions");

        #endregion

        #region Content Experiments

        /// <summary>
        /// Gets the user-scoped id of the content experiment that the user was exposed to when the metrics were reported (id: <code>ga:experimentId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=content_experiments&amp;jump=ga_experimentid</cref>
        /// </see>
        public static readonly AnalyticsDimension ExperimentId = AnalyticsDimension.Register("ga:experimentId", "Content Experiments");

        /// <summary>
        /// Gets the user-scoped id of the particular variation that the user was exposed to during a content experiment (id: <code>ga:experimentVariant)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=content_experiments&amp;jump=ga_experimentvariant</cref>
        /// </see>
        public static readonly AnalyticsDimension ExperimentVariant = AnalyticsDimension.Register("ga:experimentVariant", "Content Experiments");

        #endregion

        #region Custom Variables or Columns

        /// <summary>
        /// Gets the name of the requested custom dimension, where XX refers the number/index of the custom dimension (id: <code>ga:dimensionXX)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=custom_variables_or_columns&amp;jump=ga_dimensionxx</cref>
        /// </see>
        public static readonly AnalyticsDimension DimensionXX = AnalyticsDimension.Register("ga:dimensionXX", "Custom Variables or Columns");

        /// <summary>
        /// Gets the name for the requested custom variable (id: <code>ga:customVarNameXX)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=custom_variables_or_columns&amp;jump=ga_customvarnamexx</cref>
        /// </see>
        public static readonly AnalyticsDimension CustomVarNameXX = AnalyticsDimension.Register("ga:customVarNameXX", "Custom Variables or Columns");

        /// <summary>
        /// Gets the value for the requested custom variable (id: <code>ga:customVarValueXX)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=custom_variables_or_columns&amp;jump=ga_customvarvaluexx</cref>
        /// </see>
        public static readonly AnalyticsDimension CustomVarValueXX = AnalyticsDimension.Register("ga:customVarValueXX", "Custom Variables or Columns");

        #endregion

        #region Time

        /// <summary>
        /// Gets the date of the session formatted as YYYYMMDD (id: <code>ga:date)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_date</cref>
        /// </see>
        public static readonly AnalyticsDimension Date = AnalyticsDimension.Register("ga:date", "Time");

        /// <summary>
        /// Gets the year of the session. A four-digit year from 2005 to the current year (id: <code>ga:year)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_year</cref>
        /// </see>
        public static readonly AnalyticsDimension Year = AnalyticsDimension.Register("ga:year", "Time");

        /// <summary>
        /// Gets the month of the session. A two digit integer from 01 to 12 (id: <code>ga:month)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_month</cref>
        /// </see>
        public static readonly AnalyticsDimension Month = AnalyticsDimension.Register("ga:month", "Time");

        /// <summary>
        /// Gets the week of the session. A two-digit number from 01 to 53. Each week starts on Sunday (id: <code>ga:week)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_week</cref>
        /// </see>
        public static readonly AnalyticsDimension Week = AnalyticsDimension.Register("ga:week", "Time");

        /// <summary>
        /// Gets the day of the month. A two-digit number from 01 to 31 (id: <code>ga:day)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_day</cref>
        /// </see>
        public static readonly AnalyticsDimension Day = AnalyticsDimension.Register("ga:day", "Time");

        /// <summary>
        /// A two-digit hour of the day ranging from 00-23 in the timezone configured for the account. This value is also corrected for daylight savings time, adhering to all local rules for daylight savings time. If your timezone follows daylight savings time, there will be an apparent bump in the number of sessions during the change-over hour (e.g. between 1:00 and 2:00) for the day per year when that hour repeats. A corresponding hour with zero sessions will occur at the opposite changeover. (Google Analytics does not track user time more precisely than hours.) (id: <code>ga:hour)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_hour</cref>
        /// </see>
        public static readonly AnalyticsDimension Hour = AnalyticsDimension.Register("ga:hour", "Time");

        /// <summary>
        /// Returns the minute in the hour. The possible values are between 00 and 59 (id: <code>ga:minute)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_minute</cref>
        /// </see>
        public static readonly AnalyticsDimension Minute = AnalyticsDimension.Register("ga:minute", "Time");

        /// <summary>
        /// Index for each month in the specified date range. Index for the first month in the date range is 0, 1 for the second month, and so on. The index corresponds to month entries (id: <code>ga:nthMonth)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_nthmonth</cref>
        /// </see>
        public static readonly AnalyticsDimension NthMonth = AnalyticsDimension.Register("ga:nthMonth", "Time");

        /// <summary>
        /// Index for each week in the specified date range. Index for the first week in the date range is 0, 1 for the second week, and so on. The index corresponds to week entries (id: <code>ga:nthWeek)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_nthweek</cref>
        /// </see>
        public static readonly AnalyticsDimension NthWeek = AnalyticsDimension.Register("ga:nthWeek", "Time");

        /// <summary>
        /// Index for each day in the specified date range. Index for the first day (i.e., start-date) in the date range is 0, 1 for the second day, and so on (id: <code>ga:nthDay)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_nthday</cref>
        /// </see>
        public static readonly AnalyticsDimension NthDay = AnalyticsDimension.Register("ga:nthDay", "Time");

        /// <summary>
        /// Index for each minute in the specified date range. Index for the first minute of first day (i.e., start-date) in the date range is 0, 1 for the next minute, and so on (id: <code>ga:nthMinute)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_nthminute</cref>
        /// </see>
        public static readonly AnalyticsDimension NthMinute = AnalyticsDimension.Register("ga:nthMinute", "Time");

        /// <summary>
        /// Gets the day of the week. A one-digit number from 0 (Sunday) to 6 (Saturday) (id: <code>ga:dayOfWeek)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_dayofweek</cref>
        /// </see>
        public static readonly AnalyticsDimension DayOfWeek = AnalyticsDimension.Register("ga:dayOfWeek", "Time");

        /// <summary>
        /// Gets the name of the day of the week (in English) (id: <code>ga:dayOfWeekName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_dayofweekname</cref>
        /// </see>
        public static readonly AnalyticsDimension DayOfWeekName = AnalyticsDimension.Register("ga:dayOfWeekName", "Time");

        /// <summary>
        /// Combined values of <code>ga:date</code> and <code>ga:hour</code> (id: <code>ga:dateHour)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_datehour</cref>
        /// </see>
        public static readonly AnalyticsDimension DateHour = AnalyticsDimension.Register("ga:dateHour", "Time");

        /// <summary>
        /// Combined values of <code>ga:year</code> and <code>ga:month</code> (id: <code>ga:yearMonth)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_yearmonth</cref>
        /// </see>
        public static readonly AnalyticsDimension YearMonth = AnalyticsDimension.Register("ga:yearMonth", "Time");

        /// <summary>
        /// Combined values of <code>ga:year</code> and <code>ga:week</code> (id: <code>ga:yearWeek)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_yearweek</cref>
        /// </see>
        public static readonly AnalyticsDimension YearWeek = AnalyticsDimension.Register("ga:yearWeek", "Time");

        /// <summary>
        /// Gets the ISO week number, where each week starts with a Monday. Details: http://en.wikipedia.org/wiki/ISO_week_date. <code>ga:isoWeek</code> should only be used with <code>ga:isoYear</code> since <code>ga:year</code> represents gregorian calendar (id: <code>ga:isoWeek)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_isoweek</cref>
        /// </see>
        public static readonly AnalyticsDimension IsoWeek = AnalyticsDimension.Register("ga:isoWeek", "Time");

        /// <summary>
        /// Gets the ISO year of the session. Details: http://en.wikipedia.org/wiki/ISO_week_date. <code>ga:isoYear</code> should only be used with <code>ga:isoWeek</code> since <code>ga:week</code> represents gregorian calendar (id: <code>ga:isoYear)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_isoyear</cref>
        /// </see>
        public static readonly AnalyticsDimension IsoYear = AnalyticsDimension.Register("ga:isoYear", "Time");

        /// <summary>
        /// Combined values of <code>ga:isoYear</code> and <code>ga:isoWeek</code> (id: <code>ga:isoYearIsoWeek)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_isoyearisoweek</cref>
        /// </see>
        public static readonly AnalyticsDimension IsoYearIsoWeek = AnalyticsDimension.Register("ga:isoYearIsoWeek", "Time");

        /// <summary>
        /// Index for each hour in the specified date range. Index for the first hour of first day (i.e., start-date) in the date range is 0, 1 for the next hour, and so on (id: <code>ga:nthHour)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_nthhour</cref>
        /// </see>
        public static readonly AnalyticsDimension NthHour = AnalyticsDimension.Register("ga:nthHour", "Time");

        #endregion

        #region DoubleClick Campaign Manager

        /// <summary>
        /// DCM ad name of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickAd)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickad</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmClickAd = AnalyticsDimension.Register("ga:dcmClickAd", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM ad ID of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickAdId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickadid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmClickAdId = AnalyticsDimension.Register("ga:dcmClickAdId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM ad type name of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickAdType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickadtype</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmClickAdType = AnalyticsDimension.Register("ga:dcmClickAdType", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM ad type ID of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickAdTypeId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickadtypeid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmClickAdTypeId = AnalyticsDimension.Register("ga:dcmClickAdTypeId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM advertiser name of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickAdvertiser)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickadvertiser</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmClickAdvertiser = AnalyticsDimension.Register("ga:dcmClickAdvertiser", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM advertiser ID of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickAdvertiserId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickadvertiserid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmClickAdvertiserId = AnalyticsDimension.Register("ga:dcmClickAdvertiserId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM campaign name of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickCampaign)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickcampaign</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmClickCampaign = AnalyticsDimension.Register("ga:dcmClickCampaign", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM campaign ID of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickCampaignId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickcampaignid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmClickCampaignId = AnalyticsDimension.Register("ga:dcmClickCampaignId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM creative ID of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickCreativeId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickcreativeid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmClickCreativeId = AnalyticsDimension.Register("ga:dcmClickCreativeId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM creative name of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickCreative)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickcreative</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmClickCreative = AnalyticsDimension.Register("ga:dcmClickCreative", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM rendering ID of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickRenderingId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickrenderingid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmClickRenderingId = AnalyticsDimension.Register("ga:dcmClickRenderingId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM creative type name of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickCreativeType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickcreativetype</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmClickCreativeType = AnalyticsDimension.Register("ga:dcmClickCreativeType", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM creative type ID of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickCreativeTypeId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickcreativetypeid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmClickCreativeTypeId = AnalyticsDimension.Register("ga:dcmClickCreativeTypeId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM creative version of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickCreativeVersion)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickcreativeversion</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmClickCreativeVersion = AnalyticsDimension.Register("ga:dcmClickCreativeVersion", "DoubleClick Campaign Manager");

        /// <summary>
        /// Site name where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickSite)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclicksite</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmClickSite = AnalyticsDimension.Register("ga:dcmClickSite", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM site ID where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickSiteId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclicksiteid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmClickSiteId = AnalyticsDimension.Register("ga:dcmClickSiteId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM site placement name of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickSitePlacement)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclicksiteplacement</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmClickSitePlacement = AnalyticsDimension.Register("ga:dcmClickSitePlacement", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM site placement ID of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickSitePlacementId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclicksiteplacementid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmClickSitePlacementId = AnalyticsDimension.Register("ga:dcmClickSitePlacementId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM Floodlight configuration ID of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickSpotId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickspotid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmClickSpotId = AnalyticsDimension.Register("ga:dcmClickSpotId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM Floodlight activity name associated with the floodlight conversion (premium only) (id: <code>ga:dcmFloodlightActivity)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmfloodlightactivity</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmFloodlightActivity = AnalyticsDimension.Register("ga:dcmFloodlightActivity", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM Floodlight activity name and group name associated with the floodlight conversion (premium only) (id: <code>ga:dcmFloodlightActivityAndGroup)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmfloodlightactivityandgroup</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmFloodlightActivityAndGroup = AnalyticsDimension.Register("ga:dcmFloodlightActivityAndGroup", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM Floodlight activity group name associated with the floodlight conversion (premium only) (id: <code>ga:dcmFloodlightActivityGroup)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmfloodlightactivitygroup</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmFloodlightActivityGroup = AnalyticsDimension.Register("ga:dcmFloodlightActivityGroup", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM Floodlight activity group ID associated with the floodlight conversion (premium only) (id: <code>ga:dcmFloodlightActivityGroupId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmfloodlightactivitygroupid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmFloodlightActivityGroupId = AnalyticsDimension.Register("ga:dcmFloodlightActivityGroupId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM Floodlight activity ID associated with the floodlight conversion (premium only) (id: <code>ga:dcmFloodlightActivityId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmfloodlightactivityid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmFloodlightActivityId = AnalyticsDimension.Register("ga:dcmFloodlightActivityId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM Floodlight advertiser ID associated with the floodlight conversion (premium only) (id: <code>ga:dcmFloodlightAdvertiserId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmfloodlightadvertiserid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmFloodlightAdvertiserId = AnalyticsDimension.Register("ga:dcmFloodlightAdvertiserId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM Floodlight configuration ID associated with the floodlight conversion (premium only) (id: <code>ga:dcmFloodlightSpotId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmfloodlightspotid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmFloodlightSpotId = AnalyticsDimension.Register("ga:dcmFloodlightSpotId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM ad name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventAd)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventad</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventAd = AnalyticsDimension.Register("ga:dcmLastEventAd", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM ad ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventAdId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventadid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventAdId = AnalyticsDimension.Register("ga:dcmLastEventAdId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM ad type name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventAdType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventadtype</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventAdType = AnalyticsDimension.Register("ga:dcmLastEventAdType", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM ad type ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventAdTypeId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventadtypeid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventAdTypeId = AnalyticsDimension.Register("ga:dcmLastEventAdTypeId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM advertiser name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventAdvertiser)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventadvertiser</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventAdvertiser = AnalyticsDimension.Register("ga:dcmLastEventAdvertiser", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM advertiser ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventAdvertiserId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventadvertiserid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventAdvertiserId = AnalyticsDimension.Register("ga:dcmLastEventAdvertiserId", "DoubleClick Campaign Manager");

        /// <summary>
        /// There are two possible values: ClickThrough and ViewThrough. If the last DCM event associated with the Google Analytics session was a click, then the value will be ClickThrough. If the last DCM event associated with the Google Analytics session was an ad impression, then the value will be ViewThrough (premium only) (id: <code>ga:dcmLastEventAttributionType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventattributiontype</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventAttributionType = AnalyticsDimension.Register("ga:dcmLastEventAttributionType", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM campaign name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventCampaign)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventcampaign</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventCampaign = AnalyticsDimension.Register("ga:dcmLastEventCampaign", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM campaign ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventCampaignId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventcampaignid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventCampaignId = AnalyticsDimension.Register("ga:dcmLastEventCampaignId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM creative ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventCreativeId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventcreativeid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventCreativeId = AnalyticsDimension.Register("ga:dcmLastEventCreativeId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM creative name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventCreative)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventcreative</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventCreative = AnalyticsDimension.Register("ga:dcmLastEventCreative", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM rendering ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventRenderingId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventrenderingid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventRenderingId = AnalyticsDimension.Register("ga:dcmLastEventRenderingId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM creative type name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventCreativeType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventcreativetype</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventCreativeType = AnalyticsDimension.Register("ga:dcmLastEventCreativeType", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM creative type ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventCreativeTypeId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventcreativetypeid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventCreativeTypeId = AnalyticsDimension.Register("ga:dcmLastEventCreativeTypeId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM creative version of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventCreativeVersion)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventcreativeversion</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventCreativeVersion = AnalyticsDimension.Register("ga:dcmLastEventCreativeVersion", "DoubleClick Campaign Manager");

        /// <summary>
        /// Site name where the DCM creative was shown and clicked on for the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventSite)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventsite</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventSite = AnalyticsDimension.Register("ga:dcmLastEventSite", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM site ID where the DCM creative was shown and clicked on for the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventSiteId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventsiteid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventSiteId = AnalyticsDimension.Register("ga:dcmLastEventSiteId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM site placement name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventSitePlacement)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventsiteplacement</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventSitePlacement = AnalyticsDimension.Register("ga:dcmLastEventSitePlacement", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM site placement ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventSitePlacementId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventsiteplacementid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventSitePlacementId = AnalyticsDimension.Register("ga:dcmLastEventSitePlacementId", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM Floodlight configuration ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventSpotId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventspotid</cref>
        /// </see>
        public static readonly AnalyticsDimension DcmLastEventSpotId = AnalyticsDimension.Register("ga:dcmLastEventSpotId", "DoubleClick Campaign Manager");

        #endregion

        #region Audience

        /// <summary>
        /// Age bracket of user (id: <code>ga:userAgeBracket)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=audience&amp;jump=ga_useragebracket</cref>
        /// </see>
        public static readonly AnalyticsDimension UserAgeBracket = AnalyticsDimension.Register("ga:userAgeBracket", "Audience");

        /// <summary>
        /// Age bracket of user (id: <code>ga:visitorAgeBracket)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=audience&amp;jump=ga_visitoragebracket</cref>
        /// </see>
        [Obsolete("Use ga:userAgeBracket instead.")]
        public static readonly AnalyticsDimension VisitorAgeBracket = AnalyticsDimension.Register("ga:visitorAgeBracket", "Audience", true);

        /// <summary>
        /// Gender of user (id: <code>ga:userGender)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=audience&amp;jump=ga_usergender</cref>
        /// </see>
        public static readonly AnalyticsDimension UserGender = AnalyticsDimension.Register("ga:userGender", "Audience");

        /// <summary>
        /// Gender of user (id: <code>ga:visitorGender)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=audience&amp;jump=ga_visitorgender</cref>
        /// </see>
        [Obsolete("Use ga:userGender instead.")]
        public static readonly AnalyticsDimension VisitorGender = AnalyticsDimension.Register("ga:visitorGender", "Audience", true);

        /// <summary>
        /// Indicates that users are more likely to be interested in learning about the specified category, and more likely to be ready to purchase (id: <code>ga:interestOtherCategory)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=audience&amp;jump=ga_interestothercategory</cref>
        /// </see>
        public static readonly AnalyticsDimension InterestOtherCategory = AnalyticsDimension.Register("ga:interestOtherCategory", "Audience");

        /// <summary>
        /// Indicates that users are more likely to be interested in learning about the specified category (id: <code>ga:interestAffinityCategory)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=audience&amp;jump=ga_interestaffinitycategory</cref>
        /// </see>
        public static readonly AnalyticsDimension InterestAffinityCategory = AnalyticsDimension.Register("ga:interestAffinityCategory", "Audience");

        /// <summary>
        /// Indicates that users are more likely to be ready to purchase products or services in the specified category (id: <code>ga:interestInMarketCategory)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=audience&amp;jump=ga_interestinmarketcategory</cref>
        /// </see>
        public static readonly AnalyticsDimension InterestInMarketCategory = AnalyticsDimension.Register("ga:interestInMarketCategory", "Audience");

        #endregion

        #region Channel Grouping

        /// <summary>
        /// Gets the default channel grouping that is shared within the View (Profile) (id: <code>ga:channelGrouping)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=channel_grouping&amp;jump=ga_channelgrouping</cref>
        /// </see>
        public static readonly AnalyticsDimension ChannelGrouping = AnalyticsDimension.Register("ga:channelGrouping", "Channel Grouping");

        #endregion

        #region Related Products

        /// <summary>
        /// Correlation Model ID for related products (id: <code>ga:correlationModelId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_correlationmodelid</cref>
        /// </see>
        public static readonly AnalyticsDimension CorrelationModelId = AnalyticsDimension.Register("ga:correlationModelId", "Related Products");

        /// <summary>
        /// ID of the product being queried (id: <code>ga:queryProductId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_queryproductid</cref>
        /// </see>
        public static readonly AnalyticsDimension QueryProductId = AnalyticsDimension.Register("ga:queryProductId", "Related Products");

        /// <summary>
        /// Name of the product being queried (id: <code>ga:queryProductName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_queryproductname</cref>
        /// </see>
        public static readonly AnalyticsDimension QueryProductName = AnalyticsDimension.Register("ga:queryProductName", "Related Products");

        /// <summary>
        /// Variation of the product being queried (id: <code>ga:queryProductVariation)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_queryproductvariation</cref>
        /// </see>
        public static readonly AnalyticsDimension QueryProductVariation = AnalyticsDimension.Register("ga:queryProductVariation", "Related Products");

        /// <summary>
        /// ID of the related product (id: <code>ga:relatedProductId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_relatedproductid</cref>
        /// </see>
        public static readonly AnalyticsDimension RelatedProductId = AnalyticsDimension.Register("ga:relatedProductId", "Related Products");

        /// <summary>
        /// Name of the related product (id: <code>ga:relatedProductName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_relatedproductname</cref>
        /// </see>
        public static readonly AnalyticsDimension RelatedProductName = AnalyticsDimension.Register("ga:relatedProductName", "Related Products");

        /// <summary>
        /// Variation of the related product (id: <code>ga:relatedProductVariation)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_relatedproductvariation</cref>
        /// </see>
        public static readonly AnalyticsDimension RelatedProductVariation = AnalyticsDimension.Register("ga:relatedProductVariation", "Related Products");

        #endregion

        // ReSharper restore InconsistentNaming

        #pragma warning disable 612
        #pragma warning disable 618

        /// <summary>
        /// Gets an array will all dimensions.
        /// </summary>
        public static AnalyticsDimension[] GetAll() {
            return new [] {
                UserType, VisitorType, SessionCount, VisitCount, DaysSinceLastSession, DaysSinceLastVisit,
                UserDefinedValue, SessionDurationBucket, VisitLength, ReferralPath, FullReferrer, Campaign, Source,
                Medium, SourceMedium, Keyword, AdContent, SocialNetwork, HasSocialSourceReferral, CampaignCode,
                AdGroup, AdSlot, AdSlotPosition, AdDistributionNetwork, AdMatchType, AdKeywordMatchType,
                AdMatchedQuery, AdPlacementDomain, AdPlacementUrl, AdFormat, AdTargetingType, AdTargetingOption,
                AdDisplayUrl, AdDestinationUrl, AdwordsCustomerID, AdwordsCampaignID, AdwordsAdGroupID,
                AdwordsCreativeID, AdwordsCriteriaID, AdQueryWordCount, IsTrueViewVideoAd, GoalCompletionLocation,
                GoalPreviousStep1, GoalPreviousStep2, GoalPreviousStep3, Browser, BrowserVersion, OperatingSystem,
                OperatingSystemVersion, IsMobile, IsTablet, MobileDeviceBranding, MobileDeviceModel,
                MobileInputSelector, MobileDeviceInfo, MobileDeviceMarketingName, DeviceCategory, DataSource,
                Continent, SubContinent, Country, Region, Metro, City, Latitude, Longitude, NetworkDomain,
                NetworkLocation, CityId, CountryIsoCode, RegionId, RegionIsoCode, SubContinentCode, FlashVersion,
                JavaEnabled, Language, ScreenColors, SourcePropertyDisplayName, SourcePropertyTrackingId,
                ScreenResolution, SocialActivityEndorsingUrl, SocialActivityDisplayName, SocialActivityPost,
                SocialActivityTimestamp, SocialActivityUserHandle, SocialActivityUserPhotoUrl,
                SocialActivityUserProfileUrl, SocialActivityContentUrl, SocialActivityTagsSummary,
                SocialActivityAction, SocialActivityNetworkAction, Hostname, PagePath, PagePathLevel1, PagePathLevel2,
                PagePathLevel3, PagePathLevel4, PageTitle, LandingPagePath, SecondPagePath, ExitPagePath,
                PreviousPagePath, NextPagePath, PageDepth, LandingContentGroupXX, PreviousContentGroupXX,
                ContentGroupXX, NextContentGroupXX, SearchUsed, SearchKeyword, SearchKeywordRefinement,
                SearchCategory, SearchStartPage, SearchDestinationPage, SearchAfterDestinationPage, AppInstallerId,
                AppVersion, AppName, AppId, ScreenName, ScreenDepth, LandingScreenName, ExitScreenName, EventCategory,
                EventAction, EventLabel, TransactionId, Affiliation, SessionsToTransaction, VisitsToTransaction,
                DaysToTransaction, ProductSku, ProductName, ProductCategory, CurrencyCode, CheckoutOptions,
                InternalPromotionCreative, InternalPromotionId, InternalPromotionName, InternalPromotionPosition,
                OrderCouponCode, ProductBrand, ProductCategoryHierarchy, ProductCategoryLevelXX, ProductCouponCode,
                ProductListName, ProductListPosition, ProductVariant, ShoppingStage, SocialInteractionNetwork,
                SocialInteractionAction, SocialInteractionNetworkAction, SocialInteractionTarget,
                SocialEngagementType, UserTimingCategory, UserTimingLabel, UserTimingVariable, ExceptionDescription,
                ExperimentId, ExperimentVariant, DimensionXX, CustomVarNameXX, CustomVarValueXX, Date, Year, Month,
                Week, Day, Hour, Minute, NthMonth, NthWeek, NthDay, NthMinute, DayOfWeek, DayOfWeekName, DateHour,
                YearMonth, YearWeek, IsoWeek, IsoYear, IsoYearIsoWeek, NthHour, DcmClickAd, DcmClickAdId,
                DcmClickAdType, DcmClickAdTypeId, DcmClickAdvertiser, DcmClickAdvertiserId, DcmClickCampaign,
                DcmClickCampaignId, DcmClickCreativeId, DcmClickCreative, DcmClickRenderingId, DcmClickCreativeType,
                DcmClickCreativeTypeId, DcmClickCreativeVersion, DcmClickSite, DcmClickSiteId, DcmClickSitePlacement,
                DcmClickSitePlacementId, DcmClickSpotId, DcmFloodlightActivity, DcmFloodlightActivityAndGroup,
                DcmFloodlightActivityGroup, DcmFloodlightActivityGroupId, DcmFloodlightActivityId,
                DcmFloodlightAdvertiserId, DcmFloodlightSpotId, DcmLastEventAd, DcmLastEventAdId, DcmLastEventAdType,
                DcmLastEventAdTypeId, DcmLastEventAdvertiser, DcmLastEventAdvertiserId, DcmLastEventAttributionType,
                DcmLastEventCampaign, DcmLastEventCampaignId, DcmLastEventCreativeId, DcmLastEventCreative,
                DcmLastEventRenderingId, DcmLastEventCreativeType, DcmLastEventCreativeTypeId,
                DcmLastEventCreativeVersion, DcmLastEventSite, DcmLastEventSiteId, DcmLastEventSitePlacement,
                DcmLastEventSitePlacementId, DcmLastEventSpotId, UserAgeBracket, VisitorAgeBracket, UserGender,
                VisitorGender, InterestOtherCategory, InterestAffinityCategory, InterestInMarketCategory,
                ChannelGrouping, CorrelationModelId, QueryProductId, QueryProductName, QueryProductVariation,
                RelatedProductId, RelatedProductName, RelatedProductVariation
            };
        }

        #pragma warning restore 612
        #pragma warning restore 618

    }

}