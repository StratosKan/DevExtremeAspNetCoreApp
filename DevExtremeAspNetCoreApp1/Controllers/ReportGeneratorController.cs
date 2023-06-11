using DevExpress.DataAccess.Native.Json;
using DevExpress.XtraReports.UI;
using DevExtremeAspNetCoreApp1.Reports;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevExtremeAspNetCoreApp1.Controllers
{
    [Route("api/[controller]")]
    public class ReportGeneratorController : Controller
    {
        [HttpGet]
        public IActionResult GenerateReport() //[FromBody] JObject jsonData)
        {
            var report = new XtraReport1();

            //report.DataSource = jsonData;

            report.ExportToPdf("C:\temp");

            return Ok(report);
        }
    }
}
