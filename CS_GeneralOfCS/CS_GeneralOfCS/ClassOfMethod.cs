using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_GeneralOfCS
{
    static class ClassOfMethod
    {
        static public void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        static public void Print(string msg, ConsoleColor backgroundcolor)
        {
            Console.ForegroundColor = backgroundcolor;
            Console.WriteLine(msg);
        }


        static public void Pause()
        {
            Console.ReadKey();

        }


        static public void Pause(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }


        static public bool Odd(int a, int b)
        {
            return a % b == 0;
        }

    }
}
