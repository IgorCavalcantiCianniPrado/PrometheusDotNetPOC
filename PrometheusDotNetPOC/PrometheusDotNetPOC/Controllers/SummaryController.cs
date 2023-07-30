using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prometheus;

namespace PrometheusDotNetPOC.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SummaryController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            //Unsderstand better this metric and how it works in the prometheus-net lib
            var RequestSizeSummary = Metrics.CreateSummary("api_summary", "Summary in the last 10 minutes.", new SummaryConfiguration
            {
                MaxAge = TimeSpan.FromSeconds(10)
            });

            RequestSizeSummary.Observe(200);

            return Ok("The Prometheus Summary Metric was generated");
        }
    }
}
