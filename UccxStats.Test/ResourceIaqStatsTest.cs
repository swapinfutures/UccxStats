using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UccxStats.AgentStats;

namespace UccxStats.Test
{
    [TestClass]
    public class ResourceIaqStatsTest : StatTestBase
    {
        private readonly ResourceIAQStats _agent;

        public ResourceIaqStatsTest() : base("ResourceIAQStats.json")
        {
            _agent = Stats.GetResourceIaqStats().Result.First();
        }

        [TestMethod]
        public void ResourceIaqResourceIdTest()
        {
            Assert.AreEqual("zbryan", _agent.ResourceId);
        }

        [TestMethod]
        public void ResourceIaqResourceName()
        {
            Assert.AreEqual("Zak Bryan", _agent.ResourceName);
        }

        [TestMethod]
        public void ResourceIaqResourceState()
        {
            Assert.AreEqual(5, _agent.ResourceState);
        }

        [TestMethod]
        public void ResourceIaqDurationInStateMillis()
        {
            Assert.AreEqual(61799, _agent.DurationInStateMillis);
        }

        [TestMethod]
        public void ResourceIaqNHandledContacts()
        {
            Assert.AreEqual(338, _agent.NHandledContacts);
        }

        [TestMethod]
        public void ResourceIaqNPresentedContacts()
        {
            Assert.AreEqual(341, _agent.NPresentedContacts);
        }

        [TestMethod]
        public void ResourceIaqAvgTalkDuration()
        {
            Assert.AreEqual(76002, _agent.AvgTalkDuration);
        }

        [TestMethod]
        public void ResourceIaqLongestTalkDuration()
        {
            Assert.AreEqual(117762, _agent.LongestTalkDuration);
        }

        [TestMethod]
        public void ResourceIaqAvgHoldDuration()
        {
            Assert.AreEqual(1532, _agent.AvgHoldDuration);
        }

        [TestMethod]
        public void ResourceIaqLongestHoldDuration()
        {
            Assert.AreEqual(1601, _agent.LongestHoldDuration);
        }

        [TestMethod]
        public void ResourceIaqAvgHandleDuration()
        {
            Assert.AreEqual(658468, _agent.AvgHandleDuration);
        }

        [TestMethod]
        public void ResourceIaqAvgWorkDuration()
        {
            Assert.AreEqual(11181, _agent.AvgWorkDuration);
        }

        [TestMethod]
        public void ResourceIaqTotalTalkTime()
        {
            Assert.AreEqual(25684063, _agent.TotalTalkTime);
        }

        [TestMethod]
        public void ResourceIaqTotalHoldTime()
        {
            Assert.AreEqual(6813, _agent.TotalHoldTime);
        }

        [TestMethod]
        public void ResourceIaqMaxReadyTime()
        {
            Assert.AreEqual(2141551, _agent.MaxReadyTime);
        }

        [TestMethod]
        public void ResourceIaqAvgReadyTime()
        {
            Assert.AreEqual(90497, _agent.AvgReadyTime);
        }

        [TestMethod]
        public void ResourceIaqTotalReadyTime()
        {
            Assert.AreEqual(30769074, _agent.TotalReadyTime);
        }

        [TestMethod]
        public void ResourceIaqMaxNotReadyTime()
        {
            Assert.AreEqual(46006, _agent.MaxNotReadyTime);   
        }

        [TestMethod]
        public void ResourceIaqAvgNotReadyTime()
        {
            Assert.AreEqual(31046, _agent.AvgNotReadyTime);
        }

        [TestMethod]
        public void ResourceIaqTotalNotReadyTime()
        {
            Assert.AreEqual(10462627, _agent.TotalNotReadyTime);
        }

        [TestMethod]
        public void ResourceIaqMaxWorkTime()
        {
            Assert.AreEqual(20981, _agent.MaxWorkTime);
        }

        [TestMethod]
        public void ResourceIaqTotalWorkTime()
        {
            Assert.AreEqual(2843629, _agent.TotalWorkTime);
        }

        [TestMethod]
        public void ResourceIaqLogOnDuration()
        {
            Assert.AreEqual(70991718, _agent.LogonDuration);
        }

        [TestMethod]
        public void ResourceIaqTotalReservedTime()
        {
            Assert.AreEqual(6546, _agent.TotalReservedTime);
        }

        [TestMethod]
        public void ResourceIaqStatsOtherTime()
        {
            Assert.AreEqual(1377, _agent.OtherTime);
        }

        [TestMethod]
        public void ResourceIaqAvgSpeedOfAnswer()
        {
            Assert.AreEqual(3501, _agent.AvgSpeedOfAnswer);
        }

        [TestMethod]
        public void ResourceIaqCurrentStateReasonCode()
        {
            Assert.AreEqual(1, _agent.RsrcCurrentStateReasonCode);
        }

        [TestMethod]
        public void ResourceIaqCurrentStateReason()
        {
            Assert.AreEqual("Training", _agent.RsrcCurrentStateReason);
        }

        [TestMethod]
        public void ResourceIaqOutboundOfferedContacts()
        {
            Assert.AreEqual(1, _agent.NOutboundOfferedContacts);
        }

        [TestMethod]
        public void ResourceIaqOutboundActiveOfferedContacts()
        {
            Assert.AreEqual(1, _agent.NOutboundActiveOfferedContacts);
        }

        [TestMethod]
        public void ResourceIaqOutBoundTimedOutContacts()
        {
            Assert.AreEqual(1, _agent.NOutboundTimedOutContacts);
        }

        [TestMethod]
        public void ResourceIaqOutboundVoiceContacts()
        {
            Assert.AreEqual(1, _agent.NOutboundVoiceContacts);
        }

        [TestMethod]
        public void ResourceIaqOutboundAcceptedContacts()
        {
            Assert.AreEqual(1, _agent.NOutboundAcceptedContacts);
        }

        [TestMethod]
        public void ResourceIaqOutboundActiveVoiceContacts()
        {
            Assert.AreEqual(1,_agent.NOutboundActiveVoiceContacts);
        }

        [TestMethod]
        public void ResourceIaqActiveAcceptedContacts()
        {
            Assert.AreEqual(1,_agent.NOutboundActiveAcceptedContacts);          
        }

        [TestMethod]
        public void ResourceIaqOutboundRejectedContacts()
        {
            Assert.AreEqual(1, _agent.NOutboundRejectedContacts);
        }

        [TestMethod]
        public void ResourceIaqOutboundClosedContacts()
        {
            Assert.AreEqual(1, _agent.NOutboundClosedContacts);
        }

        [TestMethod]
        public void ResourceIaqAvgOutboundTalkDuration()
        {
            Assert.AreEqual(1, _agent.AvgOutboundTalkDuration);
        }

        [TestMethod]
        public void ResourceIaqActiveOutboundTalkDuration()
        {
            Assert.AreEqual(1, _agent.ActiveOutboundTalkDuration);
        }

        [TestMethod]
        public void ResourceIaqAverageOutboundHoldDuration()
        {
            Assert.AreEqual(1, _agent.AvgOutboundHoldDuration);
        }

        [TestMethod]
        public void ResourceIaqActiveOutboundHoldDuration()
        {
            Assert.AreEqual(1, _agent.ActiveOutboundHoldDuration);
        }

        [TestMethod]
        public void ResourceIaqLongestOutboundTalkDuration()
        {
            Assert.AreEqual(1, _agent.LongestOutboundTalkDuration);
        }

        [TestMethod]
        public void ResourceIaqLongestOutboundHoldDuration()
        {
            Assert.AreEqual(1, _agent.LongestOutboundHoldDuration);
        }

        [TestMethod]
        public void ResourceIaqTotalOutboundTalkTime()
        {
            Assert.AreEqual(1, _agent.TotalOutboundTalkTime);
        }

        [TestMethod]
        public void ResourceIaqTotalOutboundHoldTime()
        {
            Assert.AreEqual(1, _agent.TotalOutboundHoldTime);
        }

        [TestMethod]
        public void ResourceIaqAvgOutboundWorkTime()
        {
            Assert.AreEqual(1, _agent.AvgOutboundWorkTime);
        }

        [TestMethod]
        public void ResourceIaqMaxOutboundWorkTime()
        {
            Assert.AreEqual(1, _agent.MaxOutboundWorkTime);
        }

        [TestMethod]
        public void ResourceIaqTotalOutboundWorkTime()
        {
            Assert.AreEqual(1, _agent.TotalOutboundWorkTime);
        }

        [TestMethod]
        public void ResourceIaqAvgOutboundTalkWindow1()
        {
            Assert.AreEqual(1, _agent.AvgOutboundTalkWindow1);
        }

        [TestMethod]
        public void ResourceIaqAvgOutboundHoldWindow1()
        {
            Assert.AreEqual(1, _agent.AvgOutboundHoldWindow1);
        }

        [TestMethod]
        public void ResourceIaqAvgOutboundTalkWindow2()
        {
            Assert.AreEqual(1, _agent.AvgOutboundTalkWindow2);
        }

        [TestMethod]
        public void ResourceIaqAvgOutboundHoldWindow2()
        {
            Assert.AreEqual(1, _agent.AvgOutboundHoldWindow2);
        }

        [TestMethod]
        public void ResourceIaqOutboundHandledContacts()
        {
            Assert.AreEqual(1, _agent.NOutboundHandledContacts);
        }

        [TestMethod]
        public void ResourceIaqAvgTalkingWindow1()
        {
            Assert.AreEqual(80133, _agent.AvgTalkingWindow1);    
        }

        [TestMethod]
        public void ResourceIaqAvgHoldWindow1()
        {
            Assert.AreEqual(1, _agent.AvgHoldWindow1);
        }

        [TestMethod]
        public void ResourceIaqAvgTalkingWindow2()
        {
            Assert.AreEqual(79534, _agent.AvgTalkingWindow2);
        }

        [TestMethod]
        public void ResourceIaqAvgHoldWindow2()
        {
            Assert.AreEqual(1, _agent.AvgHoldWindow2);
        }

        [TestMethod]
        public void ResourceIaqStrResourceState()
        {
            Assert.AreEqual("Talking", _agent.StrResourceState);
        }
}
}
