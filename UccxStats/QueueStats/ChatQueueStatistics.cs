
namespace UccxStats.QueueStats
{
    /// <summary>
    /// Statistics related to a chat queue.
    /// </summary>
    public class ChatQueueStatistics
    {
        public int QueueId { get; set; }
        public string QueueName { get; set; }
        public int AgentsLoggedIn { get; set; }
        public int AgentsBusy { get; set; }
        public int AgentsAvailable { get; set; }
        public int AgentsReady { get; set; }
        public int AgentsNotReady { get; set; }
        public int AgentsReserved { get; set; }
        public int ContactsTotal { get; set; }
        public int ContactsQueued { get; set; }
        public int ContactsHandled { get; set; }
        public int ContactsAbandoned { get; set; }
        public int ContactsInProcess { get; set; }
    }
}
