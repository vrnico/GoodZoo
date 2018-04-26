using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodZoo.Models
{
    public class EFVetRepository : IVetRepository
    {
        GoodZooContext db = new GoodZooContext();
        public EFVetRepository()
        {
            db = new GoodZooContext();
        }

        public object ViewBag { get; private set; }

        public EFVetRepository(GoodZooContext thisDb)
        {
            db = thisDb;
        }


        public IQueryable<Vet> Vets
        { get { return db.Vets; } }

        public Vet Save(Vet vet)
        {
            db.Vets.Add(vet);
            db.SaveChanges();
            return vet;
        }

        public Vet Edit(Vet vet)
        {
            db.Entry(vet).State = EntityState.Modified;
            db.SaveChanges();
            return vet;
        }

        public void Remove(Vet vet)
        {
            db.Vets.Remove(vet);
            db.SaveChanges();
        }

        public void Clear(Vet vet)
        {
            db.RemoveRange(vet);
        }
    }


}
