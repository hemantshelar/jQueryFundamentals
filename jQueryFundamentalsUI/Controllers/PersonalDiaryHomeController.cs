using PersonalDiary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQueryFundamentalsUI.Controllers
{
    public class PersonalDiaryHomeController : Controller
    {
        private IGenericUnitOfWork _UnitOfWork = null;

        public PersonalDiaryHomeController(IGenericUnitOfWork _uow)
        {
            _UnitOfWork = _uow;
        }
        // GET: PersonalDiaryHome
        public ActionResult Index()
        {
            return View();
        }
    }
}