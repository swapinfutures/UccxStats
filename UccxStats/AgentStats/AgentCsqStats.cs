using System.Collections.Generic;

namespace UccxStats.AgentStats
{
    /// <summary>
    /// Basic statistics and agent membership for a queue.
    /// </summary>
    public class AgentCSQStats
    {
        public string CsqName { get; set; }
        public int CurrentWaitingCalls { get; set; }
        
        /*Uccx was occasionally returning a Current Oldest value of
        * 1514494699315, which is obviously incorrect, but non the
        * less we use a long to avoid System.Overflow Exception*/    
        public long CurrentOldest { get; set; }
        public List<Agent> AgentIds { get; set; }
    }
}
