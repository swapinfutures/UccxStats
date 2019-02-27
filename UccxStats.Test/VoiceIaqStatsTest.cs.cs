using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UccxStats.QueueStats;

namespace UccxStats.Test
{
    [TestClass]
    public class VoiceIaqStatsTest : StatTestBase
    {
        private readonly VoiceIAQStats _queue;

        public VoiceIaqStatsTest() : base("VoiceIAQStats.json")
        {
            _queue = Stats.GetVoiceIaqStats().Result.First();
        }

        [TestMethod]
        public void VoiceIaqStatsId()
        {
            Assert.AreEqual(25, _queue.Id);
        }

        [TestMethod]
        public void VoiceIaqStatsEsdId()
        {
            Assert.AreEqual(25, _queue.EsdId);
        }

        [TestMethod]
        public void VoiceIaqStatsEsdName()
        {
            Assert.AreEqual("Pending Order Queries", _queue.EsdName);
        }

        [TestMethod]
        public void VoiceIaqStatsNResourcesLoggedIn()
        {
            Assert.AreEqual(4, _queue.NResourcesLoggedIn);
        }

        [TestMethod]
        public void VoiceIaqStatsnTotalContacts()
        {
            Assert.AreEqual(8, _queue.NTotalContacts);
        }

        [TestMethod]
        public void VoiceIaqStatsnHandledContacts()
        {
            Assert.AreEqual(6, _queue.NHandledContacts);
        }

        [TestMethod]
        public void VoiceIaqStatsnAbaondonedContacts()
        {
            Assert.AreEqual(1, _queue.NAbandonedContacts);
        }

        [TestMethod]
        public void VoiceIaqStatsnDequeuedContacts()
        {
            Assert.AreEqual(1, _queue.NDequeuedContacts);
        }

        [TestMethod]
        public void VoiceIaqStatsAvgTalkDuration()
        {
            Assert.AreEqual(70998, _queue.AvgTalkDuration);
        }

        [TestMethod]
        public void VoiceIaqStatsLongestTalkDuration()
        {
            Assert.AreEqual(95459, _queue.LongestTalkDuration);
        }

        [TestMethod]
        public void VoiceIaqStatsAvgWaitDuration()
        {
            Assert.AreEqual(8897, _queue.AvgWaitDuration);
        }

        [TestMethod]
        public void VoiceIaqStatsLongestWaitDuration()
        {
            Assert.AreEqual(36732, _queue.LongestWaitDuration);
        }

        [TestMethod]
        public void VoiceIaqStatsLongestCurrentlyWaitingDuration()
        {
            Assert.AreEqual(17362, _queue.LongestCurrentlyWaitingDuration);
        }

        [TestMethod]
        public void VoiceIaqStatsNAvailResources()
        {
            Assert.AreEqual(1, _queue.NAvailResources);
        }

        [TestMethod]
        public void VoiceIaqStatsNInSessionResources()
        {
            Assert.AreEqual(1, _queue.NInSessionResources);
        }

        [TestMethod]
        public void VoiceIaqStatsPreviwObInSessionCount()
        {
            Assert.AreEqual(1, _queue.PreviewObInSessionCount);
        }

        [TestMethod]
        public void VoiceIaqStatsPreviewObReservedStateCount()
        {
            Assert.AreEqual(1, _queue.PreviewObReserveStateCount);
        }

        [TestMethod]
        public void VoiceIaqStatsNUnavailResources()
        {
            Assert.AreEqual(1, _queue.NUnavailResources);
        }

        [TestMethod]
        public void VoiceIaqStatsNUnavailReasonsMap()
        {
            Assert.IsTrue(_queue.NUnavailResReasonsMap.ContainsKey(6));
            Assert.IsTrue(_queue.NUnavailResReasonsMap.ContainsValue(1));
        }

        [TestMethod]
        public void VoiceIaqStatsNWorkResources()
        {
            Assert.AreEqual(1, _queue.NWorkResources);
        }

        [TestMethod]
        public void VoiceIaqStatsNSelectedResources()
        {
            Assert.AreEqual(1, _queue.NSelectedResources);
        }

        [TestMethod]
        public void VoiceIaqStatsNWaitingContacts()
        {
            Assert.AreEqual(1, _queue.NWaitingContacts);
        }

        [TestMethod]
        public void VoiceIaqStatsNAvgHandlingTimeLowThreshold()
        {
            Assert.AreEqual(74344, _queue.NAverageHandlingTimeLowThreshold);
        }

        [TestMethod]
        public void VoiceIaqStatsNAvgHandlingTimeHighThreshold()
        {
            Assert.AreEqual(66368.33333333333, _queue.NAverageHandlingTimeHighThreshold);
        }

        [TestMethod]
        public void VoiceIaqStatsAvgWaitingTimeLowThreshold()
        {
            Assert.AreEqual(8199.666666666666, _queue.NAverageWaitingTimeLowThreshold);
        }

        [TestMethod]
        public void VoiceIaqStatsNAvgWaitingTimeHighThreshold()
        {
            Assert.AreEqual(7181, _queue.NAverageWaitingTimeHighThreshold);
        }

        [TestMethod]
        public void VoiceIaqStatsNAbandonedCallsLowThreshold()
        {
            Assert.AreEqual(1, _queue.NAbandonedCallsLowThreshold);
        }

        [TestMethod]
        public void VoiceIaqStatsNAbandonedCallsHighThreshold()
        {
            Assert.AreEqual(2, _queue.NAbandonedCallsHighThreshold);
        }

        [TestMethod]
        public void VoiceIaqStatsNDequeuedCallsLowThreshold()
        {
            Assert.AreEqual(1, _queue.NDequeuedCallsLowThreshold);
        }

        [TestMethod]
        public void VoiceIaqStatsNDequeuedCallsHighThreshold()
        {
            Assert.AreEqual(2, _queue.NDequeuedCallsHighThreshold);
        }

        [TestMethod]
        public void VoiceIaqStatsNSlaPercentageLowThreshold()
        {
            Assert.AreEqual(33.33333333333333, _queue.NSlaPercentageLowThreshold);
        }

        [TestMethod]
        public void VoiceIaqStatsNSlaPercentageHighThreshold()
        {
            Assert.AreEqual(50, _queue.NSlaPercentageHighThreshold);
        }

        [TestMethod]
        public void VoiceIaqNoQueues()
        {
            Stats = new UccxStats(new MockStats("[]"));

            var queues = Stats.GetVoiceIaqStats().Result.ToList();

            Assert.AreEqual(0, queues.Count);
        }
    }
}
