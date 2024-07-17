using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Trainer
    {
        public string? TitlesQuantity { get; set; }
        private string? Salary { get; set; }
        public byte YearsOfExperience { get; set; }
        public string? Nationality { get; set; }

        public Trainer(string titlesQuantity, string salary, byte yearsOfExperience, string nationality)
        {
            TitlesQuantity = titlesQuantity;
            Salary = salary;
            YearsOfExperience = yearsOfExperience;
            Nationality = nationality;
        }
    }


}