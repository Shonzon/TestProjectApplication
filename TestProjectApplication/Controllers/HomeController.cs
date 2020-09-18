using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProjectApplication.DAL;
using TestProjectApplication.Models;

namespace TestProjectApplication.Controllers
{
    public class HomeController : Controller
    {
        HomeDAL homedal = new HomeDAL();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetAllPostList()
        {
            List<PostModel> postlist = new List<PostModel>();
            postlist = homedal.GetAllPostList();
            return PartialView("_getAllPostList", postlist);
        }
    }
}