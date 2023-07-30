using Microsoft.AspNetCore.Mvc;
using Prometheus;

namespace PrometheusDotNetPOC.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CounterController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {      
            var counter = Metrics.CreateCounter("api_counter", "Counts requests to this endpoint", new CounterConfiguration
            {
                LabelNames = new[] { "method", "endpoint" }
            });

            counter.WithLabels(HttpContext.Request.Method, HttpContext.Request.Path).Inc();

            return Ok($"The Prometheus Counter Metric was incremented: {counter.WithLabels(HttpContext.Request.Method, HttpContext.Request.Path).Value}");
        }
    }
}



