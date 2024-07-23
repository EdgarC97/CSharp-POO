using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Animal
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Specie { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("El animal hace un sonido ");
        }

        public virtual void Movement()
        {
            Console.WriteLine("El animal se mueve");
        }
        public virtual void ShowAnimalInfo()
        {
            Console.WriteLine($"Id: {Id}, Nombre: {Name}, Genero: {Gender}, Especie: {Specie}");
        }

        public Animal(string name, string gender, string specie)
        {
            Id = Guid.NewGuid();
            Name = name;
            Gender = gender;
            Specie = specie;
        }
    }
}