using GoogleMapsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GoogleMapsAPI.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ResultGetData(string model)
        {
            var modelTest = new modelJSON();
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(model))
                {
                    try
                    {
                        modelTest.dizi = JsonConvert.DeserializeObject<Dizi[]>(model);
                        return View(modelTest);
                    }
                    catch (Exception ex)
                    {
                        return View(modelTest);
                    }
                }
            }

            return View(modelTest);
        }
    }
}
