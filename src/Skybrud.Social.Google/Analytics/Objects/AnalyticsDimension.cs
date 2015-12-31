using System;
using System.Linq;
using System.Reflection;
using Skybrud.Social.Google.Analytics.Interfaces;

namespace Skybrud.Social.Google.Analytics.Objects {

    /// <summary>
    /// Class representing a dimension in the Google Analytics API.
    /// </summary>
    public class AnalyticsDimension : IAnalyticsField {

        #region Readonly properties
        
        // ReSharper disable InconsistentNaming
        
        #region User

        /// <summary>
        /// A boolean indicating if a user is new or returning. Possible values: New Visitor, Returning Visitor (id: <code>ga:userType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_usertype</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.UserType instead.")]
        public static readonly AnalyticsDimension UserType = Dimensions.AnalyticsDimensions.UserType;

        /// <summary>
        /// A boolean indicating if a user is new or returning. Possible values: New Visitor, Returning Visitor (id: <code>ga:visitorType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_visitortype</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.VisitorType instead.")]
        public static readonly AnalyticsDimension VisitorType = Dimensions.AnalyticsDimensions.VisitorType;

        /// <summary>
        /// Gets the session index for a user. Each session from a unique user will get its own incremental index starting from 1 for the first session. Subsequent sessions do not change previous session indicies. For example, if a certain user has 4 sessions to your website, sessionCount for that user will have 4 distinct values of '1' through '4' (id: <code>ga:sessionCount)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_sessioncount</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SessionCount instead.")]
        public static readonly AnalyticsDimension SessionCount = Dimensions.AnalyticsDimensions.SessionCount;

        /// <summary>
        /// Gets the session index for a user. Each session from a unique user will get its own incremental index starting from 1 for the first session. Subsequent sessions do not change previous session indicies. For example, if a certain user has 4 sessions to your website, sessionCount for that user will have 4 distinct values of '1' through '4' (id: <code>ga:visitCount)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_visitcount</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.VisitCount instead.")]
        public static readonly AnalyticsDimension VisitCount = Dimensions.AnalyticsDimensions.VisitCount;

        /// <summary>
        /// Gets the number of days elapsed since users last visited your property. Used to calculate user loyalty (id: <code>ga:daysSinceLastSession)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_dayssincelastsession</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DaysSinceLastSession instead.")]
        public static readonly AnalyticsDimension DaysSinceLastSession = Dimensions.AnalyticsDimensions.DaysSinceLastSession;

        /// <summary>
        /// Gets the number of days elapsed since users last visited your property. Used to calculate user loyalty (id: <code>ga:daysSinceLastVisit)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_dayssincelastvisit</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DaysSinceLastVisit instead.")]
        public static readonly AnalyticsDimension DaysSinceLastVisit = Dimensions.AnalyticsDimensions.DaysSinceLastVisit;

        /// <summary>
        /// Gets the value provided when you define custom user segments for your property (id: <code>ga:userDefinedValue)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_userdefinedvalue</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.UserDefinedValue instead.")]
        public static readonly AnalyticsDimension UserDefinedValue = Dimensions.AnalyticsDimensions.UserDefinedValue;

        #endregion

        #region Session

        /// <summary>
        /// Gets the length of a session measured in seconds and reported in second increments. The value returned is a string (id: <code>ga:sessionDurationBucket)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_sessiondurationbucket</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SessionDurationBucket instead.")]
        public static readonly AnalyticsDimension SessionDurationBucket = Dimensions.AnalyticsDimensions.SessionDurationBucket;

        /// <summary>
        /// Gets the length of a session measured in seconds and reported in second increments. The value returned is a string (id: <code>ga:visitLength)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_visitlength</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.VisitLength instead.")]
        public static readonly AnalyticsDimension VisitLength = Dimensions.AnalyticsDimensions.VisitLength;

        #endregion

        #region Traffic Sources

        /// <summary>
        /// Gets the path of the referring URL (e.g. document.referrer). If someone places a link to your property on their website, this element contains the path of the page that contains the referring link (id: <code>ga:referralPath)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_referralpath</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ReferralPath instead.")]
        public static readonly AnalyticsDimension ReferralPath = Dimensions.AnalyticsDimensions.ReferralPath;

        /// <summary>
        /// Gets the full referring URL including the hostname and path (id: <code>ga:fullReferrer)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_fullreferrer</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.FullReferrer instead.")]
        public static readonly AnalyticsDimension FullReferrer = Dimensions.AnalyticsDimensions.FullReferrer;

        /// <summary>
        /// When using manual campaign tracking, the value of the utm_campaign campaign tracking parameter. When using AdWords autotagging, the name(s) of the online ad campaign that you use for your property. Otherwise the value (not set) is used (id: <code>ga:campaign)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_campaign</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Campaign instead.")]
        public static readonly AnalyticsDimension Campaign = Dimensions.AnalyticsDimensions.Campaign;

        /// <summary>
        /// Gets the source of referrals. When using manual campaign tracking, the value of the utm_source campaign tracking parameter. When using AdWords autotagging, the value is google. Otherwise the domain of the source referring the user (e.g. document.referrer). The value may also contain a port address. If the user arrived without a referrer, the value is (direct) (id: <code>ga:source)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_source</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Source instead.")]
        public static readonly AnalyticsDimension Source = Dimensions.AnalyticsDimensions.Source;

        /// <summary>
        /// Gets the type of referrals. When using manual campaign tracking, the value of the utm_medium campaign tracking parameter. When using AdWords autotagging, the value is ppc. If the user comes from a search engine detected by Google Analytics, the value is organic. If the referrer is not a search engine, the value is referral. If the users came directly to the property, and document.referrer is empty, the value is (none) (id: <code>ga:medium)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_medium</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Medium instead.")]
        public static readonly AnalyticsDimension Medium = Dimensions.AnalyticsDimensions.Medium;

        /// <summary>
        /// Combined values of <code>ga:source</code> and <code>ga:medium</code> (id: <code>ga:sourceMedium)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_sourcemedium</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SourceMedium instead.")]
        public static readonly AnalyticsDimension SourceMedium = Dimensions.AnalyticsDimensions.SourceMedium;

        /// <summary>
        /// When using manual campaign tracking, the value of the utm_term campaign tracking parameter. When using AdWords autotagging or if a user used organic search to reach your property, the keywords used by users to reach your property. Otherwise the value is (not set) (id: <code>ga:keyword)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_keyword</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Keyword instead.")]
        public static readonly AnalyticsDimension Keyword = Dimensions.AnalyticsDimensions.Keyword;

        /// <summary>
        /// When using manual campaign tracking, the value of the utm_content campaign tracking parameter. When using AdWords autotagging, the first line of the text for your online Ad campaign. If you are using mad libs for your AdWords content, this field displays the keywords you provided for the mad libs keyword match. Otherwise the value is (not set) (id: <code>ga:adContent)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_adcontent</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdContent instead.")]
        public static readonly AnalyticsDimension AdContent = Dimensions.AnalyticsDimensions.AdContent;

        /// <summary>
        /// Name of the social network. This can be related to the referring social network for traffic sources, or to the social network for social data hub activities. E.g. Google+, Blogger, etc (id: <code>ga:socialNetwork)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_socialnetwork</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SocialNetwork instead.")]
        public static readonly AnalyticsDimension SocialNetwork = Dimensions.AnalyticsDimensions.SocialNetwork;

        /// <summary>
        /// Indicates sessions that arrived to the property from a social source. The possible values are Yes or No where the first letter is capitalized (id: <code>ga:hasSocialSourceReferral)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_hassocialsourcereferral</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.HasSocialSourceReferral instead.")]
        public static readonly AnalyticsDimension HasSocialSourceReferral = Dimensions.AnalyticsDimensions.HasSocialSourceReferral;

        /// <summary>
        /// When using manual campaign tracking, the value of the utm_id campaign tracking parameter (id: <code>ga:campaignCode)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_campaigncode</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.CampaignCode instead.")]
        public static readonly AnalyticsDimension CampaignCode = Dimensions.AnalyticsDimensions.CampaignCode;

        #endregion

        #region Adwords

        /// <summary>
        /// Gets the name of your AdWords ad group (id: <code>ga:adGroup)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adgroup</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdGroup instead.")]
        public static readonly AnalyticsDimension AdGroup = Dimensions.AnalyticsDimensions.AdGroup;

        /// <summary>
        /// Gets the location of the advertisement on the hosting page (Top, RHS, or not set) (id: <code>ga:adSlot)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adslot</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdSlot instead.")]
        public static readonly AnalyticsDimension AdSlot = Dimensions.AnalyticsDimensions.AdSlot;

        /// <summary>
        /// This dimension is deprecated and will be removed soon (id: <code>ga:adSlotPosition)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adslotposition</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdSlotPosition instead.")]
        public static readonly AnalyticsDimension AdSlotPosition = Dimensions.AnalyticsDimensions.AdSlotPosition;

        /// <summary>
        /// Gets the networks used to deliver your ads (Content, Search, Search partners, etc.) (id: <code>ga:adDistributionNetwork)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_addistributionnetwork</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdDistributionNetwork instead.")]
        public static readonly AnalyticsDimension AdDistributionNetwork = Dimensions.AnalyticsDimensions.AdDistributionNetwork;

        /// <summary>
        /// Gets the match types applied for the search term the user had input(Phrase, Exact, Broad, etc.). Ads on the content network are identified as "Content network". Details: https://support.google.com/adwords/answer/2472708?hl=en (id: <code>ga:adMatchType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_admatchtype</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdMatchType instead.")]
        public static readonly AnalyticsDimension AdMatchType = Dimensions.AnalyticsDimensions.AdMatchType;

        /// <summary>
        /// Gets the match types applied to your keywords (Phrase, Exact, Broad). Details: https://support.google.com/adwords/answer/2472708?hl=en (id: <code>ga:adKeywordMatchType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adkeywordmatchtype</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdKeywordMatchType instead.")]
        public static readonly AnalyticsDimension AdKeywordMatchType = Dimensions.AnalyticsDimensions.AdKeywordMatchType;

        /// <summary>
        /// Gets the search queries that triggered impressions of your AdWords ads (id: <code>ga:adMatchedQuery)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_admatchedquery</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdMatchedQuery instead.")]
        public static readonly AnalyticsDimension AdMatchedQuery = Dimensions.AnalyticsDimensions.AdMatchedQuery;

        /// <summary>
        /// Gets the domains where your ads on the content network were placed (id: <code>ga:adPlacementDomain)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adplacementdomain</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdPlacementDomain instead.")]
        public static readonly AnalyticsDimension AdPlacementDomain = Dimensions.AnalyticsDimensions.AdPlacementDomain;

        /// <summary>
        /// Gets the URLs where your ads on the content network were placed (id: <code>ga:adPlacementUrl)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adplacementurl</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdPlacementUrl instead.")]
        public static readonly AnalyticsDimension AdPlacementUrl = Dimensions.AnalyticsDimensions.AdPlacementUrl;

        /// <summary>
        /// Your AdWords ad formats (Text, Image, Flash, Video, etc.) (id: <code>ga:adFormat)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adformat</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdFormat instead.")]
        public static readonly AnalyticsDimension AdFormat = Dimensions.AnalyticsDimensions.AdFormat;

        /// <summary>
        /// Gets how your AdWords ads were targeted (keyword, placement, and vertical targeting, etc.) (id: <code>ga:adTargetingType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adtargetingtype</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdTargetingType instead.")]
        public static readonly AnalyticsDimension AdTargetingType = Dimensions.AnalyticsDimensions.AdTargetingType;

        /// <summary>
        /// Gets how you manage your ads on the content network. Values are Automatic placements or Managed placements (id: <code>ga:adTargetingOption)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adtargetingoption</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdTargetingOption instead.")]
        public static readonly AnalyticsDimension AdTargetingOption = Dimensions.AnalyticsDimensions.AdTargetingOption;

        /// <summary>
        /// Gets the URLs your AdWords ads displayed (id: <code>ga:adDisplayUrl)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_addisplayurl</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdDisplayUrl instead.")]
        public static readonly AnalyticsDimension AdDisplayUrl = Dimensions.AnalyticsDimensions.AdDisplayUrl;

        /// <summary>
        /// Gets the URLs to which your AdWords ads referred traffic (id: <code>ga:adDestinationUrl)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_addestinationurl</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdDestinationUrl instead.")]
        public static readonly AnalyticsDimension AdDestinationUrl = Dimensions.AnalyticsDimensions.AdDestinationUrl;

        /// <summary>
        /// A string. Corresponds to AdWords API AccountInfo.customerId (id: <code>ga:adwordsCustomerID)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adwordscustomerid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdwordsCustomerID instead.")]
        public static readonly AnalyticsDimension AdwordsCustomerID = Dimensions.AnalyticsDimensions.AdwordsCustomerID;

        /// <summary>
        /// A string. Corresponds to AdWords API Campaign.id (id: <code>ga:adwordsCampaignID)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adwordscampaignid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdwordsCampaignID instead.")]
        public static readonly AnalyticsDimension AdwordsCampaignID = Dimensions.AnalyticsDimensions.AdwordsCampaignID;

        /// <summary>
        /// A string. Corresponds to AdWords API AdGroup.id (id: <code>ga:adwordsAdGroupID)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adwordsadgroupid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdwordsAdGroupID instead.")]
        public static readonly AnalyticsDimension AdwordsAdGroupID = Dimensions.AnalyticsDimensions.AdwordsAdGroupID;

        /// <summary>
        /// A string. Corresponds to AdWords API Ad.id (id: <code>ga:adwordsCreativeID)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adwordscreativeid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdwordsCreativeID instead.")]
        public static readonly AnalyticsDimension AdwordsCreativeID = Dimensions.AnalyticsDimensions.AdwordsCreativeID;

        /// <summary>
        /// A string. Corresponds to AdWords API Criterion.id (id: <code>ga:adwordsCriteriaID)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adwordscriteriaid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdwordsCriteriaID instead.")]
        public static readonly AnalyticsDimension AdwordsCriteriaID = Dimensions.AnalyticsDimensions.AdwordsCriteriaID;

        /// <summary>
        /// Gets the number of words in the search query (id: <code>ga:adQueryWordCount)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adquerywordcount</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AdQueryWordCount instead.")]
        public static readonly AnalyticsDimension AdQueryWordCount = Dimensions.AnalyticsDimensions.AdQueryWordCount;

        /// <summary>
        /// 'Yes' or 'No' - Indicates whether the ad is an AdWords TrueView video ad (id: <code>ga:isTrueViewVideoAd)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_istrueviewvideoad</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.IsTrueViewVideoAd instead.")]
        public static readonly AnalyticsDimension IsTrueViewVideoAd = Dimensions.AnalyticsDimensions.IsTrueViewVideoAd;

        #endregion

        #region Goal Conversions

        /// <summary>
        /// Gets the page path or screen name that matched any destination type goal completion (id: <code>ga:goalCompletionLocation)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalcompletionlocation</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.GoalCompletionLocation instead.")]
        public static readonly AnalyticsDimension GoalCompletionLocation = Dimensions.AnalyticsDimensions.GoalCompletionLocation;

        /// <summary>
        /// Gets the page path or screen name that matched any destination type goal, one step prior to the goal completion location (id: <code>ga:goalPreviousStep1)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalpreviousstep1</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.GoalPreviousStep1 instead.")]
        public static readonly AnalyticsDimension GoalPreviousStep1 = Dimensions.AnalyticsDimensions.GoalPreviousStep1;

        /// <summary>
        /// Gets the page path or screen name that matched any destination type goal, two steps prior to the goal completion location (id: <code>ga:goalPreviousStep2)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalpreviousstep2</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.GoalPreviousStep2 instead.")]
        public static readonly AnalyticsDimension GoalPreviousStep2 = Dimensions.AnalyticsDimensions.GoalPreviousStep2;

        /// <summary>
        /// Gets the page path or screen name that matched any destination type goal, three steps prior to the goal completion location (id: <code>ga:goalPreviousStep3)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalpreviousstep3</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.GoalPreviousStep3 instead.")]
        public static readonly AnalyticsDimension GoalPreviousStep3 = Dimensions.AnalyticsDimensions.GoalPreviousStep3;

        #endregion

        #region Platform or Device

        /// <summary>
        /// Gets the names of browsers used by users to your website. For example, Internet Explorer or Firefox (id: <code>ga:browser)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_browser</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Browser instead.")]
        public static readonly AnalyticsDimension Browser = Dimensions.AnalyticsDimensions.Browser;

        /// <summary>
        /// Gets the browser versions used by users to your website. For example, 2.0.0.14 (id: <code>ga:browserVersion)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_browserversion</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.BrowserVersion instead.")]
        public static readonly AnalyticsDimension BrowserVersion = Dimensions.AnalyticsDimensions.BrowserVersion;

        /// <summary>
        /// Gets the operating system used by your users. For example, Windows, Linux , Macintosh, iPhone, iPod (id: <code>ga:operatingSystem)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_operatingsystem</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.OperatingSystem instead.")]
        public static readonly AnalyticsDimension OperatingSystem = Dimensions.AnalyticsDimensions.OperatingSystem;

        /// <summary>
        /// Gets the version of the operating system used by your users, such as XP for Windows or PPC for Macintosh (id: <code>ga:operatingSystemVersion)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_operatingsystemversion</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.OperatingSystemVersion instead.")]
        public static readonly AnalyticsDimension OperatingSystemVersion = Dimensions.AnalyticsDimensions.OperatingSystemVersion;

        /// <summary>
        /// This dimension is deprecated and will be removed soon. Please use <code>ga:deviceCategory</code> instead (e.g., <code>ga:deviceCategory</code>==mobile) (id: <code>ga:isMobile)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_ismobile</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.IsMobile instead.")]
        public static readonly AnalyticsDimension IsMobile = Dimensions.AnalyticsDimensions.IsMobile;

        /// <summary>
        /// This dimension is deprecated and will be removed soon. Please use <code>ga:deviceCategory</code> instead (e.g., <code>ga:deviceCategory</code>==tablet) (id: <code>ga:isTablet)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_istablet</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.IsTablet instead.")]
        public static readonly AnalyticsDimension IsTablet = Dimensions.AnalyticsDimensions.IsTablet;

        /// <summary>
        /// Mobile manufacturer or branded name (id: <code>ga:mobileDeviceBranding)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_mobiledevicebranding</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.MobileDeviceBranding instead.")]
        public static readonly AnalyticsDimension MobileDeviceBranding = Dimensions.AnalyticsDimensions.MobileDeviceBranding;

        /// <summary>
        /// Mobile device model (id: <code>ga:mobileDeviceModel)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_mobiledevicemodel</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.MobileDeviceModel instead.")]
        public static readonly AnalyticsDimension MobileDeviceModel = Dimensions.AnalyticsDimensions.MobileDeviceModel;

        /// <summary>
        /// Selector used on the mobile device (e.g.: touchscreen, joystick, clickwheel, stylus) (id: <code>ga:mobileInputSelector)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_mobileinputselector</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.MobileInputSelector instead.")]
        public static readonly AnalyticsDimension MobileInputSelector = Dimensions.AnalyticsDimensions.MobileInputSelector;

        /// <summary>
        /// Gets the branding, model, and marketing name used to identify the mobile device (id: <code>ga:mobileDeviceInfo)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_mobiledeviceinfo</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.MobileDeviceInfo instead.")]
        public static readonly AnalyticsDimension MobileDeviceInfo = Dimensions.AnalyticsDimensions.MobileDeviceInfo;

        /// <summary>
        /// Gets the marketing name used for the mobile device (id: <code>ga:mobileDeviceMarketingName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_mobiledevicemarketingname</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.MobileDeviceMarketingName instead.")]
        public static readonly AnalyticsDimension MobileDeviceMarketingName = Dimensions.AnalyticsDimensions.MobileDeviceMarketingName;

        /// <summary>
        /// Gets the type of device: desktop, tablet, or mobile (id: <code>ga:deviceCategory)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_devicecategory</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DeviceCategory instead.")]
        public static readonly AnalyticsDimension DeviceCategory = Dimensions.AnalyticsDimensions.DeviceCategory;

        /// <summary>
        /// Gets the data source of a hit. By default, hits sent from ga.js and analytics.js are reported as "web". Hits sent from the mobile SDKs are reported as "app". These values can be overridden in the Measurement Protocol (id: <code>ga:dataSource)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=platform_or_device&amp;jump=ga_datasource</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DataSource instead.")]
        public static readonly AnalyticsDimension DataSource = Dimensions.AnalyticsDimensions.DataSource;

        #endregion

        #region Geo Network

        /// <summary>
        /// Gets the continents of users, derived from IP addresses or Geographical IDs (id: <code>ga:continent)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_continent</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Continent instead.")]
        public static readonly AnalyticsDimension Continent = Dimensions.AnalyticsDimensions.Continent;

        /// <summary>
        /// Gets the sub-continent of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe (id: <code>ga:subContinent)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_subcontinent</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SubContinent instead.")]
        public static readonly AnalyticsDimension SubContinent = Dimensions.AnalyticsDimensions.SubContinent;

        /// <summary>
        /// Gets the country of users, derived from IP addresses or Geographical IDs (id: <code>ga:country)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_country</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Country instead.")]
        public static readonly AnalyticsDimension Country = Dimensions.AnalyticsDimensions.Country;

        /// <summary>
        /// Gets the region of users, derived from IP addresses or Geographical IDs. In the U.S., a region is a state, such as New York (id: <code>ga:region)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_region</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Region instead.")]
        public static readonly AnalyticsDimension Region = Dimensions.AnalyticsDimensions.Region;

        /// <summary>
        /// Gets the Designated Market Area (DMA) from where traffic arrived (id: <code>ga:metro)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_metro</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Metro instead.")]
        public static readonly AnalyticsDimension Metro = Dimensions.AnalyticsDimensions.Metro;

        /// <summary>
        /// Gets the cities of users, derived from IP addresses or Geographical IDs (id: <code>ga:city)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_city</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.City instead.")]
        public static readonly AnalyticsDimension City = Dimensions.AnalyticsDimensions.City;

        /// <summary>
        /// Gets the approximate latitude of the user's city. Derived from IP addresses or Geographical IDs. Locations north of the equator are represented by positive values and locations south of the equator by negative values (id: <code>ga:latitude)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_latitude</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Latitude instead.")]
        public static readonly AnalyticsDimension Latitude = Dimensions.AnalyticsDimensions.Latitude;

        /// <summary>
        /// Gets the approximate longitude of the user's city. Derived from IP addresses or Geographical IDs. Locations east of the meridian are represented by positive values and locations west of the meridian by negative values (id: <code>ga:longitude)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_longitude</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Longitude instead.")]
        public static readonly AnalyticsDimension Longitude = Dimensions.AnalyticsDimensions.Longitude;

        /// <summary>
        /// Gets the domain name of the ISPs used by users. This is derived from the domain name registered to the IP address (id: <code>ga:networkDomain)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_networkdomain</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.NetworkDomain instead.")]
        public static readonly AnalyticsDimension NetworkDomain = Dimensions.AnalyticsDimensions.NetworkDomain;

        /// <summary>
        /// Gets the name of service providers used to reach your property. For example, if most users to your website come via the major service providers for cable internet, you will see the names of those cable service providers in this element (id: <code>ga:networkLocation)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_networklocation</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.NetworkLocation instead.")]
        public static readonly AnalyticsDimension NetworkLocation = Dimensions.AnalyticsDimensions.NetworkLocation;

        /// <summary>
        /// Gets the city IDs of users, derived from IP addresses or Geographical IDs (id: <code>ga:cityId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_cityid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.CityId instead.")]
        public static readonly AnalyticsDimension CityId = Dimensions.AnalyticsDimensions.CityId;

        /// <summary>
        /// Gets the country ISO code of users, derived from IP addresses or Geographical IDs. Values are given as an ISO-3166-1 alpha-2 code (id: <code>ga:countryIsoCode)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_countryisocode</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.CountryIsoCode instead.")]
        public static readonly AnalyticsDimension CountryIsoCode = Dimensions.AnalyticsDimensions.CountryIsoCode;

        /// <summary>
        /// Gets the region ID of users, derived from IP addresses or Geographical IDs. In the U.S., a region is a state, such as New York (id: <code>ga:regionId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_regionid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.RegionId instead.")]
        public static readonly AnalyticsDimension RegionId = Dimensions.AnalyticsDimensions.RegionId;

        /// <summary>
        /// Gets the region ISO code of users, derived from IP addresses or Geographical IDs. Values are given as an ISO-3166-2 code (id: <code>ga:regionIsoCode)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_regionisocode</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.RegionIsoCode instead.")]
        public static readonly AnalyticsDimension RegionIsoCode = Dimensions.AnalyticsDimensions.RegionIsoCode;

        /// <summary>
        /// Gets the sub-continent code of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe. Values are given as a UN M.49 code (id: <code>ga:subContinentCode)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=geo_network&amp;jump=ga_subcontinentcode</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SubContinentCode instead.")]
        public static readonly AnalyticsDimension SubContinentCode = Dimensions.AnalyticsDimensions.SubContinentCode;

        #endregion

        #region System

        /// <summary>
        /// Gets the versions of Flash supported by users' browsers, including minor versions (id: <code>ga:flashVersion)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=system&amp;jump=ga_flashversion</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.FlashVersion instead.")]
        public static readonly AnalyticsDimension FlashVersion = Dimensions.AnalyticsDimensions.FlashVersion;

        /// <summary>
        /// Indicates Java support for users' browsers. The possible values are Yes or No where the first letter must be capitalized (id: <code>ga:javaEnabled)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=system&amp;jump=ga_javaenabled</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.JavaEnabled instead.")]
        public static readonly AnalyticsDimension JavaEnabled = Dimensions.AnalyticsDimensions.JavaEnabled;

        /// <summary>
        /// Gets the language provided by the HTTP Request for the browser. Values are given as an ISO-639 code (e.g. en-gb for British English) (id: <code>ga:language)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=system&amp;jump=ga_language</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Language instead.")]
        public static readonly AnalyticsDimension Language = Dimensions.AnalyticsDimensions.Language;

        /// <summary>
        /// Gets the color depth of users' monitors, as retrieved from the DOM of the user's browser. For example 4-bit, 8-bit, 24-bit, or undefined-bit (id: <code>ga:screenColors)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=system&amp;jump=ga_screencolors</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ScreenColors instead.")]
        public static readonly AnalyticsDimension ScreenColors = Dimensions.AnalyticsDimensions.ScreenColors;

        /// <summary>
        /// Source property display name of roll-up properties. This is valid only for roll-up properties (id: <code>ga:sourcePropertyDisplayName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=system&amp;jump=ga_sourcepropertydisplayname</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SourcePropertyDisplayName instead.")]
        public static readonly AnalyticsDimension SourcePropertyDisplayName = Dimensions.AnalyticsDimensions.SourcePropertyDisplayName;

        /// <summary>
        /// Source property tracking ID of roll-up properties. This is valid only for roll-up properties (id: <code>ga:sourcePropertyTrackingId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=system&amp;jump=ga_sourcepropertytrackingid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SourcePropertyTrackingId instead.")]
        public static readonly AnalyticsDimension SourcePropertyTrackingId = Dimensions.AnalyticsDimensions.SourcePropertyTrackingId;

        /// <summary>
        /// Gets the screen resolution of users' screens. For example: 1024x738 (id: <code>ga:screenResolution)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=system&amp;jump=ga_screenresolution</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ScreenResolution instead.")]
        public static readonly AnalyticsDimension ScreenResolution = Dimensions.AnalyticsDimensions.ScreenResolution;

        #endregion

        #region Social Activities

        /// <summary>
        /// For a social data hub activity, this value represents the URL of the social activity (e.g. the Google+ post URL, the blog comment URL, etc.) (id: <code>ga:socialActivityEndorsingUrl)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivityendorsingurl</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SocialActivityEndorsingUrl instead.")]
        public static readonly AnalyticsDimension SocialActivityEndorsingUrl = Dimensions.AnalyticsDimensions.SocialActivityEndorsingUrl;

        /// <summary>
        /// For a social data hub activity, this value represents the title of the social activity posted by the social network user (id: <code>ga:socialActivityDisplayName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivitydisplayname</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SocialActivityDisplayName instead.")]
        public static readonly AnalyticsDimension SocialActivityDisplayName = Dimensions.AnalyticsDimensions.SocialActivityDisplayName;

        /// <summary>
        /// For a social data hub activity, this value represents the content of the social activity posted by the social network user (e.g. The message content of a Google+ post) (id: <code>ga:socialActivityPost)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivitypost</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SocialActivityPost instead.")]
        public static readonly AnalyticsDimension SocialActivityPost = Dimensions.AnalyticsDimensions.SocialActivityPost;

        /// <summary>
        /// For a social data hub activity, this value represents when the social activity occurred on the social network (id: <code>ga:socialActivityTimestamp)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivitytimestamp</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SocialActivityTimestamp instead.")]
        public static readonly AnalyticsDimension SocialActivityTimestamp = Dimensions.AnalyticsDimensions.SocialActivityTimestamp;

        /// <summary>
        /// For a social data hub activity, this value represents the social network handle (e.g. name or ID) of the user who initiated the social activity (id: <code>ga:socialActivityUserHandle)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivityuserhandle</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SocialActivityUserHandle instead.")]
        public static readonly AnalyticsDimension SocialActivityUserHandle = Dimensions.AnalyticsDimensions.SocialActivityUserHandle;

        /// <summary>
        /// For a social data hub activity, this value represents the URL of the photo associated with the user's social network profile (id: <code>ga:socialActivityUserPhotoUrl)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivityuserphotourl</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SocialActivityUserPhotoUrl instead.")]
        public static readonly AnalyticsDimension SocialActivityUserPhotoUrl = Dimensions.AnalyticsDimensions.SocialActivityUserPhotoUrl;

        /// <summary>
        /// For a social data hub activity, this value represents the URL of the associated user's social network profile (id: <code>ga:socialActivityUserProfileUrl)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivityuserprofileurl</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SocialActivityUserProfileUrl instead.")]
        public static readonly AnalyticsDimension SocialActivityUserProfileUrl = Dimensions.AnalyticsDimensions.SocialActivityUserProfileUrl;

        /// <summary>
        /// For a social data hub activity, this value represents the URL shared by the associated social network user (id: <code>ga:socialActivityContentUrl)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivitycontenturl</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SocialActivityContentUrl instead.")]
        public static readonly AnalyticsDimension SocialActivityContentUrl = Dimensions.AnalyticsDimensions.SocialActivityContentUrl;

        /// <summary>
        /// For a social data hub activity, this is a comma-separated set of tags associated with the social activity (id: <code>ga:socialActivityTagsSummary)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivitytagssummary</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SocialActivityTagsSummary instead.")]
        public static readonly AnalyticsDimension SocialActivityTagsSummary = Dimensions.AnalyticsDimensions.SocialActivityTagsSummary;

        /// <summary>
        /// For a social data hub activity, this value represents the type of social action associated with the activity (e.g. vote, comment, +1, etc.) (id: <code>ga:socialActivityAction)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivityaction</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SocialActivityAction instead.")]
        public static readonly AnalyticsDimension SocialActivityAction = Dimensions.AnalyticsDimensions.SocialActivityAction;

        /// <summary>
        /// For a social data hub activity, this value represents the type of social action and the social network where the activity originated (id: <code>ga:socialActivityNetworkAction)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivitynetworkaction</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SocialActivityNetworkAction instead.")]
        public static readonly AnalyticsDimension SocialActivityNetworkAction = Dimensions.AnalyticsDimensions.SocialActivityNetworkAction;

        #endregion

        #region Page Tracking

        /// <summary>
        /// Gets the hostname from which the tracking request was made (id: <code>ga:hostname)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_hostname</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Hostname instead.")]
        public static readonly AnalyticsDimension Hostname = Dimensions.AnalyticsDimensions.Hostname;

        /// <summary>
        /// A page on your website specified by path and/or query parameters. Use in conjunction with hostname to get the full URL of the page (id: <code>ga:pagePath)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pagepath</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.PagePath instead.")]
        public static readonly AnalyticsDimension PagePath = Dimensions.AnalyticsDimensions.PagePath;

        /// <summary>
        /// This dimension rolls up all the page paths in the first hierarchical level in pagePath (id: <code>ga:pagePathLevel1)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pagepathlevel1</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.PagePathLevel1 instead.")]
        public static readonly AnalyticsDimension PagePathLevel1 = Dimensions.AnalyticsDimensions.PagePathLevel1;

        /// <summary>
        /// This dimension rolls up all the page paths in the second hierarchical level in pagePath (id: <code>ga:pagePathLevel2)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pagepathlevel2</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.PagePathLevel2 instead.")]
        public static readonly AnalyticsDimension PagePathLevel2 = Dimensions.AnalyticsDimensions.PagePathLevel2;

        /// <summary>
        /// This dimension rolls up all the page paths in the third hierarchical level in pagePath (id: <code>ga:pagePathLevel3)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pagepathlevel3</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.PagePathLevel3 instead.")]
        public static readonly AnalyticsDimension PagePathLevel3 = Dimensions.AnalyticsDimensions.PagePathLevel3;

        /// <summary>
        /// This dimension rolls up all the page paths into hierarchical levels. Up to 4 pagePath levels maybe specified. All additional levels in the pagePath hierarchy are also rolled up in this dimension (id: <code>ga:pagePathLevel4)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pagepathlevel4</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.PagePathLevel4 instead.")]
        public static readonly AnalyticsDimension PagePathLevel4 = Dimensions.AnalyticsDimensions.PagePathLevel4;

        /// <summary>
        /// Gets the title of a page. Keep in mind that multiple pages might have the same page title (id: <code>ga:pageTitle)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pagetitle</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.PageTitle instead.")]
        public static readonly AnalyticsDimension PageTitle = Dimensions.AnalyticsDimensions.PageTitle;

        /// <summary>
        /// Gets the first page in a user's session, or landing page (id: <code>ga:landingPagePath)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_landingpagepath</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.LandingPagePath instead.")]
        public static readonly AnalyticsDimension LandingPagePath = Dimensions.AnalyticsDimensions.LandingPagePath;

        /// <summary>
        /// Gets the second page in a user's session (id: <code>ga:secondPagePath)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_secondpagepath</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SecondPagePath instead.")]
        public static readonly AnalyticsDimension SecondPagePath = Dimensions.AnalyticsDimensions.SecondPagePath;

        /// <summary>
        /// Gets the last page in a user's session, or exit page (id: <code>ga:exitPagePath)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_exitpagepath</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ExitPagePath instead.")]
        public static readonly AnalyticsDimension ExitPagePath = Dimensions.AnalyticsDimensions.ExitPagePath;

        /// <summary>
        /// A page that was visited before another page on the same property. Typically used with the pagePath dimension (id: <code>ga:previousPagePath)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_previouspagepath</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.PreviousPagePath instead.")]
        public static readonly AnalyticsDimension PreviousPagePath = Dimensions.AnalyticsDimensions.PreviousPagePath;

        /// <summary>
        /// This dimension is deprecated and will be removed soon. Please use <code>ga:pagePath</code> instead (id: <code>ga:nextPagePath)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_nextpagepath</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.NextPagePath instead.")]
        public static readonly AnalyticsDimension NextPagePath = Dimensions.AnalyticsDimensions.NextPagePath;

        /// <summary>
        /// Gets the number of pages visited by users during a session. The value is a histogram that counts pageviews across a range of possible values. In this calculation, all sessions will have at least one pageview, and some percentage of sessions will have more (id: <code>ga:pageDepth)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pagedepth</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.PageDepth instead.")]
        public static readonly AnalyticsDimension PageDepth = Dimensions.AnalyticsDimensions.PageDepth;

        #endregion

        #region Content Grouping

        /// <summary>
        /// Gets the first matching content group in a user's session (id: <code>ga:landingContentGroupXX)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=content_grouping&amp;jump=ga_landingcontentgroupxx</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.LandingContentGroupXX instead.")]
        public static readonly AnalyticsDimension LandingContentGroupXX = Dimensions.AnalyticsDimensions.LandingContentGroupXX;

        /// <summary>
        /// Refers to content group that was visited before another content group (id: <code>ga:previousContentGroupXX)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=content_grouping&amp;jump=ga_previouscontentgroupxx</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.PreviousContentGroupXX instead.")]
        public static readonly AnalyticsDimension PreviousContentGroupXX = Dimensions.AnalyticsDimensions.PreviousContentGroupXX;

        /// <summary>
        /// Content group on a property. A content group is a collection of content providing a logical structure that can be determined by tracking code or page title/url regex match, or predefined rules (id: <code>ga:contentGroupXX)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=content_grouping&amp;jump=ga_contentgroupxx</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ContentGroupXX instead.")]
        public static readonly AnalyticsDimension ContentGroupXX = Dimensions.AnalyticsDimensions.ContentGroupXX;

        /// <summary>
        /// This dimension is deprecated and will be removed soon. Please use <code>ga:contentGroupXX</code> instead (id: <code>ga:nextContentGroupXX)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=content_grouping&amp;jump=ga_nextcontentgroupxx</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.NextContentGroupXX instead.")]
        public static readonly AnalyticsDimension NextContentGroupXX = Dimensions.AnalyticsDimensions.NextContentGroupXX;

        #endregion

        #region Internal Search

        /// <summary>
        /// A boolean to distinguish whether internal search was used in a session. Values are Visits With Site Search and Visits Without Site Search (id: <code>ga:searchUsed)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchused</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SearchUsed instead.")]
        public static readonly AnalyticsDimension SearchUsed = Dimensions.AnalyticsDimensions.SearchUsed;

        /// <summary>
        /// Search terms used by users within your property (id: <code>ga:searchKeyword)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchkeyword</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SearchKeyword instead.")]
        public static readonly AnalyticsDimension SearchKeyword = Dimensions.AnalyticsDimensions.SearchKeyword;

        /// <summary>
        /// Subsequent keyword search terms or strings entered by users after a given initial string search (id: <code>ga:searchKeywordRefinement)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchkeywordrefinement</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SearchKeywordRefinement instead.")]
        public static readonly AnalyticsDimension SearchKeywordRefinement = Dimensions.AnalyticsDimensions.SearchKeywordRefinement;

        /// <summary>
        /// Gets the categories used for the internal search if you have this enabled for your profile. For example, you might have product categories such as electronics, furniture, or clothing (id: <code>ga:searchCategory)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchcategory</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SearchCategory instead.")]
        public static readonly AnalyticsDimension SearchCategory = Dimensions.AnalyticsDimensions.SearchCategory;

        /// <summary>
        /// A page where the user initiated an internal search (id: <code>ga:searchStartPage)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchstartpage</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SearchStartPage instead.")]
        public static readonly AnalyticsDimension SearchStartPage = Dimensions.AnalyticsDimensions.SearchStartPage;

        /// <summary>
        /// Gets the page the user immediately visited after performing an internal search on your site. (Usually the search results page) (id: <code>ga:searchDestinationPage)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchdestinationpage</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SearchDestinationPage instead.")]
        public static readonly AnalyticsDimension SearchDestinationPage = Dimensions.AnalyticsDimensions.SearchDestinationPage;

        /// <summary>
        /// A page that the user visited after performing an internal search on your site (id: <code>ga:searchAfterDestinationPage)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchafterdestinationpage</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SearchAfterDestinationPage instead.")]
        public static readonly AnalyticsDimension SearchAfterDestinationPage = Dimensions.AnalyticsDimensions.SearchAfterDestinationPage;

        #endregion

        #region App Tracking

        /// <summary>
        /// ID of the installer (e.g., Google Play Store) from which the app was downloaded. By default, the app installer id is set based on the PackageManager#getInstallerPackageName method (id: <code>ga:appInstallerId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_appinstallerid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AppInstallerId instead.")]
        public static readonly AnalyticsDimension AppInstallerId = Dimensions.AnalyticsDimensions.AppInstallerId;

        /// <summary>
        /// Gets the version of the application (id: <code>ga:appVersion)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_appversion</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AppVersion instead.")]
        public static readonly AnalyticsDimension AppVersion = Dimensions.AnalyticsDimensions.AppVersion;

        /// <summary>
        /// Gets the name of the application (id: <code>ga:appName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_appname</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AppName instead.")]
        public static readonly AnalyticsDimension AppName = Dimensions.AnalyticsDimensions.AppName;

        /// <summary>
        /// Gets the ID of the application (id: <code>ga:appId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_appid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.AppId instead.")]
        public static readonly AnalyticsDimension AppId = Dimensions.AnalyticsDimensions.AppId;

        /// <summary>
        /// Gets the name of the screen (id: <code>ga:screenName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_screenname</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ScreenName instead.")]
        public static readonly AnalyticsDimension ScreenName = Dimensions.AnalyticsDimensions.ScreenName;

        /// <summary>
        /// Gets the number of screenviews per session reported as a string. Can be useful for historgrams (id: <code>ga:screenDepth)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_screendepth</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ScreenDepth instead.")]
        public static readonly AnalyticsDimension ScreenDepth = Dimensions.AnalyticsDimensions.ScreenDepth;

        /// <summary>
        /// Gets the name of the first screen viewed (id: <code>ga:landingScreenName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_landingscreenname</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.LandingScreenName instead.")]
        public static readonly AnalyticsDimension LandingScreenName = Dimensions.AnalyticsDimensions.LandingScreenName;

        /// <summary>
        /// Gets the name of the screen when the user exited the application (id: <code>ga:exitScreenName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_exitscreenname</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ExitScreenName instead.")]
        public static readonly AnalyticsDimension ExitScreenName = Dimensions.AnalyticsDimensions.ExitScreenName;

        #endregion

        #region Event Tracking

        /// <summary>
        /// Gets the category of the event (id: <code>ga:eventCategory)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_eventcategory</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.EventCategory instead.")]
        public static readonly AnalyticsDimension EventCategory = Dimensions.AnalyticsDimensions.EventCategory;

        /// <summary>
        /// Gets the action of the event (id: <code>ga:eventAction)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_eventaction</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.EventAction instead.")]
        public static readonly AnalyticsDimension EventAction = Dimensions.AnalyticsDimensions.EventAction;

        /// <summary>
        /// Gets the label of the event (id: <code>ga:eventLabel)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_eventlabel</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.EventLabel instead.")]
        public static readonly AnalyticsDimension EventLabel = Dimensions.AnalyticsDimensions.EventLabel;

        #endregion

        #region Ecommerce

        /// <summary>
        /// Gets the transaction ID for the shopping cart purchase as supplied by your ecommerce tracking method (id: <code>ga:transactionId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactionid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.TransactionId instead.")]
        public static readonly AnalyticsDimension TransactionId = Dimensions.AnalyticsDimensions.TransactionId;

        /// <summary>
        /// Typically used to designate a supplying company or brick and mortar location; product affiliation (id: <code>ga:affiliation)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_affiliation</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Affiliation instead.")]
        public static readonly AnalyticsDimension Affiliation = Dimensions.AnalyticsDimensions.Affiliation;

        /// <summary>
        /// Gets the number of sessions between users' purchases and the related campaigns that lead to the purchases (id: <code>ga:sessionsToTransaction)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_sessionstotransaction</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SessionsToTransaction instead.")]
        public static readonly AnalyticsDimension SessionsToTransaction = Dimensions.AnalyticsDimensions.SessionsToTransaction;

        /// <summary>
        /// Gets the number of sessions between users' purchases and the related campaigns that lead to the purchases (id: <code>ga:visitsToTransaction)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_visitstotransaction</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.VisitsToTransaction instead.")]
        public static readonly AnalyticsDimension VisitsToTransaction = Dimensions.AnalyticsDimensions.VisitsToTransaction;

        /// <summary>
        /// Gets the number of days between users' purchases and the related campaigns that lead to the purchases (id: <code>ga:daysToTransaction)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_daystotransaction</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DaysToTransaction instead.")]
        public static readonly AnalyticsDimension DaysToTransaction = Dimensions.AnalyticsDimensions.DaysToTransaction;

        /// <summary>
        /// Gets the product sku for purchased items as you have defined them in your ecommerce tracking application (id: <code>ga:productSku)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productsku</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ProductSku instead.")]
        public static readonly AnalyticsDimension ProductSku = Dimensions.AnalyticsDimensions.ProductSku;

        /// <summary>
        /// Gets the product name for purchased items as supplied by your ecommerce tracking application (id: <code>ga:productName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productname</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ProductName instead.")]
        public static readonly AnalyticsDimension ProductName = Dimensions.AnalyticsDimensions.ProductName;

        /// <summary>
        /// Any product variations (size, color) for purchased items as supplied by your ecommerce application. Not compatible with Enhanced Ecommerce (id: <code>ga:productCategory)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productcategory</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ProductCategory instead.")]
        public static readonly AnalyticsDimension ProductCategory = Dimensions.AnalyticsDimensions.ProductCategory;

        /// <summary>
        /// Gets the local currency code of the transaction based on ISO 4217 standard (id: <code>ga:currencyCode)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_currencycode</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.CurrencyCode instead.")]
        public static readonly AnalyticsDimension CurrencyCode = Dimensions.AnalyticsDimensions.CurrencyCode;

        /// <summary>
        /// User options specified during the checkout process, e.g., FedEx, DHL, UPS for delivery options or Visa, MasterCard, AmEx for payment options. This dimension should be used along with <code>ga:shoppingStage</code> (Enhanced Ecommerce) (id: <code>ga:checkoutOptions)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_checkoutoptions</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.CheckoutOptions instead.")]
        public static readonly AnalyticsDimension CheckoutOptions = Dimensions.AnalyticsDimensions.CheckoutOptions;

        /// <summary>
        /// Gets the creative content designed for a promotion (Enhanced Ecommerce) (id: <code>ga:internalPromotionCreative)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_internalpromotioncreative</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.InternalPromotionCreative instead.")]
        public static readonly AnalyticsDimension InternalPromotionCreative = Dimensions.AnalyticsDimensions.InternalPromotionCreative;

        /// <summary>
        /// Gets the ID of the promotion (Enhanced Ecommerce) (id: <code>ga:internalPromotionId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_internalpromotionid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.InternalPromotionId instead.")]
        public static readonly AnalyticsDimension InternalPromotionId = Dimensions.AnalyticsDimensions.InternalPromotionId;

        /// <summary>
        /// Gets the name of the promotion (Enhanced Ecommerce) (id: <code>ga:internalPromotionName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_internalpromotionname</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.InternalPromotionName instead.")]
        public static readonly AnalyticsDimension InternalPromotionName = Dimensions.AnalyticsDimensions.InternalPromotionName;

        /// <summary>
        /// Gets the position of the promotion on the web page or application screen (Enhanced Ecommerce) (id: <code>ga:internalPromotionPosition)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_internalpromotionposition</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.InternalPromotionPosition instead.")]
        public static readonly AnalyticsDimension InternalPromotionPosition = Dimensions.AnalyticsDimensions.InternalPromotionPosition;

        /// <summary>
        /// Code for the order-level coupon (Enhanced Ecommerce) (id: <code>ga:orderCouponCode)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_ordercouponcode</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.OrderCouponCode instead.")]
        public static readonly AnalyticsDimension OrderCouponCode = Dimensions.AnalyticsDimensions.OrderCouponCode;

        /// <summary>
        /// Gets the brand name under which the product is sold (Enhanced Ecommerce) (id: <code>ga:productBrand)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productbrand</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ProductBrand instead.")]
        public static readonly AnalyticsDimension ProductBrand = Dimensions.AnalyticsDimensions.ProductBrand;

        /// <summary>
        /// Gets the hierarchical category in which the product is classified (Enhanced Ecommerce) (id: <code>ga:productCategoryHierarchy)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productcategoryhierarchy</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ProductCategoryHierarchy instead.")]
        public static readonly AnalyticsDimension ProductCategoryHierarchy = Dimensions.AnalyticsDimensions.ProductCategoryHierarchy;

        /// <summary>
        /// Level (1-5) in the product category hierarchy, starting from the top (Enhanced Ecommerce) (id: <code>ga:productCategoryLevelXX)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productcategorylevelxx</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ProductCategoryLevelXX instead.")]
        public static readonly AnalyticsDimension ProductCategoryLevelXX = Dimensions.AnalyticsDimensions.ProductCategoryLevelXX;

        /// <summary>
        /// Code for the product-level coupon (Enhanced Ecommerce) (id: <code>ga:productCouponCode)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productcouponcode</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ProductCouponCode instead.")]
        public static readonly AnalyticsDimension ProductCouponCode = Dimensions.AnalyticsDimensions.ProductCouponCode;

        /// <summary>
        /// Gets the name of the product list in which the product appears (Enhanced Ecommerce) (id: <code>ga:productListName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productlistname</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ProductListName instead.")]
        public static readonly AnalyticsDimension ProductListName = Dimensions.AnalyticsDimensions.ProductListName;

        /// <summary>
        /// Gets the position of the product in the product list (Enhanced Ecommerce) (id: <code>ga:productListPosition)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productlistposition</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ProductListPosition instead.")]
        public static readonly AnalyticsDimension ProductListPosition = Dimensions.AnalyticsDimensions.ProductListPosition;

        /// <summary>
        /// Gets the specific variation of a product, e.g., XS, S, M, L for size or Red, Blue, Green, Black for color (Enhanced Ecommerce) (id: <code>ga:productVariant)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productvariant</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ProductVariant instead.")]
        public static readonly AnalyticsDimension ProductVariant = Dimensions.AnalyticsDimensions.ProductVariant;

        /// <summary>
        /// Various stages of the shopping experience that users completed in a session, e.g., PRODUCT_VIEW, ADD_TO_CART, CHECKOUT, etc. (Enhanced Ecommerce) (id: <code>ga:shoppingStage)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_shoppingstage</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ShoppingStage instead.")]
        public static readonly AnalyticsDimension ShoppingStage = Dimensions.AnalyticsDimensions.ShoppingStage;

        #endregion

        #region Social Interactions

        /// <summary>
        /// For social interactions, a value representing the social network being tracked (id: <code>ga:socialInteractionNetwork)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_interactions&amp;jump=ga_socialinteractionnetwork</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SocialInteractionNetwork instead.")]
        public static readonly AnalyticsDimension SocialInteractionNetwork = Dimensions.AnalyticsDimensions.SocialInteractionNetwork;

        /// <summary>
        /// For social interactions, a value representing the social action being tracked (e.g. +1, bookmark) (id: <code>ga:socialInteractionAction)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_interactions&amp;jump=ga_socialinteractionaction</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SocialInteractionAction instead.")]
        public static readonly AnalyticsDimension SocialInteractionAction = Dimensions.AnalyticsDimensions.SocialInteractionAction;

        /// <summary>
        /// For social interactions, a value representing the concatenation of the socialInteractionNetwork and socialInteractionAction action being tracked at this hit level (e.g. Google: +1) (id: <code>ga:socialInteractionNetworkAction)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_interactions&amp;jump=ga_socialinteractionnetworkaction</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SocialInteractionNetworkAction instead.")]
        public static readonly AnalyticsDimension SocialInteractionNetworkAction = Dimensions.AnalyticsDimensions.SocialInteractionNetworkAction;

        /// <summary>
        /// For social interactions, a value representing the URL (or resource) which receives the social network action (id: <code>ga:socialInteractionTarget)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_interactions&amp;jump=ga_socialinteractiontarget</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SocialInteractionTarget instead.")]
        public static readonly AnalyticsDimension SocialInteractionTarget = Dimensions.AnalyticsDimensions.SocialInteractionTarget;

        /// <summary>
        /// Engagement type. Possible values are "Socially Engaged" or "Not Socially Engaged" (id: <code>ga:socialEngagementType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_interactions&amp;jump=ga_socialengagementtype</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.SocialEngagementType instead.")]
        public static readonly AnalyticsDimension SocialEngagementType = Dimensions.AnalyticsDimensions.SocialEngagementType;

        #endregion

        #region User Timings

        /// <summary>
        /// A string for categorizing all user timing variables into logical groups for easier reporting purposes (id: <code>ga:userTimingCategory)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user_timings&amp;jump=ga_usertimingcategory</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.UserTimingCategory instead.")]
        public static readonly AnalyticsDimension UserTimingCategory = Dimensions.AnalyticsDimensions.UserTimingCategory;

        /// <summary>
        /// Gets the name of the resource's action being tracked (id: <code>ga:userTimingLabel)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user_timings&amp;jump=ga_usertiminglabel</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.UserTimingLabel instead.")]
        public static readonly AnalyticsDimension UserTimingLabel = Dimensions.AnalyticsDimensions.UserTimingLabel;

        /// <summary>
        /// A value that can be used to add flexibility in visualizing user timings in the reports (id: <code>ga:userTimingVariable)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user_timings&amp;jump=ga_usertimingvariable</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.UserTimingVariable instead.")]
        public static readonly AnalyticsDimension UserTimingVariable = Dimensions.AnalyticsDimensions.UserTimingVariable;

        #endregion

        #region Exceptions

        /// <summary>
        /// Gets the description for the exception (id: <code>ga:exceptionDescription)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=exceptions&amp;jump=ga_exceptiondescription</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ExceptionDescription instead.")]
        public static readonly AnalyticsDimension ExceptionDescription = Dimensions.AnalyticsDimensions.ExceptionDescription;

        #endregion

        #region Content Experiments

        /// <summary>
        /// Gets the user-scoped id of the content experiment that the user was exposed to when the metrics were reported (id: <code>ga:experimentId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=content_experiments&amp;jump=ga_experimentid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ExperimentId instead.")]
        public static readonly AnalyticsDimension ExperimentId = Dimensions.AnalyticsDimensions.ExperimentId;

        /// <summary>
        /// Gets the user-scoped id of the particular variation that the user was exposed to during a content experiment (id: <code>ga:experimentVariant)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=content_experiments&amp;jump=ga_experimentvariant</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ExperimentVariant instead.")]
        public static readonly AnalyticsDimension ExperimentVariant = Dimensions.AnalyticsDimensions.ExperimentVariant;

        #endregion

        #region Custom Variables or Columns

        /// <summary>
        /// Gets the name of the requested custom dimension, where XX refers the number/index of the custom dimension (id: <code>ga:dimensionXX)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=custom_variables_or_columns&amp;jump=ga_dimensionxx</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DimensionXX instead.")]
        public static readonly AnalyticsDimension DimensionXX = Dimensions.AnalyticsDimensions.DimensionXX;

        /// <summary>
        /// Gets the name for the requested custom variable (id: <code>ga:customVarNameXX)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=custom_variables_or_columns&amp;jump=ga_customvarnamexx</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.CustomVarNameXX instead.")]
        public static readonly AnalyticsDimension CustomVarNameXX = Dimensions.AnalyticsDimensions.CustomVarNameXX;

        /// <summary>
        /// Gets the value for the requested custom variable (id: <code>ga:customVarValueXX)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=custom_variables_or_columns&amp;jump=ga_customvarvaluexx</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.CustomVarValueXX instead.")]
        public static readonly AnalyticsDimension CustomVarValueXX = Dimensions.AnalyticsDimensions.CustomVarValueXX;

        #endregion

        #region Time

        /// <summary>
        /// Gets the date of the session formatted as YYYYMMDD (id: <code>ga:date)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_date</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Date instead.")]
        public static readonly AnalyticsDimension Date = Dimensions.AnalyticsDimensions.Date;

        /// <summary>
        /// Gets the year of the session. A four-digit year from 2005 to the current year (id: <code>ga:year)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_year</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Year instead.")]
        public static readonly AnalyticsDimension Year = Dimensions.AnalyticsDimensions.Year;

        /// <summary>
        /// Gets the month of the session. A two digit integer from 01 to 12 (id: <code>ga:month)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_month</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Month instead.")]
        public static readonly AnalyticsDimension Month = Dimensions.AnalyticsDimensions.Month;

        /// <summary>
        /// Gets the week of the session. A two-digit number from 01 to 53. Each week starts on Sunday (id: <code>ga:week)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_week</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Week instead.")]
        public static readonly AnalyticsDimension Week = Dimensions.AnalyticsDimensions.Week;

        /// <summary>
        /// Gets the day of the month. A two-digit number from 01 to 31 (id: <code>ga:day)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_day</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Day instead.")]
        public static readonly AnalyticsDimension Day = Dimensions.AnalyticsDimensions.Day;

        /// <summary>
        /// A two-digit hour of the day ranging from 00-23 in the timezone configured for the account. This value is also corrected for daylight savings time, adhering to all local rules for daylight savings time. If your timezone follows daylight savings time, there will be an apparent bump in the number of sessions during the change-over hour (e.g. between 1:00 and 2:00) for the day per year when that hour repeats. A corresponding hour with zero sessions will occur at the opposite changeover. (Google Analytics does not track user time more precisely than hours.) (id: <code>ga:hour)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_hour</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Hour instead.")]
        public static readonly AnalyticsDimension Hour = Dimensions.AnalyticsDimensions.Hour;

        /// <summary>
        /// Returns the minute in the hour. The possible values are between 00 and 59 (id: <code>ga:minute)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_minute</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.Minute instead.")]
        public static readonly AnalyticsDimension Minute = Dimensions.AnalyticsDimensions.Minute;

        /// <summary>
        /// Index for each month in the specified date range. Index for the first month in the date range is 0, 1 for the second month, and so on. The index corresponds to month entries (id: <code>ga:nthMonth)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_nthmonth</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.NthMonth instead.")]
        public static readonly AnalyticsDimension NthMonth = Dimensions.AnalyticsDimensions.NthMonth;

        /// <summary>
        /// Index for each week in the specified date range. Index for the first week in the date range is 0, 1 for the second week, and so on. The index corresponds to week entries (id: <code>ga:nthWeek)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_nthweek</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.NthWeek instead.")]
        public static readonly AnalyticsDimension NthWeek = Dimensions.AnalyticsDimensions.NthWeek;

        /// <summary>
        /// Index for each day in the specified date range. Index for the first day (i.e., start-date) in the date range is 0, 1 for the second day, and so on (id: <code>ga:nthDay)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_nthday</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.NthDay instead.")]
        public static readonly AnalyticsDimension NthDay = Dimensions.AnalyticsDimensions.NthDay;

        /// <summary>
        /// Index for each minute in the specified date range. Index for the first minute of first day (i.e., start-date) in the date range is 0, 1 for the next minute, and so on (id: <code>ga:nthMinute)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_nthminute</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.NthMinute instead.")]
        public static readonly AnalyticsDimension NthMinute = Dimensions.AnalyticsDimensions.NthMinute;

        /// <summary>
        /// Gets the day of the week. A one-digit number from 0 (Sunday) to 6 (Saturday) (id: <code>ga:dayOfWeek)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_dayofweek</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DayOfWeek instead.")]
        public static readonly AnalyticsDimension DayOfWeek = Dimensions.AnalyticsDimensions.DayOfWeek;

        /// <summary>
        /// Gets the name of the day of the week (in English) (id: <code>ga:dayOfWeekName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_dayofweekname</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DayOfWeekName instead.")]
        public static readonly AnalyticsDimension DayOfWeekName = Dimensions.AnalyticsDimensions.DayOfWeekName;

        /// <summary>
        /// Combined values of <code>ga:date</code> and <code>ga:hour</code> (id: <code>ga:dateHour)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_datehour</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DateHour instead.")]
        public static readonly AnalyticsDimension DateHour = Dimensions.AnalyticsDimensions.DateHour;

        /// <summary>
        /// Combined values of <code>ga:year</code> and <code>ga:month</code> (id: <code>ga:yearMonth)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_yearmonth</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.YearMonth instead.")]
        public static readonly AnalyticsDimension YearMonth = Dimensions.AnalyticsDimensions.YearMonth;

        /// <summary>
        /// Combined values of <code>ga:year</code> and <code>ga:week</code> (id: <code>ga:yearWeek)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_yearweek</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.YearWeek instead.")]
        public static readonly AnalyticsDimension YearWeek = Dimensions.AnalyticsDimensions.YearWeek;

        /// <summary>
        /// Gets the ISO week number, where each week starts with a Monday. Details: http://en.wikipedia.org/wiki/ISO_week_date. <code>ga:isoWeek</code> should only be used with <code>ga:isoYear</code> since <code>ga:year</code> represents gregorian calendar (id: <code>ga:isoWeek)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_isoweek</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.IsoWeek instead.")]
        public static readonly AnalyticsDimension IsoWeek = Dimensions.AnalyticsDimensions.IsoWeek;

        /// <summary>
        /// Gets the ISO year of the session. Details: http://en.wikipedia.org/wiki/ISO_week_date. <code>ga:isoYear</code> should only be used with <code>ga:isoWeek</code> since <code>ga:week</code> represents gregorian calendar (id: <code>ga:isoYear)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_isoyear</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.IsoYear instead.")]
        public static readonly AnalyticsDimension IsoYear = Dimensions.AnalyticsDimensions.IsoYear;

        /// <summary>
        /// Combined values of <code>ga:isoYear</code> and <code>ga:isoWeek</code> (id: <code>ga:isoYearIsoWeek)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_isoyearisoweek</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.IsoYearIsoWeek instead.")]
        public static readonly AnalyticsDimension IsoYearIsoWeek = Dimensions.AnalyticsDimensions.IsoYearIsoWeek;

        /// <summary>
        /// Index for each hour in the specified date range. Index for the first hour of first day (i.e., start-date) in the date range is 0, 1 for the next hour, and so on (id: <code>ga:nthHour)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=time&amp;jump=ga_nthhour</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.NthHour instead.")]
        public static readonly AnalyticsDimension NthHour = Dimensions.AnalyticsDimensions.NthHour;

        #endregion

        #region DoubleClick Campaign Manager

        /// <summary>
        /// DCM ad name of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickAd)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickad</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmClickAd instead.")]
        public static readonly AnalyticsDimension DcmClickAd = Dimensions.AnalyticsDimensions.DcmClickAd;

        /// <summary>
        /// DCM ad ID of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickAdId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickadid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmClickAdId instead.")]
        public static readonly AnalyticsDimension DcmClickAdId = Dimensions.AnalyticsDimensions.DcmClickAdId;

        /// <summary>
        /// DCM ad type name of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickAdType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickadtype</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmClickAdType instead.")]
        public static readonly AnalyticsDimension DcmClickAdType = Dimensions.AnalyticsDimensions.DcmClickAdType;

        /// <summary>
        /// DCM ad type ID of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickAdTypeId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickadtypeid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmClickAdTypeId instead.")]
        public static readonly AnalyticsDimension DcmClickAdTypeId = Dimensions.AnalyticsDimensions.DcmClickAdTypeId;

        /// <summary>
        /// DCM advertiser name of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickAdvertiser)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickadvertiser</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmClickAdvertiser instead.")]
        public static readonly AnalyticsDimension DcmClickAdvertiser = Dimensions.AnalyticsDimensions.DcmClickAdvertiser;

        /// <summary>
        /// DCM advertiser ID of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickAdvertiserId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickadvertiserid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmClickAdvertiserId instead.")]
        public static readonly AnalyticsDimension DcmClickAdvertiserId = Dimensions.AnalyticsDimensions.DcmClickAdvertiserId;

        /// <summary>
        /// DCM campaign name of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickCampaign)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickcampaign</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmClickCampaign instead.")]
        public static readonly AnalyticsDimension DcmClickCampaign = Dimensions.AnalyticsDimensions.DcmClickCampaign;

        /// <summary>
        /// DCM campaign ID of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickCampaignId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickcampaignid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmClickCampaignId instead.")]
        public static readonly AnalyticsDimension DcmClickCampaignId = Dimensions.AnalyticsDimensions.DcmClickCampaignId;

        /// <summary>
        /// DCM creative ID of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickCreativeId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickcreativeid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmClickCreativeId instead.")]
        public static readonly AnalyticsDimension DcmClickCreativeId = Dimensions.AnalyticsDimensions.DcmClickCreativeId;

        /// <summary>
        /// DCM creative name of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickCreative)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickcreative</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmClickCreative instead.")]
        public static readonly AnalyticsDimension DcmClickCreative = Dimensions.AnalyticsDimensions.DcmClickCreative;

        /// <summary>
        /// DCM rendering ID of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickRenderingId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickrenderingid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmClickRenderingId instead.")]
        public static readonly AnalyticsDimension DcmClickRenderingId = Dimensions.AnalyticsDimensions.DcmClickRenderingId;

        /// <summary>
        /// DCM creative type name of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickCreativeType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickcreativetype</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmClickCreativeType instead.")]
        public static readonly AnalyticsDimension DcmClickCreativeType = Dimensions.AnalyticsDimensions.DcmClickCreativeType;

        /// <summary>
        /// DCM creative type ID of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickCreativeTypeId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickcreativetypeid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmClickCreativeTypeId instead.")]
        public static readonly AnalyticsDimension DcmClickCreativeTypeId = Dimensions.AnalyticsDimensions.DcmClickCreativeTypeId;

        /// <summary>
        /// DCM creative version of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickCreativeVersion)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickcreativeversion</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmClickCreativeVersion instead.")]
        public static readonly AnalyticsDimension DcmClickCreativeVersion = Dimensions.AnalyticsDimensions.DcmClickCreativeVersion;

        /// <summary>
        /// Site name where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickSite)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclicksite</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmClickSite instead.")]
        public static readonly AnalyticsDimension DcmClickSite = Dimensions.AnalyticsDimensions.DcmClickSite;

        /// <summary>
        /// DCM site ID where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickSiteId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclicksiteid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmClickSiteId instead.")]
        public static readonly AnalyticsDimension DcmClickSiteId = Dimensions.AnalyticsDimensions.DcmClickSiteId;

        /// <summary>
        /// DCM site placement name of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickSitePlacement)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclicksiteplacement</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmClickSitePlacement instead.")]
        public static readonly AnalyticsDimension DcmClickSitePlacement = Dimensions.AnalyticsDimensions.DcmClickSitePlacement;

        /// <summary>
        /// DCM site placement ID of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickSitePlacementId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclicksiteplacementid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmClickSitePlacementId instead.")]
        public static readonly AnalyticsDimension DcmClickSitePlacementId = Dimensions.AnalyticsDimensions.DcmClickSitePlacementId;

        /// <summary>
        /// DCM Floodlight configuration ID of the DCM click matching the Google Analytics session (premium only) (id: <code>ga:dcmClickSpotId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclickspotid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmClickSpotId instead.")]
        public static readonly AnalyticsDimension DcmClickSpotId = Dimensions.AnalyticsDimensions.DcmClickSpotId;

        /// <summary>
        /// DCM Floodlight activity name associated with the floodlight conversion (premium only) (id: <code>ga:dcmFloodlightActivity)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmfloodlightactivity</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmFloodlightActivity instead.")]
        public static readonly AnalyticsDimension DcmFloodlightActivity = Dimensions.AnalyticsDimensions.DcmFloodlightActivity;

        /// <summary>
        /// DCM Floodlight activity name and group name associated with the floodlight conversion (premium only) (id: <code>ga:dcmFloodlightActivityAndGroup)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmfloodlightactivityandgroup</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmFloodlightActivityAndGroup instead.")]
        public static readonly AnalyticsDimension DcmFloodlightActivityAndGroup = Dimensions.AnalyticsDimensions.DcmFloodlightActivityAndGroup;

        /// <summary>
        /// DCM Floodlight activity group name associated with the floodlight conversion (premium only) (id: <code>ga:dcmFloodlightActivityGroup)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmfloodlightactivitygroup</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmFloodlightActivityGroup instead.")]
        public static readonly AnalyticsDimension DcmFloodlightActivityGroup = Dimensions.AnalyticsDimensions.DcmFloodlightActivityGroup;

        /// <summary>
        /// DCM Floodlight activity group ID associated with the floodlight conversion (premium only) (id: <code>ga:dcmFloodlightActivityGroupId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmfloodlightactivitygroupid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmFloodlightActivityGroupId instead.")]
        public static readonly AnalyticsDimension DcmFloodlightActivityGroupId = Dimensions.AnalyticsDimensions.DcmFloodlightActivityGroupId;

        /// <summary>
        /// DCM Floodlight activity ID associated with the floodlight conversion (premium only) (id: <code>ga:dcmFloodlightActivityId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmfloodlightactivityid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmFloodlightActivityId instead.")]
        public static readonly AnalyticsDimension DcmFloodlightActivityId = Dimensions.AnalyticsDimensions.DcmFloodlightActivityId;

        /// <summary>
        /// DCM Floodlight advertiser ID associated with the floodlight conversion (premium only) (id: <code>ga:dcmFloodlightAdvertiserId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmfloodlightadvertiserid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmFloodlightAdvertiserId instead.")]
        public static readonly AnalyticsDimension DcmFloodlightAdvertiserId = Dimensions.AnalyticsDimensions.DcmFloodlightAdvertiserId;

        /// <summary>
        /// DCM Floodlight configuration ID associated with the floodlight conversion (premium only) (id: <code>ga:dcmFloodlightSpotId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmfloodlightspotid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmFloodlightSpotId instead.")]
        public static readonly AnalyticsDimension DcmFloodlightSpotId = Dimensions.AnalyticsDimensions.DcmFloodlightSpotId;

        /// <summary>
        /// DCM ad name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventAd)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventad</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventAd instead.")]
        public static readonly AnalyticsDimension DcmLastEventAd = Dimensions.AnalyticsDimensions.DcmLastEventAd;

        /// <summary>
        /// DCM ad ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventAdId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventadid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventAdId instead.")]
        public static readonly AnalyticsDimension DcmLastEventAdId = Dimensions.AnalyticsDimensions.DcmLastEventAdId;

        /// <summary>
        /// DCM ad type name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventAdType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventadtype</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventAdType instead.")]
        public static readonly AnalyticsDimension DcmLastEventAdType = Dimensions.AnalyticsDimensions.DcmLastEventAdType;

        /// <summary>
        /// DCM ad type ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventAdTypeId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventadtypeid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventAdTypeId instead.")]
        public static readonly AnalyticsDimension DcmLastEventAdTypeId = Dimensions.AnalyticsDimensions.DcmLastEventAdTypeId;

        /// <summary>
        /// DCM advertiser name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventAdvertiser)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventadvertiser</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventAdvertiser instead.")]
        public static readonly AnalyticsDimension DcmLastEventAdvertiser = Dimensions.AnalyticsDimensions.DcmLastEventAdvertiser;

        /// <summary>
        /// DCM advertiser ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventAdvertiserId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventadvertiserid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventAdvertiserId instead.")]
        public static readonly AnalyticsDimension DcmLastEventAdvertiserId = Dimensions.AnalyticsDimensions.DcmLastEventAdvertiserId;

        /// <summary>
        /// There are two possible values: ClickThrough and ViewThrough. If the last DCM event associated with the Google Analytics session was a click, then the value will be ClickThrough. If the last DCM event associated with the Google Analytics session was an ad impression, then the value will be ViewThrough (premium only) (id: <code>ga:dcmLastEventAttributionType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventattributiontype</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventAttributionType instead.")]
        public static readonly AnalyticsDimension DcmLastEventAttributionType = Dimensions.AnalyticsDimensions.DcmLastEventAttributionType;

        /// <summary>
        /// DCM campaign name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventCampaign)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventcampaign</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventCampaign instead.")]
        public static readonly AnalyticsDimension DcmLastEventCampaign = Dimensions.AnalyticsDimensions.DcmLastEventCampaign;

        /// <summary>
        /// DCM campaign ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventCampaignId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventcampaignid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventCampaignId instead.")]
        public static readonly AnalyticsDimension DcmLastEventCampaignId = Dimensions.AnalyticsDimensions.DcmLastEventCampaignId;

        /// <summary>
        /// DCM creative ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventCreativeId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventcreativeid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventCreativeId instead.")]
        public static readonly AnalyticsDimension DcmLastEventCreativeId = Dimensions.AnalyticsDimensions.DcmLastEventCreativeId;

        /// <summary>
        /// DCM creative name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventCreative)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventcreative</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventCreative instead.")]
        public static readonly AnalyticsDimension DcmLastEventCreative = Dimensions.AnalyticsDimensions.DcmLastEventCreative;

        /// <summary>
        /// DCM rendering ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventRenderingId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventrenderingid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventRenderingId instead.")]
        public static readonly AnalyticsDimension DcmLastEventRenderingId = Dimensions.AnalyticsDimensions.DcmLastEventRenderingId;

        /// <summary>
        /// DCM creative type name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventCreativeType)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventcreativetype</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventCreativeType instead.")]
        public static readonly AnalyticsDimension DcmLastEventCreativeType = Dimensions.AnalyticsDimensions.DcmLastEventCreativeType;

        /// <summary>
        /// DCM creative type ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventCreativeTypeId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventcreativetypeid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventCreativeTypeId instead.")]
        public static readonly AnalyticsDimension DcmLastEventCreativeTypeId = Dimensions.AnalyticsDimensions.DcmLastEventCreativeTypeId;

        /// <summary>
        /// DCM creative version of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventCreativeVersion)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventcreativeversion</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventCreativeVersion instead.")]
        public static readonly AnalyticsDimension DcmLastEventCreativeVersion = Dimensions.AnalyticsDimensions.DcmLastEventCreativeVersion;

        /// <summary>
        /// Site name where the DCM creative was shown and clicked on for the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventSite)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventsite</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventSite instead.")]
        public static readonly AnalyticsDimension DcmLastEventSite = Dimensions.AnalyticsDimensions.DcmLastEventSite;

        /// <summary>
        /// DCM site ID where the DCM creative was shown and clicked on for the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventSiteId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventsiteid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventSiteId instead.")]
        public static readonly AnalyticsDimension DcmLastEventSiteId = Dimensions.AnalyticsDimensions.DcmLastEventSiteId;

        /// <summary>
        /// DCM site placement name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventSitePlacement)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventsiteplacement</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventSitePlacement instead.")]
        public static readonly AnalyticsDimension DcmLastEventSitePlacement = Dimensions.AnalyticsDimensions.DcmLastEventSitePlacement;

        /// <summary>
        /// DCM site placement ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventSitePlacementId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventsiteplacementid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventSitePlacementId instead.")]
        public static readonly AnalyticsDimension DcmLastEventSitePlacementId = Dimensions.AnalyticsDimensions.DcmLastEventSitePlacementId;

        /// <summary>
        /// DCM Floodlight configuration ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only) (id: <code>ga:dcmLastEventSpotId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmlasteventspotid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.DcmLastEventSpotId instead.")]
        public static readonly AnalyticsDimension DcmLastEventSpotId = Dimensions.AnalyticsDimensions.DcmLastEventSpotId;

        #endregion

        #region Audience

        /// <summary>
        /// Age bracket of user (id: <code>ga:userAgeBracket)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=audience&amp;jump=ga_useragebracket</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.UserAgeBracket instead.")]
        public static readonly AnalyticsDimension UserAgeBracket = Dimensions.AnalyticsDimensions.UserAgeBracket;

        /// <summary>
        /// Age bracket of user (id: <code>ga:visitorAgeBracket)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=audience&amp;jump=ga_visitoragebracket</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.VisitorAgeBracket instead.")]
        public static readonly AnalyticsDimension VisitorAgeBracket = Dimensions.AnalyticsDimensions.VisitorAgeBracket;

        /// <summary>
        /// Gender of user (id: <code>ga:userGender)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=audience&amp;jump=ga_usergender</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.UserGender instead.")]
        public static readonly AnalyticsDimension UserGender = Dimensions.AnalyticsDimensions.UserGender;

        /// <summary>
        /// Gender of user (id: <code>ga:visitorGender)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=audience&amp;jump=ga_visitorgender</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.VisitorGender instead.")]
        public static readonly AnalyticsDimension VisitorGender = Dimensions.AnalyticsDimensions.VisitorGender;

        /// <summary>
        /// Indicates that users are more likely to be interested in learning about the specified category, and more likely to be ready to purchase (id: <code>ga:interestOtherCategory)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=audience&amp;jump=ga_interestothercategory</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.InterestOtherCategory instead.")]
        public static readonly AnalyticsDimension InterestOtherCategory = Dimensions.AnalyticsDimensions.InterestOtherCategory;

        /// <summary>
        /// Indicates that users are more likely to be interested in learning about the specified category (id: <code>ga:interestAffinityCategory)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=audience&amp;jump=ga_interestaffinitycategory</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.InterestAffinityCategory instead.")]
        public static readonly AnalyticsDimension InterestAffinityCategory = Dimensions.AnalyticsDimensions.InterestAffinityCategory;

        /// <summary>
        /// Indicates that users are more likely to be ready to purchase products or services in the specified category (id: <code>ga:interestInMarketCategory)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=audience&amp;jump=ga_interestinmarketcategory</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.InterestInMarketCategory instead.")]
        public static readonly AnalyticsDimension InterestInMarketCategory = Dimensions.AnalyticsDimensions.InterestInMarketCategory;

        #endregion

        #region Channel Grouping

        /// <summary>
        /// Gets the default channel grouping that is shared within the View (Profile) (id: <code>ga:channelGrouping)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=channel_grouping&amp;jump=ga_channelgrouping</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.ChannelGrouping instead.")]
        public static readonly AnalyticsDimension ChannelGrouping = Dimensions.AnalyticsDimensions.ChannelGrouping;

        #endregion

        #region Related Products

        /// <summary>
        /// Correlation Model ID for related products (id: <code>ga:correlationModelId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_correlationmodelid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.CorrelationModelId instead.")]
        public static readonly AnalyticsDimension CorrelationModelId = Dimensions.AnalyticsDimensions.CorrelationModelId;

        /// <summary>
        /// ID of the product being queried (id: <code>ga:queryProductId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_queryproductid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.QueryProductId instead.")]
        public static readonly AnalyticsDimension QueryProductId = Dimensions.AnalyticsDimensions.QueryProductId;

        /// <summary>
        /// Name of the product being queried (id: <code>ga:queryProductName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_queryproductname</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.QueryProductName instead.")]
        public static readonly AnalyticsDimension QueryProductName = Dimensions.AnalyticsDimensions.QueryProductName;

        /// <summary>
        /// Variation of the product being queried (id: <code>ga:queryProductVariation)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_queryproductvariation</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.QueryProductVariation instead.")]
        public static readonly AnalyticsDimension QueryProductVariation = Dimensions.AnalyticsDimensions.QueryProductVariation;

        /// <summary>
        /// ID of the related product (id: <code>ga:relatedProductId)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_relatedproductid</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.RelatedProductId instead.")]
        public static readonly AnalyticsDimension RelatedProductId = Dimensions.AnalyticsDimensions.RelatedProductId;

        /// <summary>
        /// Name of the related product (id: <code>ga:relatedProductName)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_relatedproductname</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.RelatedProductName instead.")]
        public static readonly AnalyticsDimension RelatedProductName = Dimensions.AnalyticsDimensions.RelatedProductName;

        /// <summary>
        /// Variation of the related product (id: <code>ga:relatedProductVariation)</code>, type: <code>string)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_relatedproductvariation</cref>
        /// </see>
        [Obsolete("Use AnalyticsDimensions.RelatedProductVariation instead.")]
        public static readonly AnalyticsDimension RelatedProductVariation = Dimensions.AnalyticsDimensions.RelatedProductVariation;

        #endregion

        // ReSharper restore InconsistentNaming
        
        #endregion

        #region Static properties

        public static AnalyticsDimension[] Values {
            get {
                return (
                    from property in typeof(AnalyticsDimension).GetFields(BindingFlags.Public | BindingFlags.Static)
                    select (AnalyticsDimension) property.GetValue(null)
                ).ToArray();
            }
        }

        #endregion

        #region Member properties

        /// <summary>
        /// Gets the name of the dimension.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the name of the group of the dimension.
        /// </summary>
        public string GroupName { get; private set; }

        /// <summary>
        /// Gets whether the dimension is obsolete/deprecated.
        /// </summary>
        public bool IsObsolete { get; private set; }

        #endregion

        #region Constructor

        internal AnalyticsDimension(string name) {
            Name = name;
        }

        internal AnalyticsDimension(string name, string groupName) {
            Name = name;
            GroupName = groupName;
        }

        internal AnalyticsDimension(string name, string groupName, bool obsolete) {
            Name = name;
            GroupName = groupName;
            IsObsolete = obsolete;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets the name of the dimension (eg. <code>ga:country</code>).
        /// </summary>
        public override string ToString() {
            return Name;
        }

        #endregion

        #region Static methods

        public static AnalyticsDimension Parse(string str) {
            AnalyticsDimension dimension;
            if (TryParse(str, out dimension)) return dimension;
            throw new Exception("Invalid dimension '" + str + "'");
        }

        public static bool TryParse(string str, out AnalyticsDimension dimension) {
            dimension = Values.FirstOrDefault(temp => temp.Name == str);
            return dimension != null;
        }

        #endregion

        #region Operator overloading

        public static implicit operator AnalyticsDimension(string name) {
            return Parse(name);
        }

        public static AnalyticsDimensionCollection operator +(AnalyticsDimension left, AnalyticsDimension right) {
            return new AnalyticsDimensionCollection(left, right);
        }

        #endregion

    }

}