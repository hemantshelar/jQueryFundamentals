using jQueryFundamentalsUI.Models;
using PersonalDiary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQueryFundamentalsUI.Controllers
{
    public class BootstrapDropdownController : Controller
    {
        private IGenericUnitOfWork _UnitOfWork = null;
        public BootstrapDropdownController(IGenericUnitOfWork _uow)
        {
            _UnitOfWork = _uow;
        }
        // GET: BootstrapDropdown
        public ActionResult BootStrapDropdownExample1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BootStrapDropdownExample1(TestCustomerModel model)
        {
            return RedirectToAction("BootStrapDropdownExample1");
        }
        public ActionResult Test()
        {
            return new EmptyResult();
        }
    }
}