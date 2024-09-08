//using DataManager.Base;
//using Microsoft.AspNetCore.Mvc;
//using TaskProject.Controllers;

//namespace TestMediatorApi.Controllers;

//[Route("api/[controller]")]
//[ApiController]
//public class CarControlController : BaseController
//{
//    [HttpPost("AddCarToWorker")]
//    public async Task<IActionResult> AddCarToWorker([FromForm] AddCategoryFormData value)
//    {
//        var result = await Sender.Send(new CategoryAddQuery(value));
//        return Ok(result);
//    }

//    [HttpPut("UpdateCarOfWorker")]
//    public async Task<IActionResult> UpdateCarOfWorker([FromForm] AddFieldCategoryFormData value)
//    {
//        var result = await Sender.Send(new CategoryAddFieldQuery(value));
//        return Ok(result);
//    }

//    [HttpDelete("DeleteCarOfWorker")]
//    public async Task<IActionResult> DeleteCarOfWorker([FromForm] RemoveCategoryFieldFormData value)
//    {
//        var result = await Sender.Send(new CategoryRemoveFieldQuery(value));
//        return Ok(result);
//    }

//    [HttpGet("GetCarOfWorkerWorker")]
//    public async Task<IActionResult> GetCarOfWorkerWorker()
//    {
//        var result = await Sender.Send(new AddWorkerCommand());
//        return Ok(result);
//    }

//    [HttpGet("GetAllCars")]
//    public async Task<IActionResult> GetAllCars()
//    {
//        var result = await Sender.Send(new AddWorkerCommand());
//        return Ok(result);
//    }
//}