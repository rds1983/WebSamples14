using Microsoft.AspNetCore.Mvc;
using WebDesigner_Blazor.Services;

namespace WebDesigner_Blazor.Controllers
{
	[Route("api/datasets")]
	public class DataSetsController : Controller
	{
		[HttpGet("{id}/content")]
		public ActionResult GetDataSetContent([FromServices] IDataSetsService dataSetsService, [FromRoute] string id)
		{
			if (string.IsNullOrWhiteSpace(id)) return BadRequest();
			var dataSet = dataSetsService.GetDataSet(id);
			return Json(dataSet);
		}

		[HttpGet("list")]
		public ActionResult GetDataSetsList([FromServices] IDataSetsService dataSetsService)
		{
			var dataSetsList = dataSetsService.GetDataSetsList();
			return Json(dataSetsList);
		}
	}
}
