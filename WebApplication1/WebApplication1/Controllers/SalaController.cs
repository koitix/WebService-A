using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Classes;
using WebApplication1.Models.Contexto;

namespace WebApplication1.Controllers
{
    public class SalaController : Controller
    {
        private readonly Contexto _contexto;

        public SalaController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var lista = _contexto.sala.ToList();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var sala = new Sala();
            return View(sala);
        }

        [HttpPost]
        public IActionResult Create(Sala sala)
        {
            if (ModelState.IsValid)
            {
                _contexto.sala.Add(sala);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(sala);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var sala = _contexto.sala.Find(id);
            if (sala != null)
            {
                return View(sala);
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(Sala sala)
        {
            if (ModelState.IsValid)
            {
                _contexto.sala.Update(sala);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(sala);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var sala = _contexto.sala.Find(id);
            return View(sala);
        }

        [HttpPost]
        public IActionResult Delete(Sala sala)
        {
            if (sala != null)
            {
                _contexto.sala.Remove(sala);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
                return View(sala);
           
        }
    }
}