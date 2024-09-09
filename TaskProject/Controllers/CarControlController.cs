using DataManager.Requests;
using Microsoft.AspNetCore.Mvc;
using TaskProject.Controllers;
using TaskProject.Mediatr.Car.Command;
using TaskProject.Mediatr.Car.Query;
using TaskProject.Mediatr.Worker.Command;

namespace TestMediatorApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarControlController : BaseController
{
    [HttpPost("AddCarToWorker")]
    public async Task<IActionResult> AddCarToWorker([FromForm] AddCarToWorker value)
    {
        var result = await _sender.Send(new AddCarToWorkerCommand(value));
        return Ok(result);
    }

    [HttpPut("UpdateCarOfWorker")]
    public async Task<IActionResult> UpdateCarOfWorker([FromForm] UpdateCarOfWorker value)
    {
        var result = await _sender.Send(new UpdateWorkerCarCommand(value));
        return Ok(result);
    }

    [HttpDelete("DeleteCarOfWorker")]
    public async Task<IActionResult> DeleteCarOfWorker([FromForm] DeleteCarOfWorker value)
    {
        var result = await _sender.Send(new DeleteWorkerCarCommand(value));
        return Ok(result);
    }

    [HttpGet("GetCarOfWorkerWorker/{workerId}")]
    public async Task<IActionResult> GetCarOfWorkerWorker(int workerId)
    {
        var result = await _sender.Send(new GetWorkerCarQuery(workerId));
        return Ok(result);
    }
}