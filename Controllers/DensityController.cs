using Microsoft.AspNetCore.Mvc;
using VirtualLab.Models;

namespace VirtualLab.Controllers
{
    public class DensityController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl;

        FSIModel? item;


        public DensityController(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            //_httpClient = httpClientFactory.CreateClient();
            //_apiBaseUrl = configuration["APIPoint:BaseUrl"];
            //// Replace "YourFlaskApiBaseUrl" with the actual base URL of your Flask API
            //_httpClient.BaseAddress = new System.Uri(_apiBaseUrl);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShowDensity(string LiquidLimit, string PlasticLimit)
        {
            //Volume of Soil in Distilled Water = Vd
            //Volume of Soil in Kerosine = Vk

            //Free Swelling Index(FSI) = ((Vd - Vk) / Vk) * 100

            //Modified Free Swell Index(MFSI) = Vd / 10

            //Free Swell Ratio(FSR) = (Vd / Vk)

            double Vd = 0;
            double Vk = 0;
            double FSI = 0;
            double MFSI = 0;
            double FSR = 0;

            //var response_MFSI = 1.9;
            //var response_FSR = 1.31;

            //MFSI = response_MFSI;

            //Vd = MFSI * 10;

            //FSR = response_FSR ;

            //Vk = Vd / FSR;

            //FSI = ((Vd - Vk) / Vk) * 100;


            //FSIModel item = new FSIModel();


            //var response = _httpClient.GetAsync("/predictData?ll=" + LiquidLimit + "&pl=" + PlasticLimit).Result;

            //response.EnsureSuccessStatusCode();

            //var responseContent = response.Content.ReadAsStringAsync().Result;

            //var result = Newtonsoft.Json.JsonConvert.DeserializeAnonymousType(responseContent, new { FreeSwellRatio = 0.0, ModifiedFreeSwellingIndex = 0.0, FreeSwellingIndex = 0 });




            //item.FreeSwellRatio = result.FreeSwellRatio.ToString();
            //item.ModifiedFreeSwellingIndex = result.ModifiedFreeSwellingIndex.ToString();
            //item.FreeSwellingIndex = result.FreeSwellingIndex.ToString();


            //float MFSIfloatValue = float.Parse(item.ModifiedFreeSwellingIndex);

            //Vd = MFSIfloatValue * 10.0;

            //float FSRFloatValue = float.Parse(item.FreeSwellRatio);

            //Vk = Vd / FSRFloatValue;

            //FSI = ((Vd - Vk) / Vk) * 100;

            ////item.FreeSwellRatio = FSR.ToString(); // "90";
            ////item.ModifiedFreeSwellingIndex = MFSI.ToString(); // "50";
            ////item.FreeSwellingIndex = FSI.ToString(); // "40";

            ////TempData["data1"] = JsonSerializer.Serialize(item);   
            //TempData["FreeSwellRatio"] = item.FreeSwellRatio;
            //TempData["ModifiedFreeSwellingIndex"] = item.ModifiedFreeSwellingIndex;
            //TempData["FreeSwellingIndex"] = FSI.ToString(); // item.FreeSwellingIndex;

            return View();
        }

        [HttpPost]
        public IActionResult Results()
        {
            DensityModel item = new DensityModel();

            //FSIModel? item = (FSIModel?)TempData["data1"];



            ////item.FreeSwellRatio = "90";
            ////item.ModifiedFreeSwellingIndex = "50";
            ////item.FreeSwellingIndex = "40";

            //item.FreeSwellRatio = TempData["FreeSwellRatio"].ToString();
            //item.ModifiedFreeSwellingIndex = TempData["ModifiedFreeSwellingIndex"].ToString();
            //item.FreeSwellingIndex = TempData["FreeSwellingIndex"].ToString();



            //    FSIModel ? item = JsonSerializer.Deserialize<FSIModel>(TempData["data1"], );

            return View(item);
        }
    }
}
