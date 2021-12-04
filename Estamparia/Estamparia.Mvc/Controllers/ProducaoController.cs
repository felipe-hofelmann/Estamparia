using Estamparia.Aplication.Interfaces.IRepositorys;
using Estamparia.Aplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estamparia.Mvc.Controllers
{
    public class ProducaoController : Controller
    {
        IProducaoRepository repository;
        public ProducaoController(IProducaoRepository repository)
        {
            this.repository = repository;
        }


        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(repository.Read(id));
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(Producao producao)
        {
            repository.Create(producao);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(repository.Read(id));
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(Producao producao)
        {
            repository.Update(producao);
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            return View(repository.Read());
        }
    }
}
