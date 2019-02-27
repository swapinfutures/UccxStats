using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UccxStats.QueueStats;

namespace UccxStats.Test
{
    [TestClass]
    public class EmailQueueStatsTest : StatTestBase
    {
        private readonly EmailQueueStatistics _queue;

        public EmailQueueStatsTest() : base("EmailQueueStats.json")
        {
            _queue = Stats.GetEmailQueueStats().Result.First();
        }

   

        [TestMethod]
        public void EmailQueueStatsQueueId()
        {
            Assert.AreEqual(21, _queue.QueueId);
        }

        [TestMethod]
        public void EmailQueueStatsQueueName()
        {
            Assert.AreEqual("FinesseEmail_CSQ", _queue.QueueName);
        }

        [TestMethod]
        public void EmailQueueStatsAgentsLoggedInTest()
        {
            Assert.AreEqual(1, _queue.AgentsLoggedIn);
        }

        [TestMethod]
        public void EmailQueueStatsAgentsBusy()
        {
            Assert.AreEqual(1, _queue.AgentsBusy);
        }

        [TestMethod]
        public void EmailQueueStatsAgentsAvailable()
        {
            Assert.AreEqual(1, _queue.AgentsAvailable);
        }

        [TestMethod]
        public void EmailQueueStatsAgentsReady()
        {
            Assert.AreEqual(1, _queue.AgentsReady);
        }

        [TestMethod]
        public void EmailQueueStatsAgentsNotReadyTest()
        {
            Assert.AreEqual(1, _queue.AgentsNotReady);
        }

        [TestMethod]
        public void EmailQueueStatsAgentsReserved()
        {
            Assert.AreEqual(1, _queue.AgentsReserved);
        }

        [TestMethod]
        public void EmailQueueStatsContactsTotal()
        {
            Assert.AreEqual(1, _queue.ContactsTotal);
        }

        [TestMethod]
        public void EmailQueueStatsContactsQueue()
        {
            Assert.AreEqual(1, _queue.ContactsQueued);
        }

        [TestMethod]
        public void EmailQueueStatsContactsHandled()
        {
            Assert.AreEqual(1, _queue.ContactsHandled);
        }

        [TestMethod]
        public void EmailQueueStatsContactsAbandoned()
        {
            Assert.AreEqual(1, _queue.ContactsAbandoned);
        }

        [TestMethod]
        public void EmailQueueStatsContactsInProgress()
        {
            Assert.AreEqual(1, _queue.ContactsInProcess);
        }
    }
}
