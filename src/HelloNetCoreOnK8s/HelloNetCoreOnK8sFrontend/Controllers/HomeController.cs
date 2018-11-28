using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloNetCoreOnK8sFrontend.Models;

namespace HelloNetCoreOnK8sFrontend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
 
        public async Task<IActionResult> About()
        {
            ViewData["Message"] = "Your application description page.";
            var client = new HttpClient();
            var result = await client.GetAsync("http://netdc18-backend/api/describe");
            var instance = await result.Content.ReadAsAsync<InstanceInformation>();
            ViewData["InstanceId"] = instance.InstanceId;
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }

    public class InstanceInformation
    {
        public string InstanceId { get; set; }
    }
}