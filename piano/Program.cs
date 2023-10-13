using System.Security.Cryptography.X509Certificates;

namespace piano
{
    internal class Program
    {
        static int[] C = new int[] { 131, 262, 523, 1046 };
        static int[] Db = new int[] { 139, 277, 544, 1109 };
        static int[] D = new int[] { 147, 294, 587, 1174 };
        static int[] Eb = new int[] { 155, 311, 622, 1245 };
        static int[] E = new int[] { 165, 330, 659, 1318 };
        static int[] F = new int[] { 175, 349, 698, 1396 };
        static int[] Gb = new int[] { 185, 370, 740, 1480 };
        static int[] G = new int[] { 196, 392, 784, 1568 };
        static int[] Ab = new int[] { 207, 415, 830, 1661 };
        static int[] A = new int[] { 220, 440, 880, 1760 };
        static int[] Bb = new int[] { 233, 466, 923, 1865 };
        static int[] B = new int[] { 247, 494, 988, 1976 };
        
        static void Main(string[] args)
        {
            char key = '1';
            while (key != ((char)ConsoleKey.Escape))
            {
                key = Console.ReadKey(true).KeyChar; 
                switch (key)
                {
                    case (char)ConsoleKey.F1:
                        Oktava1();
                        break;
                    case (char)ConsoleKey.F2:   
                        Oktava2();
                        break;
                    case (char)ConsoleKey.F3:
                        Oktava3();
                        break;
                    case (char)ConsoleKey.F4:
                        Oktava4();
                        break;

                }
            }
        }
        static void Oktava3()
        {
            char key = '1';
            if (key == (char)ConsoleKey.F3)
            {
                key = Console.ReadKey(true).KeyChar;
                switch (key)
                {
                    case 'x':
                        Console.Beep(C[3], 200);
                        break;
                    case 'd':
                        Console.Beep(Db[3], 200);
                        break;
                    case 'c':
                        Console.Beep(D[3], 200);
                        break;
                    case 'f':
                        Console.Beep(Eb[3], 200);
                        break;
                    case 'v':
                        Console.Beep(E[3], 200);
                        break;
                    case 'b':
                        Console.Beep(F[3], 200);
                        break;
                    case 'h':
                        Console.Beep(Gb[3], 200);
                        break;
                    case 'n':
                        Console.Beep(G[3], 200);
                        break;
                    case 'j':
                        Console.Beep(Ab[3], 200);
                        break;
                    case 'm':
                        Console.Beep(A[3], 200);
                        break;
                    case 'k':
                        Console.Beep(Bb[3], 200);
                        break;
                    case ',':
                        Console.Beep(B[3], 200);
                        break;
                }
            }
        }
        static void Oktava4()
        {
            char key = '1';
            if (key == (char)ConsoleKey.F4)
            {
                key = Console.ReadKey(true).KeyChar;
                switch (key)
                {
                    case 'x':
                        Console.Beep(C[4], 200);
                        break;
                    case 'd':
                        Console.Beep(Db[4], 200);
                        break;
                    case 'c':
                        Console.Beep(D[4], 200);
                        break;
                    case 'f':
                        Console.Beep(Eb[4], 200);
                        break;
                    case 'v':
                        Console.Beep(E[4], 200);
                        break;
                    case 'b':
                        Console.Beep(F[4], 200);
                        break;
                    case 'h':
                        Console.Beep(Gb[4], 200);
                        break;
                    case 'n':
                        Console.Beep(G[4], 200);
                        break;
                    case 'j':
                        Console.Beep(Ab[4], 200);
                        break;
                    case 'm':
                        Console.Beep(A[4], 200);
                        break;
                    case 'k':
                        Console.Beep(Bb[4], 200);
                        break;
                    case ',':
                        Console.Beep(B[4], 200);
                        break;
                }
            }
        }
        static void Oktava1()
        {
            char key = '1';
            if (key == (char)ConsoleKey.F1)
            {
                key = Console.ReadKey(true).KeyChar;
                switch (key)
                {
                    case 'x':
                        Console.Beep(C[1], 200);
                        break;
                    case 'd':
                        Console.Beep(Db[1], 200);
                        break;
                    case 'c':
                        Console.Beep(D[1], 200);
                        break;
                    case 'f':
                        Console.Beep(Eb[1], 200);
                        break;
                    case 'v':
                        Console.Beep(E[1], 200);
                        break;
                    case 'b':
                        Console.Beep(F[1], 200);
                        break;
                    case 'h':
                        Console.Beep(Gb[1], 200);
                        break;
                    case 'n':
                        Console.Beep(G[1], 200);
                        break;
                    case 'j':
                        Console.Beep(Ab[1], 200);
                        break;
                    case 'm':
                        Console.Beep(A[1], 200);
                        break;
                    case 'k':
                        Console.Beep(Bb[1], 200);
                        break;
                    case ',':
                        Console.Beep(B[1], 200);
                        break;
                }
            }
        }
        static void Oktava2()
        {
            char key = '1';
            if (key == (char)ConsoleKey.F2)
            {
                key = Console.ReadKey(true).KeyChar;
                switch (key)
                {
                    case 'x':
                        Console.Beep(C[2], 200);
                        break;
                    case 'd':
                        Console.Beep(Db[2], 200);
                        break;
                    case 'c':
                        Console.Beep(D[2], 200);
                        break;
                    case 'f':
                        Console.Beep(Eb[2], 200);
                        break;
                    case 'v':
                        Console.Beep(E[2], 200);
                        break;
                    case 'b':
                        Console.Beep(F[2], 200);
                        break;
                    case 'h':
                        Console.Beep(Gb[2], 200);
                        break;
                    case 'n':
                        Console.Beep(G[2], 200);
                        break;
                    case 'j':
                        Console.Beep(Ab[2], 200);
                        break;
                    case 'm':
                        Console.Beep(A[2], 200);
                        break;
                    case 'k':
                        Console.Beep(Bb[2], 200);
                        break;
                    case ',':
                        Console.Beep(B[2], 200);
                        break;
                }
            }
        }

    }
}