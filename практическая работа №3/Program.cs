using System.Runtime.Serialization;

namespace ConsoleApp4
{
    internal class Program
    {
        static int[] Octaves(int octave)
        {
            int[] octave5 = { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
            int[] octave6 = { 523, 554, 587, 622, 659, 698, 740, 784, 831, 880, 932, 988 };
            int[] octave7 = { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865 };

            if (octave == 5)
            {
                return octave5;
            }
            else if (octave == 6)
            {
                return octave6;
            }
            else
            {
                return octave7;
            }
        }

        static void Main(string[] args)
        {
            int[] octave = Octaves(1);
            Console.WriteLine("переключение между тремя октавами \nF5- 5 октава \nF6- 6 октава \nF7- 7 октава");
           
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.F5)
                {
                    octave = Octaves(5);
                    Console.WriteLine("Выбрана октава 5");
                }
                if (key.Key == ConsoleKey.F6)
                {
                    octave = Octaves(6);
                    Console.WriteLine("Выбрана октава 6");
                }
                if (key.Key == ConsoleKey.F7)
                {
                    octave = Octaves(7);
                    Console.WriteLine("Выбрана октава 7");
                }

                if (key.Key == ConsoleKey.A)
                {
                    Beep(octave[0]);

                }
                if (key.Key == ConsoleKey.S)
                {
                    Beep(octave[1]);
                }
                if (key.Key == ConsoleKey.D)
                {
                    Beep(octave[2]);
                }
                if (key.Key == ConsoleKey.F)
                {
                    Beep(octave[3]);
                }
                if (key.Key == ConsoleKey.G)
                {
                    Beep(octave[4]);
                }
                if (key.Key == ConsoleKey.H)
                {
                    Beep(octave[5]);
                }
                if (key.Key == ConsoleKey.J)
                {
                    Beep(octave[6]);
                }


                if (key.Key == ConsoleKey.Z)
                {
                    Beep(octave[7]);
                }
                if (key.Key == ConsoleKey.X)
                {
                    Beep(octave[8]);
                }
                if (key.Key == ConsoleKey.C)
                {
                    Beep(octave[9]);
                }
                if (key.Key == ConsoleKey.V)
                {
                    Beep(octave[10]);
                }
                if (key.Key == ConsoleKey.B)
                {
                    Beep(octave[11]);
                }
            }

            static void Beep(int chastota)
            {
                Console.Clear();

                Console.Beep(chastota, 450);
            }

        }
    }
}
