using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperConsole
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class MinesweeperConsole
    {
        StringBuilder sb = new StringBuilder(16);
        List<>
        public MinesweeperConsole()
        { }

        public void StartInput()
        {
            Console.WriteLine("Input n and m:");
            string inputLine = Console.ReadLine();

            do
            {
                x = Console.Read();
                try
                {
                    ch = Convert.ToChar(x);
                    if (Char.IsWhiteSpace(ch))
                    {
                        Console.WriteLine(m3, x);
                        if (ch == 0x0a)
                            Console.WriteLine(m1);
                    }
                    else
                        Console.WriteLine(m2, ch, x);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("{0} Value read = {1}.", e.Message, x);
                    ch = Char.MinValue;
                    Console.WriteLine(m1);
                }
            } while (ch != '+');
        }
    }

    }

}
