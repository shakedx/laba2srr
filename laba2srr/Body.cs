using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2srr
{
    public class Body
    {
        public double width { get; set; } = 0;
        public double height { get; set; } = 0;
        public double lenght { get; set; } = 0;


        public Body(double width, double height, double lenght)
        {
            this.width = width;
            this.height = height;
            this.lenght = lenght;
        }

        public void Max()
        {

            double max = 4 * (width + height + lenght);

        }
        public double Area()
        {
            return 2 * (width * height + width * lenght + height * lenght);
        }


        public string Print()
        {

            return $"{(2 * (width * height + width * lenght + height * lenght))}\n" +
                   $"{4 * (width + height + lenght)}";
        }


    }
}
