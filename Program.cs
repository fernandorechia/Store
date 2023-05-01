using Store.Model;
using Store.UI;

namespace Store
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Model.Manager.CategoryManager.PopulateDefaultCategories();
            Model.Manager.CustomerManager.PopulateDefaultCustomers();
            MAINMenu.MainMenu();





        }
    }
}
