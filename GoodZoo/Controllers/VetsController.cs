using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GoodZoo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoodZoo.Controllers
{
    public class VetsController : Controller
    {
        private IVetRepository animalRepo;  // New!
        private GoodZooContext db = new GoodZooContext();
        public VetsController(IVetRepository repo = null)
        {
            if (repo == null)
            {
                this.animalRepo = new EFVetRepository();
            }
            else
            {
                this.animalRepo = repo;
            }
        }

        public ViewResult Index()
        {
            // Updated:
            return View(animalRepo.Vets.ToList());
        }

        public IActionResult Details(int id)
        {
            // Updated:
            Vet thisVet = animalRepo.Vets.FirstOrDefault(x => x.VetId == id);
            return View(thisVet);
        }

        [HttpPost]
        public IActionResult Create(Vet vet)
        {
            animalRepo.Save(vet);   // Updated
            // Removed db.SaveChanges() call
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            // Updated:
            Vet thisVet = animalRepo.Vets.FirstOrDefault(x => x.VetId == id);
            return View(thisVet);
        }

        [HttpPost]
        public IActionResult Edit(Vet vet)
        {
            animalRepo.Edit(vet);   // Updated!
            // Removed db.SaveChanges() call
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            // Updated:
            Vet thisVet = animalRepo.Vets.FirstOrDefault(x => x.VetId == id);
            return View(thisVet);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            // Updated:
            Vet thisVet = animalRepo.Vets.FirstOrDefault(x => x.VetId == id);
            animalRepo.Remove(thisVet);   // Updated!
            // Removed db.SaveChanges() call
            return RedirectToAction("Index");
        }
    }
}