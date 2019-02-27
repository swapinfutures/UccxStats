using System.Collections.Generic;
using System.Threading.Tasks;

namespace UccxStats
{
    /// <summary>
    /// Interface for a source of UCCX Stats
    /// </summary>
    public interface IStatSource
    {   /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url">Location of where to retrieve UCCX statistics</param>
        /// <returns>Task to return statistics</returns>
        Task<IEnumerable<T>> GetStatsAsync<T>(string url);
    }
}
