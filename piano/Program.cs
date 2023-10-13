using System.Data.Common;
using System.Runtime.InteropServices;
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
            Console.WriteLine("Нажмите на esc и выберите октаву под клавишами 1, 2, 3, 4");
            char key = '1';
            while (key != ((char)ConsoleKey.Escape))
            {
                key = Console.ReadKey(true).KeyChar;               
                switch (key)
                {                    
                case '1':
                        Oktava1();
                        break;
                case '2':
                        Oktava2();
                        break;
                case '3':
                        Oktava3();
                        break;
                case '4':
                        Oktava4();
                        break;
                }
                
            }
        }
        static void Oktava3()
        {
            char key = '1';
            while (key != ((char)ConsoleKey.Escape))
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
        static void Oktava4()
        {
            char key = '1';
            while (key != ((char)ConsoleKey.Escape))
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
        static void Oktava1()
        {
            char key = '1';
            while (key != ((char)ConsoleKey.Escape))
            {
                key = Console.ReadKey(true).KeyChar;
                
                switch (key)
                {
                    case 'x':
                        Console.Beep(C[0], 200);
                        break;
                    case 'd':
                        Console.Beep(Db[0], 200);
                        break;
                    case 'c':
                        Console.Beep(D[0], 200);
                        break;
                    case 'f':
                        Console.Beep(Eb[0], 200);
                        break;
                    case 'v':
                        Console.Beep(E[0], 200);
                        break;
                    case 'b':
                        Console.Beep(F[0], 200);
                        break;
                    case 'h':
                        Console.Beep(Gb[0], 200);
                        break;
                    case 'n':
                        Console.Beep(G[0], 200);
                        break;
                    case 'j':
                        Console.Beep(Ab[0], 200);
                        break;
                    case 'm':
                        Console.Beep(A[0], 200);
                        break;
                    case 'k':
                        Console.Beep(Bb[0], 200);
                        break;
                    case ',':
                        Console.Beep(B[0], 200);
                        break;
                }

            }
        }
        static void Oktava2()
        {
            char key = '1';
            while (key != ((char)ConsoleKey.Escape))
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

    }
}