using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class TechnicalStaff
    {
        private int Id;
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? DocumentType { get; set; }
        public string? DocumentId { get; set; }
        public DateOnly BornDate { get; set; }
        protected string? BloodType { get; set; }
        public string? UpperSize { get; set; }
        public string? LowerSize { get; set; }
        public double ShoeSize { get; set; }

        public TechnicalStaff(int id, string name, string lastName, string documentType, string documentId, DateOnly bornDate, string bloodType, string upperSize, string lowerSize, double shoeSize)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            DocumentType = documentType;
            DocumentId = documentId;
            BornDate = bornDate;
            BloodType = bloodType;
            UpperSize = upperSize;
            LowerSize = lowerSize;
            ShoeSize = shoeSize;

        }

        public byte CalculateAge()
        {
            int age = DateTime.Now.Year - BornDate.Year;
            return (byte)age;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"ID: {Id}, Nombre: {Name} {LastName}, Documento: {DocumentType} {DocumentId}, Edad: {CalculateAge()}, Tipo de Sangre: {BloodType}, Talla Superior: {UpperSize}, Talla Inferior: {LowerSize}, Talla de Zapatos: {ShoeSize}cms");
        }
    }
}