using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using UccxStats.AgentStats;

namespace UccxStats.Test
{
    [TestClass]
    public class AgentCsqStatTest : StatTestBase
    {
        private readonly AgentCSQStats _queue;

        public AgentCsqStatTest() : base("AgentCSQStats.json")
        {
            _queue = Stats.GetAgentCsqStats().Result.First();
        }

        [TestMethod]
        public void AgentCsqNameTest()
        {
            Assert.AreEqual("Payments", _queue.CsqName);
        }

        [TestMethod]
        public void AgentCsqCurrentWaitingCallsTest()
        {
            Assert.AreEqual(3, _queue.CurrentWaitingCalls);
        }

        [TestMethod]
        public void AgentCsqCurrentOldestTest()
        {
            Assert.AreEqual(9500, _queue.CurrentOldest);
        }

        [TestMethod]
        public void AgentCsqAgentIdTest()
        {
            Assert.AreEqual("ewoods",_queue.AgentIds[0].AgentId);
        }

        [TestMethod]
        public void AgentCsqNoQueues()
        {
            Stats = new UccxStats(new MockStats("[]"));

            var queues = Stats.GetAgentCsqStats().Result.ToList();

            Assert.AreEqual(0, queues.Count);
        }
    }
}
