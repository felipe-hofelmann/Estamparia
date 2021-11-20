using Estamparia.Aplication.Interfaces.IRepositorys;
using Estamparia.Aplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estamparia.Mvc.Controllers
{
    public class MaquinaCarrosselController : Controller
    {
        private readonly IMaquinaCarrosselRepository repository;
        public MaquinaCarrosselController(IMaquinaCarrosselRepository repository)
        {
            this.repository = repository;
        }

        public ActionResult List()
        {
            return View(repository.Read());
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
        public ActionResult Create(MaquinaCarrossel maquinaCarrossel)
        {
            repository.Create(maquinaCarrossel);
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(repository.Read(id));
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(MaquinaCarrossel maquinaCarrossel)
        {
            repository.Update(maquinaCarrossel);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(repository.Read(id));
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Delete(MaquinaCarrossel maquinaCarrossel)
        {
            try
            {
                repository.Delete(maquinaCarrossel.Id);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
    }
}
