using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBD
{
    internal class DBvalidation
    {
        static readonly char[] invalidsymbols = { '~', '@', '#', '$', '%', '^', '-', '_', '(', ')', '{', '}', '`', '+', '=', '[', ']', ':',
            ',', ';',',', '.', '/', '?','/','\\',':','*','?','«','»','<','>','|','&','—' };
        public static bool IsValidDirName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < invalidsymbols.Length; j++)
                {
                    if (name[i] == invalidsymbols[j])
                    {
                        return false;
                    }
                }

            }
            return true;
        }
    }
}
