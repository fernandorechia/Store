using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UI
{
    public class Menu
    {   
        // Fields
        private readonly List<string> options;

        // Methods
        // Constructor
        public Menu(List<string> _options)
        {
            this.options = _options;
        }

        public int Display()
        {
            while (true)
            {
                Console.WriteLine("Selecione uma opção:");

                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {options[i]}");
                }

                string input = Console.ReadLine();

                if (int.TryParse(input, out int selection) && selection >= 1 && selection <= options.Count) { 
                    
                    Console.Clear();
                    return selection - 1;
                }

                Console.Clear();
                Console.WriteLine("Seleção inválida. Escolha um dos números listados.");
            }
        }



    }
}
