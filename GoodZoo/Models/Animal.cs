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
        public Animal(string name)
        {
            Name = name;
        }
    }
}
