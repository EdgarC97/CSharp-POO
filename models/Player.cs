using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Player : TechnicalStaff
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public string? Position { get; set; }
        public string? SkillFullFoot { get; set; }

        public Player(int id, string name, string lastName, string documentType, string documentId, DateOnly bornDate, string bloodType, string upperSize, string lowerSize, 
                  double shoeSize, double height, double weight, string position, string skillFullFoot)  : base(id, name, lastName, documentType, documentId, bornDate, bloodType, upperSize, lowerSize, shoeSize) 
        {
            Height = height;
            Weight = weight;
            Position = position;
            SkillFullFoot = skillFullFoot;
        }

        public double CalculateIMC()
        {
            double imcCalculated = Weight / (Height * Height);
            return imcCalculated;
        }
    }
}