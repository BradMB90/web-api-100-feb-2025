using Microsoft.AspNetCore.Mvc;

namespace SoftwareCatalog.Api.Status;

public class StatusController : ControllerBase
{
    // GET /status
    [HttpGet("/status")]
    public ActionResult GetTheStatus()
    {
        var response = new StatusResponse(DateTimeOffset.Now, "Looks Good!");
        return Ok(response);
    }
}

public record StatusResponse(DateTimeOffset LastChecked, String Message);
