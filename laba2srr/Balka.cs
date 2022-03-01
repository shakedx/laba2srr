using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2srr
{
    internal class Balka : Body
    {
        public double part { get; set; } = 0;
        public double density { get; set; } = 0;
        public Balka(double width, double height, double length, double part, double density) : base(width, height, length)
        {
            this.part = part;
            this.density = density;
        }
        public string action()
        {
            double len_part = lenght / part;
            double S = 2 * (height * width + width * len_part + height * len_part);
            return S.ToString();
            //1. Найти объем(a*b*c)
            //2. Найти вес = плотность*объем
        }
        public string papa()
        {
            double V = width * height * lenght;
            double P = density * V;

            return P.ToString();
        }

        public string Print()
        {
            return "";
        }
    }
}
