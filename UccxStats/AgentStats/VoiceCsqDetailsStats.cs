using System.Collections.Generic;
using Newtonsoft.Json;

namespace UccxStats.AgentStats
{
    /// <summary>
    /// Basic statistics related to a resource (agent).
    /// </summary>
    [JsonConverter(typeof(VoiceCSQDetailConverter))]
    public class VoiceCSQDetailsStats
    {
        public string AgentId { get; set; }
        public string AgentName { get; set; }
        public string AgentState { get; set; }
        public string SkillGroup { get; set; }
        public int AgentStateDuration { get; set; }
        public string Reason { get; set; }
        public List<AgentVoiceCSQNames> AgentVoiceCsqNames { get; set; }
    }
}