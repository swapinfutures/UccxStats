using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UccxStats.AgentStats;
using UccxStats.QueueStats;

namespace UccxStats
{
    /// <summary>
    /// Primary class for querying UCCX statistics
    /// </summary>
    public class UccxStats
    {
        private IStatSource StatSource { get; }

        /// <summary>
        /// The class constructor. 
        /// </summary>
        public UccxStats(IStatSource statRetriever)
        {
            StatSource = statRetriever ?? throw new ArgumentNullException(nameof(statRetriever));
        }
        
        /// <summary>
        /// Retrieves basic agent information, including queue membership.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<VoiceCSQDetailsStats>> GetVoiceCsqDetailsStats()
        {
            return await StatSource.GetStatsAsync<VoiceCSQDetailsStats>(ApiPath.VoiceCSQDetailsStats.ToString());
        }

        /// <summary>
        /// Retrieves a collection of basic queue information, including agent membership.
        /// </summary>
        public async Task<IEnumerable<AgentCSQStats>> GetAgentCsqStats()
        {
            return await StatSource.GetStatsAsync<AgentCSQStats>(ApiPath.AgentCSQStats.ToString());
        }

        /// <summary>
        /// Retrieves a collection of detailed agent statistics.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ResourceIAQStats>> GetResourceIaqStats()
        {
            return await StatSource.GetStatsAsync<ResourceIAQStats>(ApiPath.ResourceIAQStats.ToString());
        }

        /// <summary>
        /// Retrieves a collection of detailed queue statistics.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<VoiceIAQStats>> GetVoiceIaqStats()
        {
            return await StatSource.GetStatsAsync<VoiceIAQStats>(ApiPath.VoiceIAQStats.ToString());
        }

        /// <summary>
        /// Retrieves a collection of email statistics by queue.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EmailQueueStatistics>> GetEmailQueueStats()
        {
            return await StatSource.GetStatsAsync<EmailQueueStatistics>(ApiPath.EmailQueueStatistics.ToString());
        }

        /// <summary>
        /// Retrieves a collection of chat statistics by queue.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ChatQueueStatistics>> GetChatQueueStats()
        {
            return await StatSource.GetStatsAsync<ChatQueueStatistics>(ApiPath.ChatQueueStatistics.ToString());
        }

        private enum ApiPath
        {
            VoiceIAQStats,
            ResourceIAQStats,
            AgentCSQStats,
            VoiceCSQDetailsStats,
            EmailQueueStatistics,
            ChatQueueStatistics
        }
    }
}
