using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Store.UI.Functionality
{
    internal class Confirmation
    {
        public static bool GetConfirmation(string message)
        {
            Console.Write($"{message} (s/n)");
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.KeyChar != 's' && key.KeyChar != 'n')
            {
                Console.Write("\nEntrada inválida. Digite 's' ou 'n': ");
                key = Console.ReadKey();
            }
            Console.WriteLine();

            return key.KeyChar == 's';
        }   
    }
}
