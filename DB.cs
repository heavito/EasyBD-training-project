using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBD
{
    internal class DB
    {
        public static void create()
        {
            String path = Directory.GetCurrentDirectory();
            DirectoryInfo dirWork = new DirectoryInfo(path);
            while (true)
            {
                Console.Write("DATABASE name: ");
                string? dirname = Console.ReadLine();

                if (!string.IsNullOrEmpty(dirname) && DBvalidation.IsValidDirName(dirname) == true)
                {
                    string newfolder = Path.Combine(path, dirname);
                    Directory.CreateDirectory(newfolder);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CREATED DATABASE DIRECTORY IN:" + newfolder);
                    Console.ResetColor();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (dirname == "")
                    {
                        Console.WriteLine("Write name of database");
                    }
                    else
                    {
                        Console.WriteLine("incorrect database name: " + dirname);
                    }
                    Console.ResetColor();
                    continue;
                }
            }
        }
    }
}
