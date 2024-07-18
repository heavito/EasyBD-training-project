using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 0 - завершение путем команды
// 1 - отмена работы функции (возвращение в программу)
internal class ExitProgramm
{
    public int exit(int exitCode)
    {
        if (exitCode == 0)
        {
            while (true)
            {
                Console.WriteLine("Do you want leave?\nY/n");
                string? userWrite = Console.ReadLine();
                if (userWrite != null && userWrite == "Y" || userWrite == "y")
                {
                    Console.WriteLine("Exiting with status code:" + exitCode);
                    return exitCode;
                }
                if (userWrite != null && userWrite == "N" || userWrite == "n")
                { 
                    return 1;
                }
                else
                {
                    continue;
                }
            }
        }
        else
        {
            return exitCode;
        }
    }
}
