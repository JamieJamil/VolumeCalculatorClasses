using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPClasses
{
    internal class CalculateClass
    {
        // Metode af Cylinder.
        internal static double CylinderVol()
        {
            Console.Clear();
            Console.WriteLine("Enter radius: ");
            // Tager brugerens input.
            // CheckDouble checker om brugerens input er godkendt.
            double radius = CheckDouble(Console.ReadLine());

            Console.WriteLine("Enter height: ");
            // Tager brugerens input.
            // CheckDouble checker om brugerens input er godkendt.
            double height = CheckDouble(Console.ReadLine());

            // Udregning for at finde rumfanget.
            double volume = Math.PI * Math.Pow(radius, 2) * height;

            Console.WriteLine($"Volume of the cylinder is {volume:0.##}");
            Console.ReadKey();

            return volume;
        }
        // Metode af Sphere.
        internal static double SphereVol()
        {
            Console.Clear();
            Console.WriteLine("Enter radius: ");
            // Tager brugerens input.
            // CheckDouble checker om brugerens input er godkendt.
            double radius = CheckDouble(Console.ReadLine());

            // Udregning for at finde rumfanget.
            double volume = (4.0 / 3 * Math.PI * radius * radius * radius);

            Console.WriteLine($"Volume of the sphere is {volume:0.##}");
            Console.ReadKey();

            return volume;
        }
        // Metode af Rectangle.
        internal static double RectangleVol()
        {
            Console.Clear();
            Console.WriteLine("Enter length: ");
            // Tager brugerens input.
            // CheckDouble checker om brugerens input er godkendt.
            double length = CheckDouble(Console.ReadLine());

            Console.WriteLine("Enter width: ");
            // Tager brugerens input
            // CheckDouble checker om brugerens input er godkendt.
            double width = CheckDouble(Console.ReadLine());

            Console.WriteLine("Enter height: ");
            // Tager brugerens input.
            // CheckDouble checker om brugerens input er godkendt.
            double height = CheckDouble(Console.ReadLine());

            // Udregning for at finde rumfanget.
            double volume = length * width * height;

            Console.WriteLine($"Volume of the rectangle is {volume:0.##}");
            Console.ReadKey();

            return volume;
        }
        // Metode af Cone.
        internal static double ConeVol()
        {
            Console.Clear();
            Console.WriteLine("Enter radius: ");
            // Tager brugerens input.
            // CheckDouble checker om brugerens input er godkendt.
            double radius = CheckDouble(Console.ReadLine());

            Console.WriteLine("Enter height: ");
            // Tager brugerens input.
            // CheckDouble checker om brugerens input er godkendt.
            double height = CheckDouble(Console.ReadLine());

            // Udregning for at finde rumfanget.
            double volume = (1.0 / 3) * Math.PI * height * radius * radius;

            Console.WriteLine($"Volume of the cone is {volume:0.##}");
            Console.ReadKey();

            return volume;
        }
        // Metode af Cube.
        internal static double CubeVol()
        {
            Console.Clear();
            Console.WriteLine("Enter side length: ");
            // Tager brugerens input.
            // CheckDouble checker om brugerens input er godkendt.
            double length = CheckDouble(Console.ReadLine());

            // Udregning for at finde rumfanget.
            double volume = length * length * length;

            Console.WriteLine($"Volume of the cube is {volume:0.##}");
            Console.ReadKey();

            return volume;
        }
        // Metode der checker brugerens input.
        internal static double CheckDouble(string input)
        {
            bool b = double.TryParse(input, out double value);
            // Hviis input er mindre en 1 eller ikke et tal vil den give fejlmeddelelse.
            while (!b || value <= 0)
            {
                Console.WriteLine("Wrong input, try again");
                input = Console.ReadLine();
                // Tager brugerens nye input.
                b = double.TryParse(input, out value);
            }
            return value;
        }
    }
}
