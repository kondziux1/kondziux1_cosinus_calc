class pazdan
{
    public float era = 0;
}

class Runtime
{
    static void Main()
    {
        pazdan paz = new();
        float i;
        int j;
        int k;
        float o = 1;
        float cis;
        bool som;
        bool som1;
        float c = 0;
        som1 = true;
        som = true;

        Console.WriteLine("Shitty cosinus calculator by kondziux1");
        Console.WriteLine("https://");

        Console.Write("can we start??");
        Console.Write(" (Y/n)");
        while (som1 == true) {
            var key1 = Console.ReadKey(true).Key;
            if (key1 == ConsoleKey.Y)
            {
                som1 = false;
                som = true;
                Console.Clear();
            }
            else
            {
                return;
            }
            Console.WriteLine(key1);
        }
        
        Console.WriteLine("starting");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=========Pomoc=========");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("A - dodanie 1 do angle");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("D - odejmij 1 od angle");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Q - dodanie 10 do angle");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("R - Wyzeruj angle i wynik");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("C - wyczyść konsole");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("H - pomoc ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=======================");
        Console.ResetColor();


        while (som == true)
        {
            
            var key = Console.ReadKey(true).Key;

            while (key == ConsoleKey.A)
            {
                cis = MathF.Cos(c);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("angle - ");
                Console.Write(c);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" cosinus - ");
                Console.Write(cis);
                Console.WriteLine();
                key = 0;
                c++;
            }
            
            while (key == ConsoleKey.Q)
            {
                cis = MathF.Cos(c);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("angle - ");
                Console.Write(c);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" cosinus - ");
                Console.Write(cis);
                Console.WriteLine();
                key = 0;
                c += 10;
            }
            while (key == ConsoleKey.D)
            {
                cis = MathF.Cos(c);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("angle - ");
                Console.Write(c);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" cosinus - ");
                Console.Write(cis);
                Console.WriteLine();
                key = 0;
                c--;

            }
            while (key == ConsoleKey.R)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("RESETING");
                c = 0;
                cis = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Reset Complete..");
                Console.WriteLine();
                key = 0;
            }
            while (key == ConsoleKey.C)
            {
                Console.Clear();
            }
            while (key == ConsoleKey.H)
            {
                for (int lui = 0; lui < 2; lui++)
                {
                    Console.WriteLine("");
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=========Pomoc=========");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A - dodanie 1 do angle");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("D - odejmij 1 od angle");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Q - dodanie 10 do angle");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("R - Wyzeruj angle i wynik");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("C - wyczyść konsole");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("H - pomoc ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=======================");
                Console.ResetColor();
                for (int lui = 0; lui < 5; lui++)
                {
                    Console.WriteLine("");
                }
                key = 0;
            }

        }
        Console.ResetColor();



        paz.era = o;

        i = paz.era;
        Console.WriteLine(i);
    }
}