namespace GPClasses
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            // Loop som gør at programmet køre indtil man selv lukker det.
            while (true)
            {
                // Loop af menuen.
                Menu();
            }
        }
        internal static void Menu()
        {
            // Clear for bedre visualisering og mindre clutter.
            Console.Clear();
            Console.WriteLine("What do you want to calculate the volume of?\n\n[1] Cylinder\n[2] Sphere\n[3] Rectangle\n[4] Cone\n[5] Cube");
            Console.WriteLine("");
            Console.WriteLine("Go to:");
            // Switch cases med metoder, der kommer an på hvad brugeren indtaster.
            switch (Console.ReadKey(true).Key)
            {

                // NumPad1, er så man også kan bruge numpad og de foeskellige metoder.
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