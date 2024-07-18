using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Programm
{
    class Programm
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EasyBD");
            ExitProgramm exit = new ExitProgramm();
            exit.exit(0);
        }
    }
}