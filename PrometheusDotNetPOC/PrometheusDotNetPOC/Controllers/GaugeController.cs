using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prometheus;
using System.Diagnostics.Metrics;

namespace PrometheusDotNetPOC.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GaugeController : ControllerBase
    {
        [HttpGet] 
        public IActionResult Get()
        {
            var gauge = Metrics.CreateGauge("api_gauge", "Random number generated in each request.", new GaugeConfiguration
            {
                LabelNames = new[] { "method", "endpoint" }
            });

            gauge.WithLabels(HttpContext.Request.Method, HttpContext.Request.Path).Set(new Random().Next());

            return Ok($"The Prometheus Gauge Metric was generated: {gauge.WithLabels(HttpContext.Request.Method, HttpContext.Request.Path).Value}");
        }
    }
}
