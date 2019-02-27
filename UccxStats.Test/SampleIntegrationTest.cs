using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UccxStats.Test
{
    /*
    [TestClass]
    public class SampleIntegrationTest
    {
        private readonly UccxStats _stats = new UccxStats(new UccxStatSource("198.18.133.19"));

        [TestMethod]
        public void AgentDetailsIntegrationTest()
        {
            var agents = _stats.GetResourceIaqStats().Result.ToList();

            foreach (var agent in agents)
            {
                Assert.IsNotNull(agent.ResourceId);
                Assert.IsNotNull(agent.ResourceName);
                Assert.IsNotNull(agent.ResourceState);
            }
        }

        [TestMethod]
        public void AgentCsqIntegrationTest()
        {
            var queues = _stats.GetAgentCsqStats().Result.ToList();

            foreach (var q in queues)
            {
                Assert.IsNotNull(q.CsqName);
            }
        }

        [TestMethod]
        public void GetVoiceCsqDetailsIntegrationTest()
        {
            var agents = _stats.GetVoiceCsqDetailsStats().Result.ToList();

            foreach (var a in agents)
            {
                Assert.IsNotNull(a.AgentId);
                Assert.IsNotNull(a.AgentName);
                Assert.IsNotNull(a.AgentState);
            }
        }

        [TestMethod]
        public void GetVoiceIaqIntegrationTest()
        {
            var queues = _stats.GetVoiceIaqStats().Result.ToList();

            foreach (var q in queues)
            {
                Assert.IsNotNull(q.Id);
                Assert.IsNotNull(q.EsdName);
            }
        }

        [TestMethod]
        public void GetEmailQueueIntegrationTest()
        {
            var emailQueues = _stats.GetEmailQueueStats().Result.ToList();

            foreach (var q in emailQueues)
            {
                Assert.IsNotNull(q.QueueId);
                Assert.IsNotNull(q.QueueName);
            }
        }

        [TestMethod]
        public void GetChatQueueIntegrationTest()
        {
            var chatQueues = _stats.GetChatQueueStats().Result.ToList();

            foreach (var q in chatQueues)
            {
                Assert.IsNotNull(q.QueueId);
                Assert.IsNotNull(q.QueueName);
            }
        }
    }
    */
}
