using PersonalDiary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQueryFundamentalsUI.Controllers
{
    public class BootstrapHomeController : Controller
    {
        private IGenericUnitOfWork _UnitOfWork = null;
        public BootstrapHomeController(IGenericUnitOfWork _uow)
        {
            _UnitOfWork = _uow;
        }
        // GET: BootstrapHome
        public ActionResult Index()
        {
            return View();
        }
    }
}