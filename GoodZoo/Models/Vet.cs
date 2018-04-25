using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodZoo.Models
{
    [Table("Vets")]
    public class Vet

    {
        public Vet()
        {
            this.Animals = new HashSet<Animal>();
        }
        [Key]
        public int VetId { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public virtual ICollection<Animal> Animals { get; set; }


        
    }
}
