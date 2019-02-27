using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace UccxStats.Test
{
    /// <inheritdoc />
    /// <summary>
    /// Mock Stat Source to retrieve statistics from a JSON file.
    /// </summary>
    public sealed class MockStats : IStatSource
    {
        private string TestJson { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="testjson">JSON</param>
        public MockStats(string testjson)
        {
            if (string.IsNullOrEmpty(testjson))
                throw new ArgumentException("Value cannot be null or empty.", nameof(testjson));

            TestJson = testjson;
        }

        public async Task<IEnumerable<T>> GetStatsAsync<T>(string url = null)
        {
            var requestResult = JArray.Parse(TestJson);

            return new List<T>(requestResult.Children()
                .Select(jo => jo[typeof(T).Name].ToObject<T>()));
        }
    }
}