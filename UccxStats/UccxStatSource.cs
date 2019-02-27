using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace UccxStats
{
    /// <inheritdoc />
    /// <summary>
    /// The UCCX Stat Source
    /// </summary>
    public sealed class UccxStatSource : IStatSource
    {
        private string UrlBase { get; }
        private static readonly HttpClient Client = new HttpClient();

        private const string ExceptionMsg = "Couldn't Connect to web endpoint. Be sure " + 
                                            "you can reach UCCX and the endpoint you're " + 
                                            "attempting is valid for the UCCX version.";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ipOrHost">IP Address or Host Name of a UCCX Instance</param>
        /// <param name="port">Port Number for UCCX Stats. 9080 is default</param>
        public UccxStatSource(string ipOrHost, int port = 9080)
        {
            if (ipOrHost == null) throw new ArgumentNullException(nameof(ipOrHost));

            UrlBase = $"http://{ipOrHost}:{port}/realtime/";
        }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="apiPath"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> GetStatsAsync<T>(string apiPath)
        {
            HttpResponseMessage response;

            try
            {
                response = await Client.GetAsync(UrlBase + apiPath);
            }
            catch (HttpRequestException e)
            {
                throw new HttpRequestException(ExceptionMsg, e);
            }

            var requestResult = JArray.Parse(await response.Content.ReadAsStringAsync());

            return new List<T>(requestResult.Children()
                .Select(jo => jo[typeof(T).Name].ToObject<T>()));
        }
    }
}