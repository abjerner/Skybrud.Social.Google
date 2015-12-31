// This class is auto-generated based on metrics from the Google Analytics API. If you have suggestions for any
// changes, please create a new issue at https://github.com/abjerner/Skybrud.Social/issues/new

using System;
using System.Linq;
using System.Reflection;
using Skybrud.Social.Google.Analytics.Interfaces;

namespace Skybrud.Social.Google.Analytics.Objects {

    /// <summary>
    /// Class representing a metric in the Google Analytics API.
    /// </summary>
    public class AnalyticsMetric : IAnalyticsField {

        #region Readonly properties

        // ReSharper disable InconsistentNaming

        #region User

        /// <summary>
        /// Gets the total number of users for the requested time period (id: <code>ga:users)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_users</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.Users instead.")]
        public static readonly AnalyticsMetric Users = Metrics.AnalyticsMetrics.Users;

        /// <summary>
        /// Gets the total number of users for the requested time period (id: <code>ga:visitors)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_visitors</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.Visitors instead.")]
        public static readonly AnalyticsMetric Visitors = Metrics.AnalyticsMetrics.Visitors;

        /// <summary>
        /// Gets the number of users whose session was marked as a first-time session (id: <code>ga:newUsers)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_newusers</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.NewUsers instead.")]
        public static readonly AnalyticsMetric NewUsers = Metrics.AnalyticsMetrics.NewUsers;

        /// <summary>
        /// Gets the number of users whose session was marked as a first-time session (id: <code>ga:newVisits)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_newvisits</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.NewVisits instead.")]
        public static readonly AnalyticsMetric NewVisits = Metrics.AnalyticsMetrics.NewVisits;

        /// <summary>
        /// Gets the percentage of sessions by people who had never visited your property before (id: <code>ga:percentNewSessions)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_percentnewsessions</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.PercentNewSessions instead.")]
        public static readonly AnalyticsMetric PercentNewSessions = Metrics.AnalyticsMetrics.PercentNewSessions;

        /// <summary>
        /// Gets the percentage of sessions by people who had never visited your property before (id: <code>ga:percentNewVisits)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_percentnewvisits</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.PercentNewVisits instead.")]
        public static readonly AnalyticsMetric PercentNewVisits = Metrics.AnalyticsMetrics.PercentNewVisits;

        /// <summary>
        /// Gets the total number of 1-day active users for each day in the requested time period. At least one of <code>ga:nthDay</code>, <code>ga:date</code>, or <code>ga:day</code> must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 1 day period ending on the given date (id: <code>ga:1dayUsers)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_1dayusers</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.Day1Users instead.")]
        public static readonly AnalyticsMetric Day1Users = Metrics.AnalyticsMetrics.Day1Users;

        /// <summary>
        /// Gets the total number of 7-day active users for each day in the requested time period. At least one of <code>ga:nthDay</code>, <code>ga:date</code>, or <code>ga:day</code> must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 7 day period ending on the given date (id: <code>ga:7dayUsers)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_7dayusers</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.Day7Users instead.")]
        public static readonly AnalyticsMetric Day7Users = Metrics.AnalyticsMetrics.Day7Users;

        /// <summary>
        /// Gets the total number of 14-day active users for each day in the requested time period. At least one of <code>ga:nthDay</code>, <code>ga:date</code>, or <code>ga:day</code> must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 14 day period ending on the given date (id: <code>ga:14dayUsers)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_14dayusers</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.Day14Users instead.")]
        public static readonly AnalyticsMetric Day14Users = Metrics.AnalyticsMetrics.Day14Users;

        /// <summary>
        /// Gets the total number of 30-day active users for each day in the requested time period. At least one of <code>ga:nthDay</code>, <code>ga:date</code>, or <code>ga:day</code> must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 30 day period ending on the given date (id: <code>ga:30dayUsers)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_30dayusers</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.Day30Users instead.")]
        public static readonly AnalyticsMetric Day30Users = Metrics.AnalyticsMetrics.Day30Users;

        /// <summary>
        /// Gets the total number of sessions divided by the total number of users (id: <code>ga:sessionsPerUser)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_sessionsperuser</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.SessionsPerUser instead.")]
        public static readonly AnalyticsMetric SessionsPerUser = Metrics.AnalyticsMetrics.SessionsPerUser;

        #endregion

        #region Session

        /// <summary>
        /// Gets the total number of sessions (id: <code>ga:sessions)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_sessions</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.Sessions instead.")]
        public static readonly AnalyticsMetric Sessions = Metrics.AnalyticsMetrics.Sessions;

        /// <summary>
        /// Gets the total number of sessions (id: <code>ga:visits)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_visits</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.Visits instead.")]
        public static readonly AnalyticsMetric Visits = Metrics.AnalyticsMetrics.Visits;

        /// <summary>
        /// Gets the total number of single page (or single engagement hit) sessions for your property (id: <code>ga:bounces)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_bounces</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.Bounces instead.")]
        public static readonly AnalyticsMetric Bounces = Metrics.AnalyticsMetrics.Bounces;

        /// <summary>
        /// This dimension is deprecated and will be removed soon. Please use <code>ga:bounceRate</code> instead (id: <code>ga:entranceBounceRate)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_entrancebouncerate</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.EntranceBounceRate instead.")]
        public static readonly AnalyticsMetric EntranceBounceRate = Metrics.AnalyticsMetrics.EntranceBounceRate;

        /// <summary>
        /// Gets the percentage of single-page session (i.e., session in which the person left your property from the first page) (id: <code>ga:bounceRate)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_bouncerate</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.BounceRate instead.")]
        public static readonly AnalyticsMetric BounceRate = Metrics.AnalyticsMetrics.BounceRate;

        /// <summary>
        /// Gets the percentage of single-page session (i.e., session in which the person left your property from the first page) (id: <code>ga:visitBounceRate)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_visitbouncerate</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.VisitBounceRate instead.")]
        public static readonly AnalyticsMetric VisitBounceRate = Metrics.AnalyticsMetrics.VisitBounceRate;

        /// <summary>
        /// Gets the total duration of user sessions represented in total seconds (id: <code>ga:sessionDuration)</code>, type: <code>time)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_sessionduration</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.SessionDuration instead.")]
        public static readonly AnalyticsMetric SessionDuration = Metrics.AnalyticsMetrics.SessionDuration;

        /// <summary>
        /// Gets the total duration of user sessions represented in total seconds (id: <code>ga:timeOnSite)</code>, type: <code>time)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_timeonsite</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.TimeOnSite instead.")]
        public static readonly AnalyticsMetric TimeOnSite = Metrics.AnalyticsMetrics.TimeOnSite;

        /// <summary>
        /// Gets the average duration of user sessions represented in total seconds (id: <code>ga:avgSessionDuration)</code>, type: <code>time)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_avgsessionduration</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AvgSessionDuration instead.")]
        public static readonly AnalyticsMetric AvgSessionDuration = Metrics.AnalyticsMetrics.AvgSessionDuration;

        /// <summary>
        /// Gets the average duration of user sessions represented in total seconds (id: <code>ga:avgTimeOnSite)</code>, type: <code>time)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_avgtimeonsite</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AvgTimeOnSite instead.")]
        public static readonly AnalyticsMetric AvgTimeOnSite = Metrics.AnalyticsMetrics.AvgTimeOnSite;

        /// <summary>
        /// Gets the total number of hits sent to Google Analytics. This metric sums all hit types (e.g. pageview, event, timing, etc.) (id: <code>ga:hits)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_hits</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.Hits instead.")]
        public static readonly AnalyticsMetric Hits = Metrics.AnalyticsMetrics.Hits;

        #endregion

        #region Traffic Sources

        /// <summary>
        /// Gets the number of organic searches that happened within a session. This metric is search engine agnostic (id: <code>ga:organicSearches)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_organicsearches</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.OrganicSearches instead.")]
        public static readonly AnalyticsMetric OrganicSearches = Metrics.AnalyticsMetrics.OrganicSearches;

        #endregion

        #region Adwords

        /// <summary>
        /// Gets the total number of campaign impressions (id: <code>ga:impressions)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_impressions</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.Impressions instead.")]
        public static readonly AnalyticsMetric Impressions = Metrics.AnalyticsMetrics.Impressions;

        /// <summary>
        /// Gets the total number of times users have clicked on an ad to reach your property (id: <code>ga:adClicks)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adclicks</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdClicks instead.")]
        public static readonly AnalyticsMetric AdClicks = Metrics.AnalyticsMetrics.AdClicks;

        /// <summary>
        /// Derived cost for the advertising campaign. The currency for this value is based on the currency that you set in your AdWords account (id: <code>ga:adCost)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adcost</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdCost instead.")]
        public static readonly AnalyticsMetric AdCost = Metrics.AnalyticsMetrics.AdCost;

        /// <summary>
        /// Cost per thousand impressions (id: <code>ga:CPM)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_cpm</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.CPM instead.")]
        public static readonly AnalyticsMetric CPM = Metrics.AnalyticsMetrics.CPM;

        /// <summary>
        /// Cost to advertiser per click (id: <code>ga:CPC)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_cpc</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.CPC instead.")]
        public static readonly AnalyticsMetric CPC = Metrics.AnalyticsMetrics.CPC;

        /// <summary>
        /// Click-through-rate for your ad. This is equal to the number of clicks divided by the number of impressions for your ad (e.g. how many times users clicked on one of your ads where that ad appeared) (id: <code>ga:CTR)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_ctr</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.CTR instead.")]
        public static readonly AnalyticsMetric CTR = Metrics.AnalyticsMetrics.CTR;

        /// <summary>
        /// Gets the cost per transaction for your property (id: <code>ga:costPerTransaction)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_costpertransaction</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.CostPerTransaction instead.")]
        public static readonly AnalyticsMetric CostPerTransaction = Metrics.AnalyticsMetrics.CostPerTransaction;

        /// <summary>
        /// Gets the cost per goal conversion for your property (id: <code>ga:costPerGoalConversion)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_costpergoalconversion</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.CostPerGoalConversion instead.")]
        public static readonly AnalyticsMetric CostPerGoalConversion = Metrics.AnalyticsMetrics.CostPerGoalConversion;

        /// <summary>
        /// Gets the cost per conversion (including ecommerce and goal conversions) for your property (id: <code>ga:costPerConversion)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_costperconversion</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.CostPerConversion instead.")]
        public static readonly AnalyticsMetric CostPerConversion = Metrics.AnalyticsMetrics.CostPerConversion;

        /// <summary>
        /// RPC or revenue-per-click is the average revenue (from ecommerce sales and/or goal value) you received for each click on one of your search ads (id: <code>ga:RPC)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_rpc</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.RPC instead.")]
        public static readonly AnalyticsMetric RPC = Metrics.AnalyticsMetrics.RPC;

        /// <summary>
        /// This metric is deprecated and will be removed soon. Please use <code>ga:ROAS</code> instead (id: <code>ga:ROI)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_roi</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ROI instead.")]
        public static readonly AnalyticsMetric ROI = Metrics.AnalyticsMetrics.ROI;

        /// <summary>
        /// This metric is deprecated and will be removed soon. Please use <code>ga:ROAS</code> instead (id: <code>ga:margin)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_margin</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.Margin instead.")]
        public static readonly AnalyticsMetric Margin = Metrics.AnalyticsMetrics.Margin;

        /// <summary>
        /// Return On Ad Spend (ROAS) is the total transaction revenue and goal value divided by derived advertising cost (id: <code>ga:ROAS)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_roas</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ROAS instead.")]
        public static readonly AnalyticsMetric ROAS = Metrics.AnalyticsMetrics.ROAS;

        #endregion

        #region Goal Conversions

        /// <summary>
        /// Gets the total number of starts for the requested goal number (id: <code>ga:goalXXStarts)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalxxstarts</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.GoalXXStarts instead.")]
        public static readonly AnalyticsMetric GoalXXStarts = Metrics.AnalyticsMetrics.GoalXXStarts;

        /// <summary>
        /// Gets the total number of starts for all goals defined for your profile (id: <code>ga:goalStartsAll)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalstartsall</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.GoalStartsAll instead.")]
        public static readonly AnalyticsMetric GoalStartsAll = Metrics.AnalyticsMetrics.GoalStartsAll;

        /// <summary>
        /// Gets the total number of completions for the requested goal number (id: <code>ga:goalXXCompletions)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalxxcompletions</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.GoalXXCompletions instead.")]
        public static readonly AnalyticsMetric GoalXXCompletions = Metrics.AnalyticsMetrics.GoalXXCompletions;

        /// <summary>
        /// Gets the total number of completions for all goals defined for your profile (id: <code>ga:goalCompletionsAll)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalcompletionsall</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.GoalCompletionsAll instead.")]
        public static readonly AnalyticsMetric GoalCompletionsAll = Metrics.AnalyticsMetrics.GoalCompletionsAll;

        /// <summary>
        /// Gets the total numeric value for the requested goal number (id: <code>ga:goalXXValue)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalxxvalue</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.GoalXXValue instead.")]
        public static readonly AnalyticsMetric GoalXXValue = Metrics.AnalyticsMetrics.GoalXXValue;

        /// <summary>
        /// Gets the total numeric value for all goals defined for your profile (id: <code>ga:goalValueAll)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalvalueall</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.GoalValueAll instead.")]
        public static readonly AnalyticsMetric GoalValueAll = Metrics.AnalyticsMetrics.GoalValueAll;

        /// <summary>
        /// Gets the average goal value of a session (id: <code>ga:goalValuePerSession)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalvaluepersession</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.GoalValuePerSession instead.")]
        public static readonly AnalyticsMetric GoalValuePerSession = Metrics.AnalyticsMetrics.GoalValuePerSession;

        /// <summary>
        /// Gets the average goal value of a session (id: <code>ga:goalValuePerVisit)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalvaluepervisit</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.GoalValuePerVisit instead.")]
        public static readonly AnalyticsMetric GoalValuePerVisit = Metrics.AnalyticsMetrics.GoalValuePerVisit;

        /// <summary>
        /// Gets the percentage of sessions which resulted in a conversion to the requested goal number (id: <code>ga:goalXXConversionRate)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalxxconversionrate</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.GoalXXConversionRate instead.")]
        public static readonly AnalyticsMetric GoalXXConversionRate = Metrics.AnalyticsMetrics.GoalXXConversionRate;

        /// <summary>
        /// Gets the percentage of sessions which resulted in a conversion to at least one of your goals (id: <code>ga:goalConversionRateAll)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalconversionrateall</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.GoalConversionRateAll instead.")]
        public static readonly AnalyticsMetric GoalConversionRateAll = Metrics.AnalyticsMetrics.GoalConversionRateAll;

        /// <summary>
        /// Gets the number of times users started conversion activity on the requested goal number without actually completing it (id: <code>ga:goalXXAbandons)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalxxabandons</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.GoalXXAbandons instead.")]
        public static readonly AnalyticsMetric GoalXXAbandons = Metrics.AnalyticsMetrics.GoalXXAbandons;

        /// <summary>
        /// Gets the overall number of times users started goals without actually completing them (id: <code>ga:goalAbandonsAll)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalabandonsall</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.GoalAbandonsAll instead.")]
        public static readonly AnalyticsMetric GoalAbandonsAll = Metrics.AnalyticsMetrics.GoalAbandonsAll;

        /// <summary>
        /// Gets the rate at which the requested goal number was abandoned (id: <code>ga:goalXXAbandonRate)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalxxabandonrate</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.GoalXXAbandonRate instead.")]
        public static readonly AnalyticsMetric GoalXXAbandonRate = Metrics.AnalyticsMetrics.GoalXXAbandonRate;

        /// <summary>
        /// Gets the rate at which goals were abandoned (id: <code>ga:goalAbandonRateAll)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalabandonrateall</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.GoalAbandonRateAll instead.")]
        public static readonly AnalyticsMetric GoalAbandonRateAll = Metrics.AnalyticsMetrics.GoalAbandonRateAll;

        #endregion

        #region Social Activities

        /// <summary>
        /// Gets the total number of activities where a content URL was shared / mentioned on a social data hub partner network (id: <code>ga:socialActivities)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivities</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.SocialActivities instead.")]
        public static readonly AnalyticsMetric SocialActivities = Metrics.AnalyticsMetrics.SocialActivities;

        #endregion

        #region Page Tracking

        /// <summary>
        /// Gets the average value of this page or set of pages. Page Value is (<code>ga:transactionRevenue</code> + <code>ga:goalValueAll</code>) / <code>ga:uniquePageviews</code> (for the page or set of pages) (id: <code>ga:pageValue)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pagevalue</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.PageValue instead.")]
        public static readonly AnalyticsMetric PageValue = Metrics.AnalyticsMetrics.PageValue;

        /// <summary>
        /// Gets the number of entrances to your property measured as the first pageview in a session. Typically used with landingPagePath (id: <code>ga:entrances)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_entrances</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.Entrances instead.")]
        public static readonly AnalyticsMetric Entrances = Metrics.AnalyticsMetrics.Entrances;

        /// <summary>
        /// Gets the percentage of pageviews in which this page was the entrance (id: <code>ga:entranceRate)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_entrancerate</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.EntranceRate instead.")]
        public static readonly AnalyticsMetric EntranceRate = Metrics.AnalyticsMetrics.EntranceRate;

        /// <summary>
        /// Gets the total number of pageviews for your property (id: <code>ga:pageviews)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pageviews</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.Pageviews instead.")]
        public static readonly AnalyticsMetric Pageviews = Metrics.AnalyticsMetrics.Pageviews;

        /// <summary>
        /// Gets the average number of pages viewed during a session, including repeated views of a single page (id: <code>ga:pageviewsPerSession)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pageviewspersession</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.PageviewsPerSession instead.")]
        public static readonly AnalyticsMetric PageviewsPerSession = Metrics.AnalyticsMetrics.PageviewsPerSession;

        /// <summary>
        /// Gets the average number of pages viewed during a session, including repeated views of a single page (id: <code>ga:pageviewsPerVisit)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pageviewspervisit</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.PageviewsPerVisit instead.")]
        public static readonly AnalyticsMetric PageviewsPerVisit = Metrics.AnalyticsMetrics.PageviewsPerVisit;

        /// <summary>
        /// Gets the number of different (unique) pages within a session. This takes into account both the pagePath and pageTitle to determine uniqueness (id: <code>ga:uniquePageviews)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_uniquepageviews</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.UniquePageviews instead.")]
        public static readonly AnalyticsMetric UniquePageviews = Metrics.AnalyticsMetrics.UniquePageviews;

        /// <summary>
        /// Gets how long a user spent on a particular page in seconds. Calculated by subtracting the initial view time for a particular page from the initial view time for a subsequent page. Thus, this metric does not apply to exit pages for your property (id: <code>ga:timeOnPage)</code>, type: <code>time)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_timeonpage</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.TimeOnPage instead.")]
        public static readonly AnalyticsMetric TimeOnPage = Metrics.AnalyticsMetrics.TimeOnPage;

        /// <summary>
        /// Gets the average amount of time users spent viewing this page or a set of pages (id: <code>ga:avgTimeOnPage)</code>, type: <code>time)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_avgtimeonpage</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AvgTimeOnPage instead.")]
        public static readonly AnalyticsMetric AvgTimeOnPage = Metrics.AnalyticsMetrics.AvgTimeOnPage;

        /// <summary>
        /// Gets the number of exits from your property (id: <code>ga:exits)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_exits</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.Exits instead.")]
        public static readonly AnalyticsMetric Exits = Metrics.AnalyticsMetrics.Exits;

        /// <summary>
        /// Gets the percentage of exits from your property that occurred out of the total page views (id: <code>ga:exitRate)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_exitrate</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ExitRate instead.")]
        public static readonly AnalyticsMetric ExitRate = Metrics.AnalyticsMetrics.ExitRate;

        #endregion

        #region Content Grouping

        /// <summary>
        /// Gets the number of different (unique) pages within a session for the specified content group. This takes into account both the pagePath and pageTitle to determine uniqueness (id: <code>ga:contentGroupUniqueViewsXX)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=content_grouping&amp;jump=ga_contentgroupuniqueviewsxx</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ContentGroupUniqueViewsXX instead.")]
        public static readonly AnalyticsMetric ContentGroupUniqueViewsXX = Metrics.AnalyticsMetrics.ContentGroupUniqueViewsXX;

        #endregion

        #region Internal Search

        /// <summary>
        /// Gets the number of times a search result page was viewed after performing a search (id: <code>ga:searchResultViews)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchresultviews</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.SearchResultViews instead.")]
        public static readonly AnalyticsMetric SearchResultViews = Metrics.AnalyticsMetrics.SearchResultViews;

        /// <summary>
        /// Gets the total number of unique keywords from internal searches within a session. For example if "shoes" was searched for 3 times in a session, it will be only counted once (id: <code>ga:searchUniques)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchuniques</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.SearchUniques instead.")]
        public static readonly AnalyticsMetric SearchUniques = Metrics.AnalyticsMetrics.SearchUniques;

        /// <summary>
        /// Gets the average number of times people viewed a search results page after performing a search (id: <code>ga:avgSearchResultViews)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_avgsearchresultviews</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AvgSearchResultViews instead.")]
        public static readonly AnalyticsMetric AvgSearchResultViews = Metrics.AnalyticsMetrics.AvgSearchResultViews;

        /// <summary>
        /// Gets the total number of sessions that included an internal search (id: <code>ga:searchSessions)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchsessions</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.SearchSessions instead.")]
        public static readonly AnalyticsMetric SearchSessions = Metrics.AnalyticsMetrics.SearchSessions;

        /// <summary>
        /// Gets the total number of sessions that included an internal search (id: <code>ga:searchVisits)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchvisits</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.SearchVisits instead.")]
        public static readonly AnalyticsMetric SearchVisits = Metrics.AnalyticsMetrics.SearchVisits;

        /// <summary>
        /// Gets the percentage of sessions with search (id: <code>ga:percentSessionsWithSearch)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_percentsessionswithsearch</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.PercentSessionsWithSearch instead.")]
        public static readonly AnalyticsMetric PercentSessionsWithSearch = Metrics.AnalyticsMetrics.PercentSessionsWithSearch;

        /// <summary>
        /// Gets the percentage of sessions with search (id: <code>ga:percentVisitsWithSearch)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_percentvisitswithsearch</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.PercentVisitsWithSearch instead.")]
        public static readonly AnalyticsMetric PercentVisitsWithSearch = Metrics.AnalyticsMetrics.PercentVisitsWithSearch;

        /// <summary>
        /// Gets the total number of subsequent page views made after a use of your internal search feature (id: <code>ga:searchDepth)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchdepth</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.SearchDepth instead.")]
        public static readonly AnalyticsMetric SearchDepth = Metrics.AnalyticsMetrics.SearchDepth;

        /// <summary>
        /// Gets the average number of pages people viewed after performing a search (id: <code>ga:avgSearchDepth)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_avgsearchdepth</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AvgSearchDepth instead.")]
        public static readonly AnalyticsMetric AvgSearchDepth = Metrics.AnalyticsMetrics.AvgSearchDepth;

        /// <summary>
        /// Gets the total number of times a refinement (transition) occurs between internal search keywords within a session. For example if the sequence of keywords is: "shoes", "shoes", "pants", "pants", this metric will be one because the transition between "shoes" and "pants" is different (id: <code>ga:searchRefinements)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchrefinements</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.SearchRefinements instead.")]
        public static readonly AnalyticsMetric SearchRefinements = Metrics.AnalyticsMetrics.SearchRefinements;

        /// <summary>
        /// Gets the percentage of number of times a refinement (i.e., transition) occurs between internal search keywords within a session (id: <code>ga:percentSearchRefinements)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_percentsearchrefinements</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.PercentSearchRefinements instead.")]
        public static readonly AnalyticsMetric PercentSearchRefinements = Metrics.AnalyticsMetrics.PercentSearchRefinements;

        /// <summary>
        /// Gets the session duration where a use of your internal search feature occurred (id: <code>ga:searchDuration)</code>, type: <code>time)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchduration</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.SearchDuration instead.")]
        public static readonly AnalyticsMetric SearchDuration = Metrics.AnalyticsMetrics.SearchDuration;

        /// <summary>
        /// Gets the average time (in seconds) users spent on your property after searching (id: <code>ga:avgSearchDuration)</code>, type: <code>time)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_avgsearchduration</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AvgSearchDuration instead.")]
        public static readonly AnalyticsMetric AvgSearchDuration = Metrics.AnalyticsMetrics.AvgSearchDuration;

        /// <summary>
        /// Gets the number of exits on your site that occurred following a search result from your internal search feature (id: <code>ga:searchExits)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchexits</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.SearchExits instead.")]
        public static readonly AnalyticsMetric SearchExits = Metrics.AnalyticsMetrics.SearchExits;

        /// <summary>
        /// Gets the percentage of searches that resulted in an immediate exit from your property (id: <code>ga:searchExitRate)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchexitrate</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.SearchExitRate instead.")]
        public static readonly AnalyticsMetric SearchExitRate = Metrics.AnalyticsMetrics.SearchExitRate;

        /// <summary>
        /// Gets the percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number (id: <code>ga:searchGoalXXConversionRate)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchgoalxxconversionrate</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.SearchGoalXXConversionRate instead.")]
        public static readonly AnalyticsMetric SearchGoalXXConversionRate = Metrics.AnalyticsMetrics.SearchGoalXXConversionRate;

        /// <summary>
        /// Gets the percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to at least one of your goals (id: <code>ga:searchGoalConversionRateAll)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchgoalconversionrateall</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.SearchGoalConversionRateAll instead.")]
        public static readonly AnalyticsMetric SearchGoalConversionRateAll = Metrics.AnalyticsMetrics.SearchGoalConversionRateAll;

        /// <summary>
        /// Gets the average goal value of a search (id: <code>ga:goalValueAllPerSearch)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_goalvalueallpersearch</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.GoalValueAllPerSearch instead.")]
        public static readonly AnalyticsMetric GoalValueAllPerSearch = Metrics.AnalyticsMetrics.GoalValueAllPerSearch;

        #endregion

        #region Site Speed

        /// <summary>
        /// Gets the total Page Load Time is the amount of time (in milliseconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser (id: <code>ga:pageLoadTime)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_pageloadtime</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.PageLoadTime instead.")]
        public static readonly AnalyticsMetric PageLoadTime = Metrics.AnalyticsMetrics.PageLoadTime;

        /// <summary>
        /// Gets the sample set (or count) of pageviews used to calculate the average page load time (id: <code>ga:pageLoadSample)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_pageloadsample</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.PageLoadSample instead.")]
        public static readonly AnalyticsMetric PageLoadSample = Metrics.AnalyticsMetrics.PageLoadSample;

        /// <summary>
        /// Gets the average amount of time (in seconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser (id: <code>ga:avgPageLoadTime)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_avgpageloadtime</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AvgPageLoadTime instead.")]
        public static readonly AnalyticsMetric AvgPageLoadTime = Metrics.AnalyticsMetrics.AvgPageLoadTime;

        /// <summary>
        /// Gets the total amount of time (in milliseconds) spent in DNS lookup for this page among all samples (id: <code>ga:domainLookupTime)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_domainlookuptime</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.DomainLookupTime instead.")]
        public static readonly AnalyticsMetric DomainLookupTime = Metrics.AnalyticsMetrics.DomainLookupTime;

        /// <summary>
        /// Gets the average amount of time (in seconds) spent in DNS lookup for this page (id: <code>ga:avgDomainLookupTime)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_avgdomainlookuptime</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AvgDomainLookupTime instead.")]
        public static readonly AnalyticsMetric AvgDomainLookupTime = Metrics.AnalyticsMetrics.AvgDomainLookupTime;

        /// <summary>
        /// Gets the total amount of time (in milliseconds) to download this page among all samples (id: <code>ga:pageDownloadTime)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_pagedownloadtime</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.PageDownloadTime instead.")]
        public static readonly AnalyticsMetric PageDownloadTime = Metrics.AnalyticsMetrics.PageDownloadTime;

        /// <summary>
        /// Gets the average amount of time (in seconds) to download this page (id: <code>ga:avgPageDownloadTime)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_avgpagedownloadtime</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AvgPageDownloadTime instead.")]
        public static readonly AnalyticsMetric AvgPageDownloadTime = Metrics.AnalyticsMetrics.AvgPageDownloadTime;

        /// <summary>
        /// Gets the total amount of time (in milliseconds) spent in redirects before fetching this page among all samples. If there are no redirects, the value for this metric is expected to be 0 (id: <code>ga:redirectionTime)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_redirectiontime</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.RedirectionTime instead.")]
        public static readonly AnalyticsMetric RedirectionTime = Metrics.AnalyticsMetrics.RedirectionTime;

        /// <summary>
        /// Gets the average amount of time (in seconds) spent in redirects before fetching this page. If there are no redirects, the value for this metric is expected to be 0 (id: <code>ga:avgRedirectionTime)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_avgredirectiontime</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AvgRedirectionTime instead.")]
        public static readonly AnalyticsMetric AvgRedirectionTime = Metrics.AnalyticsMetrics.AvgRedirectionTime;

        /// <summary>
        /// Gets the total amount of time (in milliseconds) spent in establishing TCP connection for this page among all samples (id: <code>ga:serverConnectionTime)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_serverconnectiontime</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ServerConnectionTime instead.")]
        public static readonly AnalyticsMetric ServerConnectionTime = Metrics.AnalyticsMetrics.ServerConnectionTime;

        /// <summary>
        /// Gets the average amount of time (in seconds) spent in establishing TCP connection for this page (id: <code>ga:avgServerConnectionTime)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_avgserverconnectiontime</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AvgServerConnectionTime instead.")]
        public static readonly AnalyticsMetric AvgServerConnectionTime = Metrics.AnalyticsMetrics.AvgServerConnectionTime;

        /// <summary>
        /// Gets the total amount of time (in milliseconds) your server takes to respond to a user request among all samples, including the network time from user's location to your server (id: <code>ga:serverResponseTime)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_serverresponsetime</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ServerResponseTime instead.")]
        public static readonly AnalyticsMetric ServerResponseTime = Metrics.AnalyticsMetrics.ServerResponseTime;

        /// <summary>
        /// Gets the average amount of time (in seconds) your server takes to respond to a user request, including the network time from user's location to your server (id: <code>ga:avgServerResponseTime)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_avgserverresponsetime</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AvgServerResponseTime instead.")]
        public static readonly AnalyticsMetric AvgServerResponseTime = Metrics.AnalyticsMetrics.AvgServerResponseTime;

        /// <summary>
        /// Gets the sample set (or count) of pageviews used to calculate the averages for site speed metrics. This metric is used in all site speed average calculations including avgDomainLookupTime, avgPageDownloadTime, avgRedirectionTime, avgServerConnectionTime, and avgServerResponseTime (id: <code>ga:speedMetricsSample)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_speedmetricssample</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.SpeedMetricsSample instead.")]
        public static readonly AnalyticsMetric SpeedMetricsSample = Metrics.AnalyticsMetrics.SpeedMetricsSample;

        /// <summary>
        /// Gets the time the browser takes (in milliseconds) to parse the document (DOMInteractive), including the network time from the user's location to your server. At this time, the user can interact with the Document Object Model even though it is not fully loaded (id: <code>ga:domInteractiveTime)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_dominteractivetime</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.DomInteractiveTime instead.")]
        public static readonly AnalyticsMetric DomInteractiveTime = Metrics.AnalyticsMetrics.DomInteractiveTime;

        /// <summary>
        /// Gets the average time (in seconds) it takes the browser to parse the document and execute deferred and parser-inserted scripts including the network time from the user's location to your server (id: <code>ga:avgDomInteractiveTime)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_avgdominteractivetime</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AvgDomInteractiveTime instead.")]
        public static readonly AnalyticsMetric AvgDomInteractiveTime = Metrics.AnalyticsMetrics.AvgDomInteractiveTime;

        /// <summary>
        /// Gets the time the browser takes (in milliseconds) to parse the document and execute deferred and parser-inserted scripts (DOMContentLoaded), including the network time from the user's location to your server. Parsing of the document is finished, the Document Object Model is ready, but referenced style sheets, images, and subframes may not be finished loading. This event is often the starting point for javascript framework execution, e.g., JQuery's onready() callback, etc (id: <code>ga:domContentLoadedTime)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_domcontentloadedtime</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.DomContentLoadedTime instead.")]
        public static readonly AnalyticsMetric DomContentLoadedTime = Metrics.AnalyticsMetrics.DomContentLoadedTime;

        /// <summary>
        /// Gets the average time (in seconds) it takes the browser to parse the document (id: <code>ga:avgDomContentLoadedTime)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_avgdomcontentloadedtime</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AvgDomContentLoadedTime instead.")]
        public static readonly AnalyticsMetric AvgDomContentLoadedTime = Metrics.AnalyticsMetrics.AvgDomContentLoadedTime;

        /// <summary>
        /// Gets the sample set (or count) of pageviews used to calculate the averages for site speed DOM metrics. This metric is used in the avgDomContentLoadedTime and avgDomInteractiveTime calculations (id: <code>ga:domLatencyMetricsSample)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_domlatencymetricssample</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.DomLatencyMetricsSample instead.")]
        public static readonly AnalyticsMetric DomLatencyMetricsSample = Metrics.AnalyticsMetrics.DomLatencyMetricsSample;

        #endregion

        #region App Tracking

        /// <summary>
        /// Gets the total number of screenviews (id: <code>ga:screenviews)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_screenviews</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.Screenviews instead.")]
        public static readonly AnalyticsMetric Screenviews = Metrics.AnalyticsMetrics.Screenviews;

        /// <summary>
        /// Gets the total number of screenviews (id: <code>ga:appviews)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_appviews</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.Appviews instead.")]
        public static readonly AnalyticsMetric Appviews = Metrics.AnalyticsMetrics.Appviews;

        /// <summary>
        /// Gets the number of different (unique) screenviews within a session (id: <code>ga:uniqueScreenviews)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_uniquescreenviews</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.UniqueScreenviews instead.")]
        public static readonly AnalyticsMetric UniqueScreenviews = Metrics.AnalyticsMetrics.UniqueScreenviews;

        /// <summary>
        /// Gets the number of different (unique) screenviews within a session (id: <code>ga:uniqueAppviews)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_uniqueappviews</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.UniqueAppviews instead.")]
        public static readonly AnalyticsMetric UniqueAppviews = Metrics.AnalyticsMetrics.UniqueAppviews;

        /// <summary>
        /// Gets the average number of screenviews per session (id: <code>ga:screenviewsPerSession)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_screenviewspersession</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ScreenviewsPerSession instead.")]
        public static readonly AnalyticsMetric ScreenviewsPerSession = Metrics.AnalyticsMetrics.ScreenviewsPerSession;

        /// <summary>
        /// Gets the average number of screenviews per session (id: <code>ga:appviewsPerVisit)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_appviewspervisit</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AppviewsPerVisit instead.")]
        public static readonly AnalyticsMetric AppviewsPerVisit = Metrics.AnalyticsMetrics.AppviewsPerVisit;

        /// <summary>
        /// Gets the time spent viewing the current screen (id: <code>ga:timeOnScreen)</code>, type: <code>time)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_timeonscreen</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.TimeOnScreen instead.")]
        public static readonly AnalyticsMetric TimeOnScreen = Metrics.AnalyticsMetrics.TimeOnScreen;

        /// <summary>
        /// Gets the average amount of time users spent on a screen in seconds (id: <code>ga:avgScreenviewDuration)</code>, type: <code>time)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_avgscreenviewduration</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AvgScreenviewDuration instead.")]
        public static readonly AnalyticsMetric AvgScreenviewDuration = Metrics.AnalyticsMetrics.AvgScreenviewDuration;

        #endregion

        #region Event Tracking

        /// <summary>
        /// Gets the total number of events for the profile, across all categories (id: <code>ga:totalEvents)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_totalevents</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.TotalEvents instead.")]
        public static readonly AnalyticsMetric TotalEvents = Metrics.AnalyticsMetrics.TotalEvents;

        /// <summary>
        /// Gets the total number of unique events for the profile, across all categories (id: <code>ga:uniqueEvents)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_uniqueevents</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.UniqueEvents instead.")]
        public static readonly AnalyticsMetric UniqueEvents = Metrics.AnalyticsMetrics.UniqueEvents;

        /// <summary>
        /// Gets the total value of events for the profile (id: <code>ga:eventValue)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_eventvalue</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.EventValue instead.")]
        public static readonly AnalyticsMetric EventValue = Metrics.AnalyticsMetrics.EventValue;

        /// <summary>
        /// Gets the average value of an event (id: <code>ga:avgEventValue)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_avgeventvalue</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AvgEventValue instead.")]
        public static readonly AnalyticsMetric AvgEventValue = Metrics.AnalyticsMetrics.AvgEventValue;

        /// <summary>
        /// Gets the total number of sessions with events (id: <code>ga:sessionsWithEvent)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_sessionswithevent</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.SessionsWithEvent instead.")]
        public static readonly AnalyticsMetric SessionsWithEvent = Metrics.AnalyticsMetrics.SessionsWithEvent;

        /// <summary>
        /// Gets the total number of sessions with events (id: <code>ga:visitsWithEvent)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_visitswithevent</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.VisitsWithEvent instead.")]
        public static readonly AnalyticsMetric VisitsWithEvent = Metrics.AnalyticsMetrics.VisitsWithEvent;

        /// <summary>
        /// Gets the average number of events per session with event (id: <code>ga:eventsPerSessionWithEvent)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_eventspersessionwithevent</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.EventsPerSessionWithEvent instead.")]
        public static readonly AnalyticsMetric EventsPerSessionWithEvent = Metrics.AnalyticsMetrics.EventsPerSessionWithEvent;

        /// <summary>
        /// Gets the average number of events per session with event (id: <code>ga:eventsPerVisitWithEvent)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_eventspervisitwithevent</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.EventsPerVisitWithEvent instead.")]
        public static readonly AnalyticsMetric EventsPerVisitWithEvent = Metrics.AnalyticsMetrics.EventsPerVisitWithEvent;

        #endregion

        #region Ecommerce

        /// <summary>
        /// Gets the total number of transactions (id: <code>ga:transactions)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactions</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.Transactions instead.")]
        public static readonly AnalyticsMetric Transactions = Metrics.AnalyticsMetrics.Transactions;

        /// <summary>
        /// Gets the average number of transactions for a session (id: <code>ga:transactionsPerSession)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactionspersession</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.TransactionsPerSession instead.")]
        public static readonly AnalyticsMetric TransactionsPerSession = Metrics.AnalyticsMetrics.TransactionsPerSession;

        /// <summary>
        /// Gets the average number of transactions for a session (id: <code>ga:transactionsPerVisit)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactionspervisit</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.TransactionsPerVisit instead.")]
        public static readonly AnalyticsMetric TransactionsPerVisit = Metrics.AnalyticsMetrics.TransactionsPerVisit;

        /// <summary>
        /// Gets the total sale revenue provided in the transaction excluding shipping and tax (id: <code>ga:transactionRevenue)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactionrevenue</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.TransactionRevenue instead.")]
        public static readonly AnalyticsMetric TransactionRevenue = Metrics.AnalyticsMetrics.TransactionRevenue;

        /// <summary>
        /// Gets the average revenue for an e-commerce transaction (id: <code>ga:revenuePerTransaction)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_revenuepertransaction</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.RevenuePerTransaction instead.")]
        public static readonly AnalyticsMetric RevenuePerTransaction = Metrics.AnalyticsMetrics.RevenuePerTransaction;

        /// <summary>
        /// Average transaction revenue for a session (id: <code>ga:transactionRevenuePerSession)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactionrevenuepersession</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.TransactionRevenuePerSession instead.")]
        public static readonly AnalyticsMetric TransactionRevenuePerSession = Metrics.AnalyticsMetrics.TransactionRevenuePerSession;

        /// <summary>
        /// Average transaction revenue for a session (id: <code>ga:transactionRevenuePerVisit)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactionrevenuepervisit</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.TransactionRevenuePerVisit instead.")]
        public static readonly AnalyticsMetric TransactionRevenuePerVisit = Metrics.AnalyticsMetrics.TransactionRevenuePerVisit;

        /// <summary>
        /// Gets the total cost of shipping (id: <code>ga:transactionShipping)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactionshipping</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.TransactionShipping instead.")]
        public static readonly AnalyticsMetric TransactionShipping = Metrics.AnalyticsMetrics.TransactionShipping;

        /// <summary>
        /// Gets the total amount of tax (id: <code>ga:transactionTax)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactiontax</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.TransactionTax instead.")]
        public static readonly AnalyticsMetric TransactionTax = Metrics.AnalyticsMetrics.TransactionTax;

        /// <summary>
        /// Gets the total value for your property (including total revenue and total goal value) (id: <code>ga:totalValue)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_totalvalue</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.TotalValue instead.")]
        public static readonly AnalyticsMetric TotalValue = Metrics.AnalyticsMetrics.TotalValue;

        /// <summary>
        /// Gets the total number of items purchased. For example, if users purchase 2 frisbees and 5 tennis balls, 7 items have been purchased (id: <code>ga:itemQuantity)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_itemquantity</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ItemQuantity instead.")]
        public static readonly AnalyticsMetric ItemQuantity = Metrics.AnalyticsMetrics.ItemQuantity;

        /// <summary>
        /// Gets the number of product sets purchased. For example, if users purchase 2 frisbees and 5 tennis balls from your site, 2 unique products have been purchased (id: <code>ga:uniquePurchases)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_uniquepurchases</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.UniquePurchases instead.")]
        public static readonly AnalyticsMetric UniquePurchases = Metrics.AnalyticsMetrics.UniquePurchases;

        /// <summary>
        /// Gets the average revenue per item (id: <code>ga:revenuePerItem)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_revenueperitem</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.RevenuePerItem instead.")]
        public static readonly AnalyticsMetric RevenuePerItem = Metrics.AnalyticsMetrics.RevenuePerItem;

        /// <summary>
        /// Gets the total revenue from purchased product items (id: <code>ga:itemRevenue)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_itemrevenue</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ItemRevenue instead.")]
        public static readonly AnalyticsMetric ItemRevenue = Metrics.AnalyticsMetrics.ItemRevenue;

        /// <summary>
        /// Gets the average quantity of this item (or group of items) sold per purchase (id: <code>ga:itemsPerPurchase)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_itemsperpurchase</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ItemsPerPurchase instead.")]
        public static readonly AnalyticsMetric ItemsPerPurchase = Metrics.AnalyticsMetrics.ItemsPerPurchase;

        /// <summary>
        /// Transaction revenue in local currency (id: <code>ga:localTransactionRevenue)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_localtransactionrevenue</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.LocalTransactionRevenue instead.")]
        public static readonly AnalyticsMetric LocalTransactionRevenue = Metrics.AnalyticsMetrics.LocalTransactionRevenue;

        /// <summary>
        /// Transaction shipping cost in local currency (id: <code>ga:localTransactionShipping)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_localtransactionshipping</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.LocalTransactionShipping instead.")]
        public static readonly AnalyticsMetric LocalTransactionShipping = Metrics.AnalyticsMetrics.LocalTransactionShipping;

        /// <summary>
        /// Transaction tax in local currency (id: <code>ga:localTransactionTax)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_localtransactiontax</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.LocalTransactionTax instead.")]
        public static readonly AnalyticsMetric LocalTransactionTax = Metrics.AnalyticsMetrics.LocalTransactionTax;

        /// <summary>
        /// Product revenue in local currency (id: <code>ga:localItemRevenue)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_localitemrevenue</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.LocalItemRevenue instead.")]
        public static readonly AnalyticsMetric LocalItemRevenue = Metrics.AnalyticsMetrics.LocalItemRevenue;

        /// <summary>
        /// Unique purchases divided by views of product detail pages (Enhanced Ecommerce) (id: <code>ga:buyToDetailRate)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_buytodetailrate</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.BuyToDetailRate instead.")]
        public static readonly AnalyticsMetric BuyToDetailRate = Metrics.AnalyticsMetrics.BuyToDetailRate;

        /// <summary>
        /// Product adds divided by views of product details (Enhanced Ecommerce) (id: <code>ga:cartToDetailRate)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_carttodetailrate</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.CartToDetailRate instead.")]
        public static readonly AnalyticsMetric CartToDetailRate = Metrics.AnalyticsMetrics.CartToDetailRate;

        /// <summary>
        /// Gets the rate at which users clicked through to view the internal promotion (<code>ga:internalPromotionClicks</code> / <code>ga:internalPromotionViews</code>) - (Enhanced Ecommerce) (id: <code>ga:internalPromotionCTR)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_internalpromotionctr</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.InternalPromotionCTR instead.")]
        public static readonly AnalyticsMetric InternalPromotionCTR = Metrics.AnalyticsMetrics.InternalPromotionCTR;

        /// <summary>
        /// Gets the number of clicks on an internal promotion (Enhanced Ecommerce) (id: <code>ga:internalPromotionClicks)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_internalpromotionclicks</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.InternalPromotionClicks instead.")]
        public static readonly AnalyticsMetric InternalPromotionClicks = Metrics.AnalyticsMetrics.InternalPromotionClicks;

        /// <summary>
        /// Gets the number of views of an internal promotion (Enhanced Ecommerce) (id: <code>ga:internalPromotionViews)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_internalpromotionviews</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.InternalPromotionViews instead.")]
        public static readonly AnalyticsMetric InternalPromotionViews = Metrics.AnalyticsMetrics.InternalPromotionViews;

        /// <summary>
        /// Refund amount for a given product in the local currency (Enhanced Ecommerce) (id: <code>ga:localProductRefundAmount)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_localproductrefundamount</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.LocalProductRefundAmount instead.")]
        public static readonly AnalyticsMetric LocalProductRefundAmount = Metrics.AnalyticsMetrics.LocalProductRefundAmount;

        /// <summary>
        /// Gets the total refund amount for the transaction in the local currency (Enhanced Ecommerce) (id: <code>ga:localRefundAmount)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_localrefundamount</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.LocalRefundAmount instead.")]
        public static readonly AnalyticsMetric LocalRefundAmount = Metrics.AnalyticsMetrics.LocalRefundAmount;

        /// <summary>
        /// Number of times the product was added to the shopping cart (Enhanced Ecommerce) (id: <code>ga:productAddsToCart)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productaddstocart</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ProductAddsToCart instead.")]
        public static readonly AnalyticsMetric ProductAddsToCart = Metrics.AnalyticsMetrics.ProductAddsToCart;

        /// <summary>
        /// Number of times the product was included in the check-out process (Enhanced Ecommerce) (id: <code>ga:productCheckouts)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productcheckouts</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ProductCheckouts instead.")]
        public static readonly AnalyticsMetric ProductCheckouts = Metrics.AnalyticsMetrics.ProductCheckouts;

        /// <summary>
        /// Number of times users viewed the product-detail page (Enhanced Ecommerce) (id: <code>ga:productDetailViews)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productdetailviews</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ProductDetailViews instead.")]
        public static readonly AnalyticsMetric ProductDetailViews = Metrics.AnalyticsMetrics.ProductDetailViews;

        /// <summary>
        /// Gets the rate at which users clicked through on the product in a product list (<code>ga:productListClicks</code> / <code>ga:productListViews</code>) - (Enhanced Ecommerce) (id: <code>ga:productListCTR)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productlistctr</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ProductListCTR instead.")]
        public static readonly AnalyticsMetric ProductListCTR = Metrics.AnalyticsMetrics.ProductListCTR;

        /// <summary>
        /// Number of times users clicked the product when it appeared in the product list (Enhanced Ecommerce) (id: <code>ga:productListClicks)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productlistclicks</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ProductListClicks instead.")]
        public static readonly AnalyticsMetric ProductListClicks = Metrics.AnalyticsMetrics.ProductListClicks;

        /// <summary>
        /// Number of times the product appeared in a product list (Enhanced Ecommerce) (id: <code>ga:productListViews)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productlistviews</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ProductListViews instead.")]
        public static readonly AnalyticsMetric ProductListViews = Metrics.AnalyticsMetrics.ProductListViews;

        /// <summary>
        /// Gets the total refund amount associated with the product (Enhanced Ecommerce) (id: <code>ga:productRefundAmount)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productrefundamount</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ProductRefundAmount instead.")]
        public static readonly AnalyticsMetric ProductRefundAmount = Metrics.AnalyticsMetrics.ProductRefundAmount;

        /// <summary>
        /// Number of times a refund was issued for the product (Enhanced Ecommerce) (id: <code>ga:productRefunds)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productrefunds</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ProductRefunds instead.")]
        public static readonly AnalyticsMetric ProductRefunds = Metrics.AnalyticsMetrics.ProductRefunds;

        /// <summary>
        /// Number of times the product was removed from shopping cart (Enhanced Ecommerce) (id: <code>ga:productRemovesFromCart)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productremovesfromcart</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ProductRemovesFromCart instead.")]
        public static readonly AnalyticsMetric ProductRemovesFromCart = Metrics.AnalyticsMetrics.ProductRemovesFromCart;

        /// <summary>
        /// Average product revenue per purchase (commonly used with Product Coupon Code) (<code>ga:itemRevenue</code> / <code>ga:uniquePurchases</code>) - (Enhanced Ecommerce) (id: <code>ga:productRevenuePerPurchase)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productrevenueperpurchase</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ProductRevenuePerPurchase instead.")]
        public static readonly AnalyticsMetric ProductRevenuePerPurchase = Metrics.AnalyticsMetrics.ProductRevenuePerPurchase;

        /// <summary>
        /// Number of product units added to the shopping cart (Enhanced Ecommerce) (id: <code>ga:quantityAddedToCart)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_quantityaddedtocart</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.QuantityAddedToCart instead.")]
        public static readonly AnalyticsMetric QuantityAddedToCart = Metrics.AnalyticsMetrics.QuantityAddedToCart;

        /// <summary>
        /// Number of product units included in check out (Enhanced Ecommerce) (id: <code>ga:quantityCheckedOut)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_quantitycheckedout</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.QuantityCheckedOut instead.")]
        public static readonly AnalyticsMetric QuantityCheckedOut = Metrics.AnalyticsMetrics.QuantityCheckedOut;

        /// <summary>
        /// Number of product units refunded (Enhanced Ecommerce) (id: <code>ga:quantityRefunded)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_quantityrefunded</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.QuantityRefunded instead.")]
        public static readonly AnalyticsMetric QuantityRefunded = Metrics.AnalyticsMetrics.QuantityRefunded;

        /// <summary>
        /// Number of product units removed from cart (Enhanced Ecommerce) (id: <code>ga:quantityRemovedFromCart)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_quantityremovedfromcart</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.QuantityRemovedFromCart instead.")]
        public static readonly AnalyticsMetric QuantityRemovedFromCart = Metrics.AnalyticsMetrics.QuantityRemovedFromCart;

        /// <summary>
        /// Currency amount refunded for a transaction (Enhanced Ecommerce) (id: <code>ga:refundAmount)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_refundamount</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.RefundAmount instead.")]
        public static readonly AnalyticsMetric RefundAmount = Metrics.AnalyticsMetrics.RefundAmount;

        /// <summary>
        /// Gets the total sale revenue provided in the transaction excluding shipping and tax divided by the total number of users (id: <code>ga:revenuePerUser)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_revenueperuser</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.RevenuePerUser instead.")]
        public static readonly AnalyticsMetric RevenuePerUser = Metrics.AnalyticsMetrics.RevenuePerUser;

        /// <summary>
        /// Number of refunds that have been issued (Enhanced Ecommerce) (id: <code>ga:totalRefunds)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_totalrefunds</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.TotalRefunds instead.")]
        public static readonly AnalyticsMetric TotalRefunds = Metrics.AnalyticsMetrics.TotalRefunds;

        /// <summary>
        /// Gets the total number of transactions divided by the total number of users (id: <code>ga:transactionsPerUser)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactionsperuser</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.TransactionsPerUser instead.")]
        public static readonly AnalyticsMetric TransactionsPerUser = Metrics.AnalyticsMetrics.TransactionsPerUser;

        #endregion

        #region Social Interactions

        /// <summary>
        /// Gets the total number of social interactions (id: <code>ga:socialInteractions)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_interactions&amp;jump=ga_socialinteractions</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.SocialInteractions instead.")]
        public static readonly AnalyticsMetric SocialInteractions = Metrics.AnalyticsMetrics.SocialInteractions;

        /// <summary>
        /// Gets the number of sessions during which the specified social action(s) occurred at least once. This is based on the the unique combination of socialInteractionNetwork, socialInteractionAction, and socialInteractionTarget (id: <code>ga:uniqueSocialInteractions)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_interactions&amp;jump=ga_uniquesocialinteractions</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.UniqueSocialInteractions instead.")]
        public static readonly AnalyticsMetric UniqueSocialInteractions = Metrics.AnalyticsMetrics.UniqueSocialInteractions;

        /// <summary>
        /// Gets the number of social interactions per session (id: <code>ga:socialInteractionsPerSession)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_interactions&amp;jump=ga_socialinteractionspersession</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.SocialInteractionsPerSession instead.")]
        public static readonly AnalyticsMetric SocialInteractionsPerSession = Metrics.AnalyticsMetrics.SocialInteractionsPerSession;

        /// <summary>
        /// Gets the number of social interactions per session (id: <code>ga:socialInteractionsPerVisit)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_interactions&amp;jump=ga_socialinteractionspervisit</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.SocialInteractionsPerVisit instead.")]
        public static readonly AnalyticsMetric SocialInteractionsPerVisit = Metrics.AnalyticsMetrics.SocialInteractionsPerVisit;

        #endregion

        #region User Timings

        /// <summary>
        /// Gets the total number of milliseconds for a user timing (id: <code>ga:userTimingValue)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user_timings&amp;jump=ga_usertimingvalue</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.UserTimingValue instead.")]
        public static readonly AnalyticsMetric UserTimingValue = Metrics.AnalyticsMetrics.UserTimingValue;

        /// <summary>
        /// Gets the number of hits that were sent for a particular userTimingCategory, userTimingLabel, and userTimingVariable (id: <code>ga:userTimingSample)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user_timings&amp;jump=ga_usertimingsample</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.UserTimingSample instead.")]
        public static readonly AnalyticsMetric UserTimingSample = Metrics.AnalyticsMetrics.UserTimingSample;

        /// <summary>
        /// Gets the average amount of elapsed time (id: <code>ga:avgUserTimingValue)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user_timings&amp;jump=ga_avgusertimingvalue</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AvgUserTimingValue instead.")]
        public static readonly AnalyticsMetric AvgUserTimingValue = Metrics.AnalyticsMetrics.AvgUserTimingValue;

        #endregion

        #region Exceptions

        /// <summary>
        /// Gets the number of exceptions that were sent to Google Analytics (id: <code>ga:exceptions)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=exceptions&amp;jump=ga_exceptions</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.Exceptions instead.")]
        public static readonly AnalyticsMetric Exceptions = Metrics.AnalyticsMetrics.Exceptions;

        /// <summary>
        /// Gets the number of exceptions thrown divided by the number of screenviews (id: <code>ga:exceptionsPerScreenview)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=exceptions&amp;jump=ga_exceptionsperscreenview</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.ExceptionsPerScreenview instead.")]
        public static readonly AnalyticsMetric ExceptionsPerScreenview = Metrics.AnalyticsMetrics.ExceptionsPerScreenview;

        /// <summary>
        /// Gets the number of exceptions where isFatal is set to true (id: <code>ga:fatalExceptions)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=exceptions&amp;jump=ga_fatalexceptions</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.FatalExceptions instead.")]
        public static readonly AnalyticsMetric FatalExceptions = Metrics.AnalyticsMetrics.FatalExceptions;

        /// <summary>
        /// Gets the number of fatal exceptions thrown divided by the number of screenviews (id: <code>ga:fatalExceptionsPerScreenview)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=exceptions&amp;jump=ga_fatalexceptionsperscreenview</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.FatalExceptionsPerScreenview instead.")]
        public static readonly AnalyticsMetric FatalExceptionsPerScreenview = Metrics.AnalyticsMetrics.FatalExceptionsPerScreenview;

        #endregion

        #region Custom Variables or Columns

        /// <summary>
        /// Gets the name of the requested custom metric, where XX refers the number/index of the custom metric. Note that the data type of <code>ga:metricXX</code> can be INTEGER, CURRENCY or TIME (id: <code>ga:metricXX)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=custom_variables_or_columns&amp;jump=ga_metricxx</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.MetricXX instead.")]
        public static readonly AnalyticsMetric MetricXX = Metrics.AnalyticsMetrics.MetricXX;

        #endregion

        #region DoubleClick Campaign Manager

        /// <summary>
        /// Gets the number of DCM Floodlight conversions (premium only) (id: <code>ga:dcmFloodlightQuantity)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmfloodlightquantity</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.DcmFloodlightQuantity instead.")]
        public static readonly AnalyticsMetric DcmFloodlightQuantity = Metrics.AnalyticsMetrics.DcmFloodlightQuantity;

        /// <summary>
        /// DCM Floodlight revenue (premium only) (id: <code>ga:dcmFloodlightRevenue)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmfloodlightrevenue</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.DcmFloodlightRevenue instead.")]
        public static readonly AnalyticsMetric DcmFloodlightRevenue = Metrics.AnalyticsMetrics.DcmFloodlightRevenue;

        /// <summary>
        /// DCM Cost Per Click (premium only) (id: <code>ga:dcmCPC)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmcpc</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.DcmCPC instead.")]
        public static readonly AnalyticsMetric DcmCPC = Metrics.AnalyticsMetrics.DcmCPC;

        /// <summary>
        /// DCM Click Through Rate (premium only) (id: <code>ga:dcmCTR)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmctr</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.DcmCTR instead.")]
        public static readonly AnalyticsMetric DcmCTR = Metrics.AnalyticsMetrics.DcmCTR;

        /// <summary>
        /// DCM Total Clicks (premium only) (id: <code>ga:dcmClicks)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclicks</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.DcmClicks instead.")]
        public static readonly AnalyticsMetric DcmClicks = Metrics.AnalyticsMetrics.DcmClicks;

        /// <summary>
        /// DCM Total Cost (premium only) (id: <code>ga:dcmCost)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmcost</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.DcmCost instead.")]
        public static readonly AnalyticsMetric DcmCost = Metrics.AnalyticsMetrics.DcmCost;

        /// <summary>
        /// DCM Total Impressions (premium only) (id: <code>ga:dcmImpressions)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmimpressions</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.DcmImpressions instead.")]
        public static readonly AnalyticsMetric DcmImpressions = Metrics.AnalyticsMetrics.DcmImpressions;

        /// <summary>
        /// This metric is deprecated and will be removed soon. Please use <code>ga:dcmROAS</code> instead (id: <code>ga:dcmMargin)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmmargin</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.DcmMargin instead.")]
        public static readonly AnalyticsMetric DcmMargin = Metrics.AnalyticsMetrics.DcmMargin;

        /// <summary>
        /// DCM Return On Ad Spend (ROAS) (premium only) (id: <code>ga:dcmROAS)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmroas</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.DcmROAS instead.")]
        public static readonly AnalyticsMetric DcmROAS = Metrics.AnalyticsMetrics.DcmROAS;

        /// <summary>
        /// This metric is deprecated and will be removed soon. Please use <code>ga:dcmROAS</code> instead (id: <code>ga:dcmROI)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmroi</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.DcmROI instead.")]
        public static readonly AnalyticsMetric DcmROI = Metrics.AnalyticsMetrics.DcmROI;

        /// <summary>
        /// DCM Revenue Per Click (premium only) (id: <code>ga:dcmRPC)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmrpc</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.DcmRPC instead.")]
        public static readonly AnalyticsMetric DcmRPC = Metrics.AnalyticsMetrics.DcmRPC;

        #endregion

        #region Adsense

        /// <summary>
        /// Gets the total revenue from AdSense ads (id: <code>ga:adsenseRevenue)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsenserevenue</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdsenseRevenue instead.")]
        public static readonly AnalyticsMetric AdsenseRevenue = Metrics.AnalyticsMetrics.AdsenseRevenue;

        /// <summary>
        /// Gets the number of AdSense ad units viewed. An Ad unit is a set of ads displayed as a result of one piece of the AdSense ad code. Details: https://support.google.com/adsense/answer/32715?hl=en (id: <code>ga:adsenseAdUnitsViewed)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsenseadunitsviewed</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdsenseAdUnitsViewed instead.")]
        public static readonly AnalyticsMetric AdsenseAdUnitsViewed = Metrics.AnalyticsMetrics.AdsenseAdUnitsViewed;

        /// <summary>
        /// Gets the number of AdSense ads viewed. Multiple ads can be displayed within an Ad Unit (id: <code>ga:adsenseAdsViewed)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsenseadsviewed</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdsenseAdsViewed instead.")]
        public static readonly AnalyticsMetric AdsenseAdsViewed = Metrics.AnalyticsMetrics.AdsenseAdsViewed;

        /// <summary>
        /// Gets the number of times AdSense ads on your site were clicked (id: <code>ga:adsenseAdsClicks)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsenseadsclicks</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdsenseAdsClicks instead.")]
        public static readonly AnalyticsMetric AdsenseAdsClicks = Metrics.AnalyticsMetrics.AdsenseAdsClicks;

        /// <summary>
        /// Gets the number of pageviews during which an AdSense ad was displayed. A page impression can have multiple Ad Units (id: <code>ga:adsensePageImpressions)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsensepageimpressions</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdsensePageImpressions instead.")]
        public static readonly AnalyticsMetric AdsensePageImpressions = Metrics.AnalyticsMetrics.AdsensePageImpressions;

        /// <summary>
        /// Gets the percentage of page impressions that resulted in a click on an AdSense ad (id: <code>ga:adsenseCTR)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsensectr</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdsenseCTR instead.")]
        public static readonly AnalyticsMetric AdsenseCTR = Metrics.AnalyticsMetrics.AdsenseCTR;

        /// <summary>
        /// Gets the estimated cost per thousand page impressions. It is your AdSense Revenue per 1000 page impressions (id: <code>ga:adsenseECPM)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsenseecpm</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdsenseECPM instead.")]
        public static readonly AnalyticsMetric AdsenseECPM = Metrics.AnalyticsMetrics.AdsenseECPM;

        /// <summary>
        /// Gets the number of sessions that ended due to a user clicking on an AdSense ad (id: <code>ga:adsenseExits)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsenseexits</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdsenseExits instead.")]
        public static readonly AnalyticsMetric AdsenseExits = Metrics.AnalyticsMetrics.AdsenseExits;

        /// <summary>
        /// Gets the percentage of impressions that were viewable (id: <code>ga:adsenseViewableImpressionPercent)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsenseviewableimpressionpercent</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdsenseViewableImpressionPercent instead.")]
        public static readonly AnalyticsMetric AdsenseViewableImpressionPercent = Metrics.AnalyticsMetrics.AdsenseViewableImpressionPercent;

        /// <summary>
        /// Gets the percentage of ad requests that returned at least one ad (id: <code>ga:adsenseCoverage)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsensecoverage</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdsenseCoverage instead.")]
        public static readonly AnalyticsMetric AdsenseCoverage = Metrics.AnalyticsMetrics.AdsenseCoverage;

        #endregion

        #region Ad Exchange

        /// <summary>
        /// An AdX ad impression is reported whenever an individual ad is displayed on your website. For example, if a page with two ad units is viewed once, we'll display two impressions (id: <code>ga:adxImpressions)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adximpressions</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdxImpressions instead.")]
        public static readonly AnalyticsMetric AdxImpressions = Metrics.AnalyticsMetrics.AdxImpressions;

        /// <summary>
        /// Coverage is the percentage of ad requests that returned at least one ad. Generally, coverage can help you identify sites where your AdX account isn't able to provide targeted ads. (Ad Impressions / Total Ad Requests) * 100 (id: <code>ga:adxCoverage)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adxcoverage</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdxCoverage instead.")]
        public static readonly AnalyticsMetric AdxCoverage = Metrics.AnalyticsMetrics.AdxCoverage;

        /// <summary>
        /// Monetized Pageviews measures the total number of pageviews on your property that were shown with an ad from your linked AdX account. Note - a single page can have multiple ad units (id: <code>ga:adxMonetizedPageviews)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adxmonetizedpageviews</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdxMonetizedPageviews instead.")]
        public static readonly AnalyticsMetric AdxMonetizedPageviews = Metrics.AnalyticsMetrics.AdxMonetizedPageviews;

        /// <summary>
        /// Gets the ratio of AdX ad impressions to Analytics sessions (Ad Impressions / Analytics Sessions) (id: <code>ga:adxImpressionsPerSession)</code>, type: <code>float)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adximpressionspersession</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdxImpressionsPerSession instead.")]
        public static readonly AnalyticsMetric AdxImpressionsPerSession = Metrics.AnalyticsMetrics.AdxImpressionsPerSession;

        /// <summary>
        /// Gets the percentage of ad impressions that were viewable. An impression is considered a viewable impression when it has appeared within a user's browser and had the opportunity to be seen (id: <code>ga:adxViewableImpressionsPercent)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adxviewableimpressionspercent</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdxViewableImpressionsPercent instead.")]
        public static readonly AnalyticsMetric AdxViewableImpressionsPercent = Metrics.AnalyticsMetrics.AdxViewableImpressionsPercent;

        /// <summary>
        /// Gets the number of times AdX ads were clicked on your site (id: <code>ga:adxClicks)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adxclicks</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdxClicks instead.")]
        public static readonly AnalyticsMetric AdxClicks = Metrics.AnalyticsMetrics.AdxClicks;

        /// <summary>
        /// Gets the percentage of pageviews that resulted in a click on an AdX ad (id: <code>ga:adxCTR)</code>, type: <code>percent)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adxctr</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdxCTR instead.")]
        public static readonly AnalyticsMetric AdxCTR = Metrics.AnalyticsMetrics.AdxCTR;

        /// <summary>
        /// Gets the total estimated revenue from AdX ads (id: <code>ga:adxRevenue)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adxrevenue</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdxRevenue instead.")]
        public static readonly AnalyticsMetric AdxRevenue = Metrics.AnalyticsMetrics.AdxRevenue;

        /// <summary>
        /// Gets the total estimated revenue from AdX ads per 1000 Analytics sessions. Note that this metric is based on sessions to your site and not ad impressions (id: <code>ga:adxRevenuePer1000Sessions)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adxrevenueper1000sessions</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdxRevenuePer1000Sessions instead.")]
        public static readonly AnalyticsMetric AdxRevenuePer1000Sessions = Metrics.AnalyticsMetrics.AdxRevenuePer1000Sessions;

        /// <summary>
        /// Gets the effective cost per thousand pageviews. It is your AdX Revenue per 1000 pageviews (id: <code>ga:adxECPM)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adxecpm</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.AdxECPM instead.")]
        public static readonly AnalyticsMetric AdxECPM = Metrics.AnalyticsMetrics.AdxECPM;

        #endregion

        #region Related Products

        /// <summary>
        /// Correlation Score for related products (id: <code>ga:correlationScore)</code>, type: <code>currency)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_correlationscore</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.CorrelationScore instead.")]
        public static readonly AnalyticsMetric CorrelationScore = Metrics.AnalyticsMetrics.CorrelationScore;

        /// <summary>
        /// Quantity of the product being queried (id: <code>ga:queryProductQuantity)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_queryproductquantity</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.QueryProductQuantity instead.")]
        public static readonly AnalyticsMetric QueryProductQuantity = Metrics.AnalyticsMetrics.QueryProductQuantity;

        /// <summary>
        /// Quantity of the related product (id: <code>ga:relatedProductQuantity)</code>, type: <code>integer)</code>.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_relatedproductquantity</cref>
        /// </see>
        [Obsolete("Use AnalyticsMetrics.RelatedProductQuantity instead.")]
        public static readonly AnalyticsMetric RelatedProductQuantity = Metrics.AnalyticsMetrics.RelatedProductQuantity;

        #endregion

        #region Realtime

        public static readonly AnalyticsMetric ActiveVisitors = new AnalyticsMetric("ga:activeVisitors");

        #endregion

        // ReSharper restore InconsistentNaming

        #endregion

        #region Static properties

        /// <summary>
        /// Gets an array of all metrics.
        /// </summary>
        public static AnalyticsMetric[] Values {
            get {
                return (
                    from property in typeof(AnalyticsMetric).GetFields(BindingFlags.Public | BindingFlags.Static)
                    select (AnalyticsMetric)property.GetValue(null)
                ).ToArray();
            }
        }

        #endregion

        #region Member properties

        /// <summary>
        /// Gets the name of the metric.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the name of the group of the metric.
        /// </summary>
        public string GroupName { get; private set; }

        /// <summary>
        /// Gets whether the metric is obsolete.
        /// </summary>
        public bool IsObsolete { get; private set; }

        #endregion

        #region Constructor

        internal AnalyticsMetric(string name) {
            Name = name;
        }

        internal AnalyticsMetric(string name, string groupName) {
            Name = name;
            GroupName = groupName;
        }

        internal AnalyticsMetric(string name, string groupName, bool obsolete) {
            Name = name;
            GroupName = groupName;
            IsObsolete = obsolete;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets the name of the metric (eg. "ga:visits").
        /// </summary>
        public override string ToString() {
            return Name;
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Attempts to parse the specified string as a metric. The parsing is done against a list
        /// of known metrics. If the parsing fails, an exception will be thrown.
        /// </summary>
        /// <param name="str">The string to parse.</param>
        public static AnalyticsMetric Parse(string str) {
            AnalyticsMetric metric;
            if (TryParse(str, out metric)) return metric;
            throw new Exception("Invalid metric '" + str + "'");
        }

        /// <summary>
        /// Attempts to parse the specified string as a metric. The parsing is done against a list
        /// of known metrics. The method will return TRUE if the parsing succeeds, otherwise FALSE.
        /// </summary>
        /// <param name="str">The string to parse.</param>
        /// <param name="metric">The parsed metric.</param>
        public static bool TryParse(string str, out AnalyticsMetric metric) {
            metric = Values.FirstOrDefault(temp => temp.Name == str);
            return metric != null;
        }

        #endregion

        #region Operator overloading

        /// <summary>
        /// Gets a reference to the metric with the specified <code>name</code>. If an unknown
        /// metric is specified, a new instance of <code>AnalyticsMetric</code> will be initialized.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        public static implicit operator AnalyticsMetric(string name) {
            AnalyticsMetric metric;
            return TryParse(name, out metric) ? metric : new AnalyticsMetric(name);
        }

        /// <summary>
        /// Initializes a new instance of <code>AnalyticsMetricCollection</code> containing both <code>left</code> and <code>right</code>.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static AnalyticsMetricCollection operator +(AnalyticsMetric left, AnalyticsMetric right) {
            return new AnalyticsMetricCollection(left, right);
        }

        #endregion

    }

}