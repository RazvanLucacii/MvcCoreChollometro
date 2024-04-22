using Microsoft.AspNetCore.Mvc;
using MvcCoreChollometro.Models;
using MvcCoreChollometro.Repositories;

namespace MvcCoreChollometro.Controllers
{
    public class ChollometrosController : Controller
    {
        private RepositoryChollometro repo;

        public ChollometrosController(RepositoryChollometro repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Chollo> chollos = this.repo.GetChollos();
            ViewData["ELEMENTOS"] = chollos.Count;
            return View(chollos);
        }
    }
}
