using Microsoft.AspNetCore.Mvc;
using JPMorgan.Services;

namespace JPMorgan.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AnalyticsController : ControllerBase
{
    private readonly AnalyticsService _analytics;

    public AnalyticsController(AnalyticsService analytics)
    {
        _analytics = analytics;
    }

    [HttpGet("jpm-index")]
    public IActionResult JPMIndex([FromQuery] List<double> prices)
    {
        if (prices == null || prices.Count == 0)
            return BadRequest("Prices are required");

        var result = _analytics.AnalyzeSeries(prices);
        return Ok(result);
    }
}
