namespace GPClasses
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            // Loop that makes the program run over and over again until user closes it.
            while (true)
            {
                // Loop of the menu.
                Menu();
            }
        }
        internal static void Menu()
        {
            // Clear for better visiuals and less clutter.
            Console.Clear();
            Console.WriteLine("What do you want to calculate the volume of?\n\n[1] Cylinder\n[2] Sphere\n[3] Rectangle\n[4] Cone\n[5] Cube");
            Console.WriteLine("");
            Console.WriteLine("Go to:");
            // Switch with cases that contains the methods, user choose input.
            switch (Console.ReadKey(true).Key)
            {             
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    CalculateClass.CylinderVol();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    CalculateClass.SphereVol();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    CalculateClass.RectangleVol();
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    CalculateClass.ConeVol();
                    break;
                case ConsoleKey.NumPad5:
                case ConsoleKey.D5:
                    CalculateClass.CubeVol();
                    break;
                default:
                    break;
            }
        }     
    }
}