using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalR.Chat.Mvc.DotNetFrameWork.Controllers
{
    public class HomeController : Controller
    {

        private readonly IHubContext _chatHubContext;

        public HomeController()
        {
            // Get a reference to the ChatHub context
            _chatHubContext = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Chat()
        {
            return View();
        }
    }
}