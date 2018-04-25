using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodZoo.Models
{
    public class Animal

    {

        public string Name { get; set; }
        public string Species { get; set; }
        public string Sex { get; set; }
        public string HabitatType { get; set; }

        public Animal(string name, string species, string sex, string habitatType)
        {
            Name = name;
            Species = species;
            Sex = sex;
            HabitatType = habitatType;

        }
    }
}
