using Store.Model;
using Store.UI;


namespace Store
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            
        Model.Manager.CustomerManager.PopulateDefaultCustomers();

        //Populate default categories
        Category camisa = new Category("camisa", "camisa normal");
        Category calca = new Category("calça", "calça normal");
        Category jaqueta = new Category("jaqueta", "jaqueta normal");
        Model.Manager.CategoryManager.Add(camisa);
        Model.Manager.CategoryManager.Add(calca);
        Model.Manager.CategoryManager.Add(jaqueta);

        //Populate default products
        Product branca = new Product(camisa, "camisa1", "branca", 56);
        Product preta = new Product(camisa, "camisa2", "preta", 34);
        Product cinza = new Product(calca, "calca1", "cinza", 64);
        Product bege = new Product(jaqueta, "jaqueta1", "bege", 129);
        Model.Manager.ProductManager.AddProduct(branca);
        Model.Manager.ProductManager.AddProduct(preta);
        Model.Manager.ProductManager.AddProduct(cinza);
        Model.Manager.ProductManager.AddProduct(bege);


        MAINMenu.MainMenu();
            
        }
    }
}
