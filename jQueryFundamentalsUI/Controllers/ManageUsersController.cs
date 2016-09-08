using PersonalDiary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQueryFundamentalsUI.Controllers
{
    [Authorize(Roles=Constants.Roles.Admin)]
    public class ManageUsersController : Controller
    {

    }
}