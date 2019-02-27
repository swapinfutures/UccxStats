# UccxStats

An unofficial dotnet library for consuming Cisco's Unified Contact Center Express Stats REST API.

```c#
using UccxStats;

//Initialize stats object
var stats = new UccxStats(new UccxStatSource("198.18.133.19"));

//Get basic queue stats (including agent membership) for all UCCX queues
var queueStats = stats.GetAgentCsqStats().Result;
var paymentQueue = queueStats.FirstOrDefault(x => x.CsqName.Equals("Payments"));

//Get all detailed agent stats
var resourceStats = stats.GetResourceIaqStats().Result;

//Get basic stats related to an agent (including their list of queues)
var csqStats = stats.GetVoiceCsqDetailsStats().Result;

//Get detailed queue stats
var csqDetailedStats = stats.GetVoiceIaqStats().Result;

//Get Email Queue stats
var emailQueueStats = stats.GetEmailQueueStats().Result;

//Get Chat Queue stats
var chatQueueStats = stats.GetChatQueueStats().Result;
```
## Prerequisites

.NET 4.6

## Testing

The project comes with a large suite of unit tests and a *MockStats* class that makes it easy to test the various JSON stat attributes. There are also some basic integration tests that have been commented out and require an instance of UCCX to execute. This library has been tested on versions of UCCX ranging from 10.0 to 11.6 v3.

## Reference

The below UCCX REST Endpoints are consumed as a part of this library:

http://{UccxHostOrIp}:9080/realtime/VoiceIAQStats  
http://{UccxHostOrIp}:9080/realtime/ResourceIAQStats  
http://{UccxHostOrIp}:9080/realtime/AgentCSQStats  
http://{UccxHostOrIp}:9080/realtime/VoiceCSQDetailsStats  
http://{UccxHostOrIp}:9080/realtime/ChatQueueStatistics  
http://{UccxHostOrIp}:9080/realtime/EmailQueueStatistics  

## Disclaimer

The UCCX Stats REST API is not formally documented by Cisco and is subject to change in later releases of the product.

