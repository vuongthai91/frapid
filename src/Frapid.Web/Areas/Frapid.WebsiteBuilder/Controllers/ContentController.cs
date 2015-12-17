﻿using System.Web.Mvc;
using Frapid.Dashboard.Controllers;

namespace Frapid.WebsiteBuilder.Controllers
{
    public class ContentController : DashboardController
    {
        [Route("dashboard/website/contents")]
        [Authorize]
        public ActionResult Index(string alias = "")
        {
            return FrapidView(GetRazorView<AreaRegistration>("Content/Index.cshtml"));
        }

        [Route("dashboard/website/contents/manage")]
        [Route("dashboard/website/contents/new")]
        [Authorize]
        public ActionResult Manage(int contentId = 0)
        {
            var model = DAL.Contents.Get(contentId);
            return FrapidView(GetRazorView<AreaRegistration>("Content/Manage.cshtml"), model);
        }
    }
}