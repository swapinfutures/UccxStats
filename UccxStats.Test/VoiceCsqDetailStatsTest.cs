using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UccxStats.AgentStats;

namespace UccxStats.Test
{
    [TestClass]
    public class VoiceCsqDetailStatsTest : StatTestBase
    {
        private readonly VoiceCSQDetailsStats _agent;

        public VoiceCsqDetailStatsTest() : base("VoiceCSQDetailStats.json")
        {
            _agent = Stats.GetVoiceCsqDetailsStats().Result.First();
        }

        [TestMethod]
        public void VoiceCsqDetailStatsAgentIdTest()
        {
            Assert.AreEqual("zbryan", _agent.AgentId);
        }

        [TestMethod]
        public void VoiceCsqDetailStatsAgentName()
        {
            Assert.AreEqual("Zak Bryan", _agent.AgentName);
        }

        [TestMethod]
        public void VoiceCsqDetailStatsAgentState()
        {
            Assert.AreEqual("Not Ready", _agent.AgentState);
        }

        [TestMethod]
        public void VoiceCsqDetailSkillGroup()
        {
            Assert.AreEqual("SG1", _agent.SkillGroup);
        }

        [TestMethod]
        public void VoiceCsqDetailAgentStateDuration()
        {
            Assert.AreEqual(12608, _agent.AgentStateDuration);
        }

        [TestMethod]
        public void VoiceCsqDetailReason()
        {
            Assert.AreEqual("Training", _agent.Reason);
        }

        [TestMethod]
        public void VoiceCsqCsqNames()
        {
            Assert.AreEqual("Spare Parts", _agent.AgentVoiceCsqNames[0].AgentVoiceCsqName);
        }

        [TestMethod]
        public void VoiceCsqDetailStasNoAgents()
        {
            Stats = new UccxStats(new MockStats("[]"));

            var queues = Stats.GetVoiceCsqDetailsStats().Result.ToList();

            Assert.AreEqual(0, queues.Count);
        }
    }
}
