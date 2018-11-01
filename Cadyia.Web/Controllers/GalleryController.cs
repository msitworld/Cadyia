using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadyia.Data.Entities;
using Cadyia.Web.Contracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cadyia.Web.Controllers
{
    public class GalleryController : Controller
    {
        private IRepositoryWrapper _repoWrapper;

        public GalleryController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var plans = _repoWrapper.Plan.FindAll();
            return View(plans);
        }

        public IActionResult Detail(int id)
        {
            var plan = _repoWrapper.Plan.FindById(id);
            return View(plan);
        }

    }
}
