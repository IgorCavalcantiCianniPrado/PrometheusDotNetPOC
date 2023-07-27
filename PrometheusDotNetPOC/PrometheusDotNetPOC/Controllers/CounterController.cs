using Microsoft.AspNetCore.Mvc;
using Prometheus;

namespace PrometheusDotNetPOC.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CounterController : ControllerBase
    {
        [HttpGet]
        public void Get()
        {
            var counter = Metrics.CreateCounter("peopleapi_path_counter", "Counts requests to the People API endpoints", new CounterConfiguration
            {
                LabelNames = new[] { "method", "endpoint" }
            });

            counter.WithLabels(HttpContext.Request.Method, HttpContext.Request.Path).Inc();
        }
    }
}
