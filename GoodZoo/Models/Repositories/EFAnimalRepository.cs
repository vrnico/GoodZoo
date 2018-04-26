﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GoodZoo.Models
{
    public class EFAnimalRepository : IAnimalRepository
    {
        GoodZooContext db = new GoodZooContext();
        public EFAnimalRepository()
        {
            db = new GoodZooContext();
        }

        public EFAnimalRepository(GoodZooContext thisDb)
        {
            db = thisDb;
        }


        public IQueryable<Animal> Animals
        { get { return db.Animals; } }

        public Animal Save(Animal animal)
        {
            db.Animals.Add(animal);
            db.SaveChanges();
            return animal;
        }

        public Animal Edit(Animal animal)
        {
            db.Entry(animal).State = EntityState.Modified;
            db.SaveChanges();
            return animal;
        }

        public void Remove(Animal animal)
        {
            db.Animals.Remove(animal);
            db.SaveChanges();
        }

       public void Clear(Animal animal)
        {
            db.RemoveRange(animal);
        }
    }


}
