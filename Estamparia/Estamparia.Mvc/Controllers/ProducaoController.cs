using Estamparia.Aplication.Interfaces.IRepositorys;
using Estamparia.Aplication.Interfaces.IRepositorys.IBaseRepositorys;
using Estamparia.Aplication.Models;
using Estamparia.Aplication.Models.BaseModels;
using Estamparia.Domain.Repository.BaseRepositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return View();
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
