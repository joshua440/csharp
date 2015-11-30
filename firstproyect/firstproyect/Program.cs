using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproyect
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            String s;
            Boolean b=false,c=false;
            do
            {
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine("Hello everypony");
                for (i=0;i<100;i++)
                {
                    Console.Beep();
                }
                do
                {
                    Console.WriteLine("Quieres salir (Si/No)");
                    s = Console.ReadLine();
                    if (s.Equals("Si")) {
                        b = false;
                    } else if (s.Equals("No"))
                    {
                        b = true;
                    } else
                    {
                        Console.Beep();
                        c = true;
                    }
                }while(c);
            } while (b);
            System.Console.WriteLine("The end");
            Console.ReadLine();
        }
    }
}
