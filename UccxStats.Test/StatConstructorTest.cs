using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UccxStats.Test
{
    [TestClass]
    public class StatConstructorTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MockStatConstructor()
        {
            var stats = new MockStats(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void UccxStatConstructor()
        {
            var stats = new UccxStatSource(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StatsConstructor()
        {
            var stats = new UccxStats(null);
        }

        [TestMethod]
        public void UccxUrlTest()
        {
            var priObject = new PrivateObject(new UccxStatSource("10.10.10.10"));
            Assert.AreEqual("http://10.10.10.10:9080/realtime/", priObject.GetProperty("UrlBase"));

            priObject = new PrivateObject(new UccxStatSource("UCCXHOSTNAME", 9999));
            Assert.AreEqual("http://UCCXHOSTNAME:9999/realtime/", priObject.GetProperty("UrlBase"));
        }
    }
}
