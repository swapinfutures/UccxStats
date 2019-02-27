using System.Collections.Generic;

namespace UccxStats.QueueStats
{   /// <summary>
    /// Detailed statistics related to a queue
    /// </summary>
    public class VoiceIAQStats
    {
        public int Id { get; set; }
        public int EsdId { get; set; }
        public string EsdName { get; set; }
        public int NResourcesLoggedIn { get; set; }
        public int NTotalContacts { get; set; }
        public int NHandledContacts { get; set; }
        public int NAbandonedContacts { get; set; }
        public int NDequeuedContacts { get; set; }
        public int AvgTalkDuration { get; set; }
        public int LongestTalkDuration { get; set; }
        public int AvgWaitDuration { get; set; }
        public int LongestWaitDuration { get; set; }
        public int LongestCurrentlyWaitingDuration { get; set; }
        public int NAvailResources { get; set; }
        public int NInSessionResources { get; set; }
        public int PreviewObInSessionCount { get; set; }
        public int PreviewObReserveStateCount { get; set; }
        public int NUnavailResources { get; set; }
        public Dictionary<int, int> NUnavailResReasonsMap { get; set; }
        public int NWorkResources { get; set; }
        public int NSelectedResources { get; set; }
        public int NWaitingContacts { get; set; }
        public double NAverageHandlingTimeLowThreshold { get; set; }
        public double NAverageHandlingTimeHighThreshold { get; set; }
        public double NAverageWaitingTimeLowThreshold { get; set; }
        public double NAverageWaitingTimeHighThreshold { get; set; }
        public double NAbandonedCallsLowThreshold { get; set; }
        public double NAbandonedCallsHighThreshold { get; set; }
        public double NDequeuedCallsLowThreshold { get; set; }
        public double NDequeuedCallsHighThreshold { get; set; }
        public double NSlaPercentageLowThreshold { get; set; }
        public double NSlaPercentageHighThreshold { get; set; }
    }
}