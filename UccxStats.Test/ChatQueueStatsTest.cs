using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UccxStats.QueueStats;

namespace UccxStats.Test
{
    [TestClass]
    public class ChatQueueStatsTest : StatTestBase
    {
        private readonly ChatQueueStatistics _queue;

        public ChatQueueStatsTest() : base("ChatQueueStats.json")
        {
            _queue = Stats.GetChatQueueStats().Result.First();
        }

        [TestMethod]
        public void ChatQueueQueueIdTest()
        {
            Assert.AreEqual(27, _queue.QueueId);
        }

        [TestMethod]
        public void ChatQueueQueueNameTest()
        {
            Assert.AreEqual("Repairs", _queue.QueueName);
        }

        [TestMethod]
        public void ChatQueueAgentsLoggeInTest()
        {
            Assert.AreEqual(1, _queue.AgentsLoggedIn);
        }

        [TestMethod]
        public void ChatQueueAgentsBusyTest()
        {
            Assert.AreEqual(1, _queue.AgentsBusy);
        }

        [TestMethod]
        public void ChatQueueAgentsAvailable()
        {
            Assert.AreEqual(1, _queue.AgentsAvailable);
        }

        [TestMethod]
        public void ChatQueueAgentsReadyTest()
        {
            Assert.AreEqual(1, _queue.AgentsReady);
        }

        [TestMethod]
        public void ChatQueueAgentsNotReadyTest()
        {
            Assert.AreEqual(1, _queue.AgentsNotReady);
        }

        [TestMethod]
        public void ChatQueueAgentsReserved()
        {
            Assert.AreEqual(1, _queue.AgentsReserved);
        }

        [TestMethod]
        public void ChatQueueContactsTotalTest()
        {
            Assert.AreEqual(1, _queue.ContactsTotal);
        }

        [TestMethod]
        public void ChatQueueContactsQueue()
        {
            Assert.AreEqual(1, _queue.ContactsQueued);
        }

        [TestMethod]
        public void ChatQueueContactsHandled()
        {
            Assert.AreEqual(1, _queue.ContactsHandled);
        }

        [TestMethod]
        public void ChatQueueContactsAbandoned()
        {
            Assert.AreEqual(1, _queue.ContactsAbandoned);
        }

        [TestMethod]
        public void ChatQueueContactsInProgress()
        {
            Assert.AreEqual(1, _queue.ContactsInProcess);
        }

        [TestMethod]
        public void ChatQueueStatsQueues()
        {
            var queues = Stats.GetChatQueueStats().Result.ToList();

            Assert.AreEqual(1, queues.Count(x => x.QueueName.Equals("Chat Recall")));
            Assert.AreEqual(1, queues.Count(x => x.QueueName.Equals("Chat")));
            Assert.AreEqual(1, queues.Count(x => x.QueueName.Equals("Repairs")));
        }

        [TestMethod]
        public void ChatQueueStatsPropertyValues()
        {
            var queues = Stats.GetChatQueueStats().Result.ToList();

            var queue = queues.First(x => x.QueueName.Equals("Repairs"));

            Assert.AreEqual(27, queue.QueueId);
            Assert.AreEqual(1, queue.AgentsLoggedIn);
            Assert.AreEqual(1, queue.AgentsBusy);
            Assert.AreEqual(1, queue.AgentsAvailable);
            Assert.AreEqual(1, queue.AgentsReady);
            Assert.AreEqual(1, queue.AgentsNotReady);
            Assert.AreEqual(1, queue.AgentsReserved);
            Assert.AreEqual(1, queue.ContactsTotal);
            Assert.AreEqual(1, queue.ContactsQueued);
            Assert.AreEqual(1, queue.ContactsHandled);
            Assert.AreEqual(1, queue.ContactsAbandoned);
            Assert.AreEqual(1, queue.ContactsInProcess);
        }

        [TestMethod]
        public void ChatQueueStatsNoQueues()
        {
            Stats = new UccxStats(new MockStats("[]"));

            var queues = Stats.GetChatQueueStats().Result.ToList();

            Assert.AreEqual(0, queues.Count);
        }
    }
}
