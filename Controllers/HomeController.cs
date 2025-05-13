using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using P3.Models;
using P3.Services;

namespace P3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            // need to go get the data
            DataRetrieval dr = new DataRetrieval();
            // tell the instancef of dr to go get the data
            var loadedAbout = await dr.GetData("about/");

            // build our model!
            // built, called AboutModel!

            // Installed NuGet package NewtonSoft JSON
            var rtnResults = JsonConvert.DeserializeObject<AboutModel>(loadedAbout);
            rtnResults.pageTitle = "About us";

            // need to stuff data into model
            return View(rtnResults);
        }

        public async Task<IActionResult> Degrees()
        {
            // need to go get the data
            DataRetrieval dr = new DataRetrieval();

            var loadedAbout = await dr.GetData("degrees/");

            var rtnResults = JsonConvert.DeserializeObject<DegreesModel>(loadedAbout);
            rtnResults.pageTitle = "Degrees";

            // need to stuff data into model
            return View(rtnResults);
        }

        public async Task<IActionResult> Minors()
        {
            // need to go get the data
            DataRetrieval dr = new DataRetrieval();

            var loadedAbout = await dr.GetData("minors/");

            var rtnResults = JsonConvert.DeserializeObject<MinorsModel>(loadedAbout);
            rtnResults.pageTitle = "Minors";

            // need to stuff data into model
            return View(rtnResults);
        }

        public async Task<IActionResult> Employment()
        {
            // need to go get the data
            DataRetrieval dr = new DataRetrieval();

            var loadedAbout = await dr.GetData("employment/");

            var rtnResults = JsonConvert.DeserializeObject<EmploymentModel>(loadedAbout);
            rtnResults.pageTitle = "Employment";

            // need to stuff data into model
            return View(rtnResults);
        }

        public async Task<IActionResult> People()
        {
            // go get data
            DataRetrieval dr = new DataRetrieval();

            var loadedAbout = await dr.GetData("people/");

            var rtnResults = JsonConvert.DeserializeObject<PeopleModel>(loadedAbout);
            rtnResults.title = "Our People";

            // need to stuff data into model
            return View(rtnResults);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
