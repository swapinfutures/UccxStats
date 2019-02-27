
namespace UccxStats.AgentStats
{
    /// <summary>
    /// Detailed statistics related to a resource (agent).
    /// </summary>
    public class ResourceIAQStats
    {
        public string ResourceId { get; set; }
        public string ResourceName { get; set; }
        public int ResourceState { get; set; }
        public string StrResourceState { get; set; }
        public int DurationInStateMillis { get; set; }
        public int NHandledContacts { get; set; }
        public int NPresentedContacts { get; set; }
        public int AvgTalkDuration { get; set; }
        public int LongestTalkDuration { get; set; }
        public int AvgHoldDuration { get; set; }
        public int LongestHoldDuration { get; set; }
        public int AvgHandleDuration { get; set; }
        public int AvgWorkDuration { get; set; }
        public int TotalTalkTime { get; set; }
        public int TotalHoldTime { get; set; }
        public int MaxReadyTime { get; set; }
        public int AvgReadyTime { get; set; }
        public int TotalReadyTime { get; set; }
        public int MaxNotReadyTime { get; set; }
        public int AvgNotReadyTime { get; set; }
        public int TotalNotReadyTime { get; set; }
        public int MaxWorkTime { get; set; }
        public int TotalWorkTime { get; set; }
        public int LogonDuration { get; set; }
        public int TotalReservedTime { get; set; }
        public int OtherTime { get; set; }
        public int AvgSpeedOfAnswer { get; set; }
        public int RsrcCurrentStateReasonCode { get; set; }
        public string RsrcCurrentStateReason { get; set; }
        public int NOutboundOfferedContacts { get; set; }
        public int NOutboundActiveOfferedContacts { get; set; }
        public int NOutboundTimedOutContacts { get; set; }
        public int NOutboundVoiceContacts { get; set; }
        public int NOutboundAcceptedContacts { get; set; }
        public int NOutboundActiveVoiceContacts { get; set; }
        public int NOutboundActiveAcceptedContacts { get; set; }
        public int NOutboundRejectedContacts { get; set; }
        public int NOutboundClosedContacts { get; set; }
        public int AvgOutboundTalkDuration { get; set; }
        public int ActiveOutboundTalkDuration { get; set; }
        public int AvgOutboundHoldDuration { get; set; }
        public int ActiveOutboundHoldDuration { get; set; }
        public int LongestOutboundTalkDuration { get; set; }
        public int LongestOutboundHoldDuration { get; set; }
        public int TotalOutboundTalkTime { get; set; }
        public int TotalOutboundHoldTime { get; set; }
        public int AvgOutboundWorkTime { get; set; }
        public int MaxOutboundWorkTime { get; set; }
        public int TotalOutboundWorkTime { get; set; }
        public int AvgOutboundTalkWindow1 { get; set; }
        public int AvgOutboundHoldWindow1 { get; set; }
        public int AvgOutboundTalkWindow2 { get; set; }
        public int AvgOutboundHoldWindow2 { get; set; }
        public int NOutboundHandledContacts { get; set; }
        public int AvgTalkingWindow1 { get; set; }
        public int AvgHoldWindow1 { get; set; }
        public int AvgTalkingWindow2 { get; set; }
        public int AvgHoldWindow2 { get; set; }
    }
}
