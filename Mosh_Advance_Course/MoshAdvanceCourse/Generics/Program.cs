namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tv = new TV("Samsung");
            var headPhone = new HeadPhones("Bose");
            var tablets = new Tablets("Apple");

            var productDisplayer = new ProductCatalog<TV>();
            productDisplayer.AddProduct(tv);

            var productDisplayer2 = new ProductCatalog<HeadPhones>();
            productDisplayer2.AddProduct(headPhone);

            var productDisplayer3 = new ProductCatalog<Tablets>();
            productDisplayer3.AddProduct(tablets);

            var product = productDisplayer.GetProduct(2);

            Console.WriteLine(product.Brand);

            var product2 = productDisplayer2.GetProduct(0);
            Console.WriteLine(product2.Brand);


            var product3 = productDisplayer3.GetProduct(0);
            Console.WriteLine(product3.Brand);
        }
    }
}
