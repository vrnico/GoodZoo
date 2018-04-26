using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodZoo.Models
{
    public interface IVetRepository
    {
        IQueryable<Vet> Vets { get; }
        Vet Save(Vet vet);
        Vet Edit(Vet vet);
        void Remove(Vet vet);
    }
}
