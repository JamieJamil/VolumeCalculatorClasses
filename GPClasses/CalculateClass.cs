namespace GPClasses
{
    internal class CalculateClass
    {
        // Method Cylinder.
        internal static double CylinderVol()
        {
            Console.Clear();
            Console.WriteLine("Enter radius: ");
            // Takes input from user.
            // CheckDouble checks if user input is correct.
            double radius = CheckDouble(Console.ReadLine());

            Console.WriteLine("Enter height: ");
            // Takes input from user.
            // CheckDouble checks if user input is correct.
            double height = CheckDouble(Console.ReadLine());

            // Calculations to find the volume.
            double volume = Math.PI * Math.Pow(radius, 2) * height;

            Console.WriteLine($"Volume of the cylinder is {volume:0.##}");
            Console.ReadKey();

            return volume;
        }
        // Method Sphere.
        internal static double SphereVol()
        {
            Console.Clear();
            Console.WriteLine("Enter radius: ");
            // Takes input from user.
            // CheckDouble checks if user input is correct.
            double radius = CheckDouble(Console.ReadLine());

            // Calculations to find the volume.
            double volume = (4.0 / 3 * Math.PI * radius * radius * radius);

            Console.WriteLine($"Volume of the sphere is {volume:0.##}");
            Console.ReadKey();

            return volume;
        }
        // Method Rectangle.
        internal static double RectangleVol()
        {
            Console.Clear();
            Console.WriteLine("Enter length: ");
            // Takes input from user.
            // CheckDouble checks if user input is correct.
            double length = CheckDouble(Console.ReadLine());

            Console.WriteLine("Enter width: ");
            // Takes input from user.
            // CheckDouble checks if user input is correct.
            double width = CheckDouble(Console.ReadLine());

            Console.WriteLine("Enter height: ");
            // Takes input from user.
            // CheckDouble checks if user input is correct.
            double height = CheckDouble(Console.ReadLine());

            // Calculations to find the volume.
            double volume = length * width * height;

            Console.WriteLine($"Volume of the rectangle is {volume:0.##}");
            Console.ReadKey();

            return volume;
        }
        // Method Cone.
        internal static double ConeVol()
        {
            Console.Clear();
            Console.WriteLine("Enter radius: ");
            // Takes input from user.
            // CheckDouble checks if user input is correct.
            double radius = CheckDouble(Console.ReadLine());

            Console.WriteLine("Enter height: ");
            // Takes input from user.
            // CheckDouble checks if user input is correct.
            double height = CheckDouble(Console.ReadLine());

            // Calculations to find the volume.
            double volume = (1.0 / 3) * Math.PI * height * radius * radius;

            Console.WriteLine($"Volume of the cone is {volume:0.##}");
            Console.ReadKey();

            return volume;
        }
        // Method Cube.
        internal static double CubeVol()
        {
            Console.Clear();
            Console.WriteLine("Enter side length: ");
            // Takes input from user.
            // CheckDouble checks if user input is correct.
            double length = CheckDouble(Console.ReadLine());

            // Calculations to find the volume.
            double volume = length * length * length;

            Console.WriteLine($"Volume of the cube is {volume:0.##}");
            Console.ReadKey();

            return volume;
        }
        // Method that checks users input.
        internal static double CheckDouble(string input)
        {
            bool b = double.TryParse(input, out double value);
            // If the input is lower than 1 or not a digit it will give an error message
            while (!b || value <= 0)
            {
                Console.WriteLine("Wrong input, try again");
                input = Console.ReadLine();
                // Takes user input again in case it was wrong.
                b = double.TryParse(input, out value);
            }
            return value;
        }
    }
}
