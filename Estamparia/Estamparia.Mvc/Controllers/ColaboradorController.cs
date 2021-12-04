using Estamparia.Aplication.Interfaces.IRepositorys;
using Estamparia.Aplication.Models;
using Estamparia.Infra.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estamparia.Mvc.Controllers
{
    public class ColaboradorController : Controller 
    {
        private readonly IColaboradorRepository repository;
        public ColaboradorController(IColaboradorRepository repository)
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
        public ActionResult Create(Colaborador colaborador)
        {
            repository.Create(colaborador);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(repository.Read(id));
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(Colaborador colaborador)
        {
            repository.Update(colaborador);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(repository.Read(id));
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Delete(Colaborador colaborador)
        {
            repository.Delete(colaborador.Id);
            return RedirectToAction("List");
        }
    }
}
