using AspNetCore.Reporting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDLC_Report_Data_Bind.Controllers
{
    public class ReportController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvirnoment;
        private readonly IEmployeeRepository _employeeRepository;

        public ReportController(IWebHostEnvironment webHostEnvironment, IEmployeeRepository employeeRepository)
        {
            this._webHostEnvirnoment = webHostEnvironment;
            this._employeeRepository = employeeRepository;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Print()
        {
            string mimtype = "";
            int extension = 1;
            var path = $"{this._webHostEnvirnoment.WebRootPath}\\Reports\\Report2.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            //parameters.Add("rp1", "ASP.NET CORE RDLC Report");
            //get products from product table 
            var employees = await _employeeRepository.GetEmployeedatas();
            LocalReport localReport = new LocalReport(path);
            localReport.AddDataSource("DataSet1", employees);
            var result = localReport.Execute(RenderType.Pdf, extension, parameters, mimtype);
            return File(result.MainStream, "application/pdf");
        }
    }
}
