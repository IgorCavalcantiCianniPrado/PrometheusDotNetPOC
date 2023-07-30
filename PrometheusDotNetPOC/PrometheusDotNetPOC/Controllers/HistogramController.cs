using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prometheus;

namespace PrometheusDotNetPOC.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HistogramController : ControllerBase
    {
        //Continue in here

        [HttpGet] public IActionResult Get()
        {
            var OrderValueHistogram = Metrics.CreateHistogram("api_histogram", "Random number generated in each request.",
                new HistogramConfiguration
                {
                    Buckets = Histogram.LinearBuckets(start: 100, width: 100, count: 10)
                });


            OrderValueHistogram.Observe(new Random().Next(100, 1000));

            return Ok("The Prometheus Histogram Metric was generated");
        }
    }
}





