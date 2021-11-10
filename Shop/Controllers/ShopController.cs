using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class ShopController : BaseController
    {
        // GET: Shop
        public ActionResult Balance()
        {
            var userId = User.Identity.GetUserId();
            var user = _db.Users.Find(userId);


            return View(user);
        }
    }
}