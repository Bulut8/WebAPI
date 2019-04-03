using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebAPIProject.WebUI.Models;

namespace WebAPIProject.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string ListEmployees()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:50081/api/");
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage httpResponseMessage = httpClient.GetAsync("Home").Result;

            return httpResponseMessage.Content.ReadAsStringAsync().Result;
        }


        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Contact(Employee model)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:50081/api/");
            var jsonData = JsonConvert.SerializeObject(model);
            var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponseMessage = httpClient.PostAsync("Employees", stringContent).Result;
            return RedirectToAction("Index");
        }
    }
}