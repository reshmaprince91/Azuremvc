using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class quoteController : Controller
    {
        // GET: quote
        public ActionResult Index()
        {

            IEnumerable<quoteModel> qtemdl;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Quote").Result;
            qtemdl = response.Content.ReadAsAsync<IEnumerable<quoteModel>>().Result;
            return View(qtemdl);
        }
    }
}