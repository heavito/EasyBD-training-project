using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EasyBD;
namespace Programm
{
    class Programm
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Welcome to EasyBD");
            while (true)
            {
                String? userpost = Console.ReadLine();
                switch (userpost)
                {
                    case "/help":
                        Console.WriteLine("lol");
                        break;
                    case "/exit":
                        int status = ExitProgramm.exit(0);
                        if (status == 0)
                        {
                            return 0;
                        }
                        break;
                    case "/create":
                        DB.create();
                        break;
                    case "/delete":
                        Console.WriteLine("lol");
                        break;
                    default:
                        continue;
                }
            }
        }
    }
}