using DataManager.Requests;
using Microsoft.AspNetCore.Mvc;
using TaskProject.Controllers;
using TaskProject.Mediatr.Worker.Command;
using TaskProject.Mediatr.Worker.Query;

namespace TestMediatorApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WorkerControlController : BaseController
{
    [HttpPost("AddWorker")]
    public async Task<IActionResult> AddWorker([FromForm] AddWorker value)
    {
        var result = await _sender.Send(new AddWorkerCommand(value));
        return Ok(result);
    }

    [HttpPut("UpdateWorker")]
    public async Task<IActionResult> UpdateWorker([FromForm] UpdateWorker value)
    {
        var result = await _sender.Send(new UpdateWorkerCommand(value));
        return Ok(result);
    }

    [HttpDelete("DeleteWorker")]
    public async Task<IActionResult> DeleteWorker([FromForm] DeleteWorker value)
    {
        var result = await _sender.Send(new DeleteWorkerCommand(value));
        return Ok(result);
    }

    [HttpGet("GetWorker")]
    public async Task<IActionResult> GetWorker(int workerId)
    {
        var result = await _sender.Send(new GetWorkerQuery(workerId));
        return Ok(result);
    }

    [HttpGet("GetWorkers")]
    public async Task<IActionResult> GetWorkers()
    {
        var result = await _sender.Send(new GetWorkersQuery());
        return Ok(result);
    }
}