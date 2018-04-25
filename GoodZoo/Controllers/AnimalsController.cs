using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GoodZoo.Models;


namespace GoodZoo.Controllers
{
    public class AnimalsController : Controller
    {

        private GoodZooContext db = new GoodZooContext();

        public IActionResult Index()
        {

            return View(db.Animals.Include(animals => animals.Vet).ToList());
        }

        public IActionResult Details(int id)
        {
            Animal thisAnimal = db.Animals.FirstOrDefault(animals => animals.AnimalId == id);
            return View(thisAnimal);
        }

        public IActionResult Create()
        {
            ViewBag.VetId = new SelectList(db.Vets, "VetId", "Name");
            return View();;
        }

        [HttpPost]
        public IActionResult Create(Animal animal)
        {
            db.Animals.Add(animal);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisAnimal = db.Animals.FirstOrDefault(animals => animals.AnimalId == id);
            ViewBag.VetId = new SelectList(db.Vets, "VetId", "Name");
            return View(thisAnimal);
        }

        [HttpPost]
        public IActionResult Edit(Animal animal)
        {
            db.Entry(animal).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisAnimal = db.Animals.FirstOrDefault(animals => animals.AnimalId == id);
            return View(thisAnimal);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisAnimal = db.Animals.FirstOrDefault(animals => animals.AnimalId == id);
            db.Animals.Remove(thisAnimal);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}