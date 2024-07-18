using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Programm
{
    class Programm
    { 
        static int Main(string[] args)
        {
            ExitProgramm exit = new ExitProgramm();
            Console.WriteLine("Welcome to EasyBD");
            while (true) {
                String? userpost = Console.ReadLine();
                switch (userpost)
                {
                    case "/help":
                        Console.WriteLine("lol");
                        break;
                    case "/exit":
                        int status = exit.exit(0);
                        if (status == 0)
                        {
                            return 0;
                        }
                        break;
                    default:
                        continue;
                }
            }
        }

    }
}