﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperheroProject.Data;
using SuperheroProject.Models;

namespace SuperheroProject.Controllers
{
    public class SuperheroesController : Controller
    {
        private ApplicationDbContext _db;

        public SuperheroesController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: SuperherosController
        public ActionResult Index()
        {
            
            return View(_db.Superheroes.ToList());
        }

        // GET: SuperherosController/Details/5
        public ActionResult Details(int id)
        {
            var superheroToShow = _db.Superheroes.Find(id);
            return View(superheroToShow);
        }

        // GET: SuperherosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperherosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                _db.Superheroes.Add(superhero);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperherosController/Edit/5
        public ActionResult Edit(int id)
        {
            var superheroToEdit = _db.Superheroes.Find(id);
            return View(superheroToEdit);
        }

        // POST: SuperherosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Superhero superhero)
        {
            try
            {
                _db.Superheroes.Update(superhero);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: SuperherosController/Delete/5
        public ActionResult Delete(int id)
        {
            var result = _db.Superheroes.Find(id);
            return View(result);
        }

        // POST: SuperherosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                var itemToDelete = _db.Superheroes.Find(id);
                _db.Superheroes.Remove(itemToDelete);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
