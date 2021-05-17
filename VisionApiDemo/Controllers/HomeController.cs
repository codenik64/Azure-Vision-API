using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VisionApiDemo.Models;
using VisionApiDemo.Business_Layer;

namespace VisionApiDemo.Controllers
{
    public class HomeController : Controller
    {
        VisionApiService obj = new VisionApiService();

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var response = await obj.MakeAnalysisRequest();

            return View(response);
        }
    }
}
