namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tv = new TV("Samsung");
            var headPhone = new HeadPhones("Bose");
            var tablets = new Tablets("Apple");

            //var productDisplayer = new ProductCatalog<TV>();
            //productDisplayer.AddProduct(tv);

            //var productDisplayer2 = new ProductCatalog<HeadPhones>();
            //productDisplayer2.AddProduct(headPhone);

            //var productDisplayer3 = new ProductCatalog<Tablets>();
            //productDisplayer3.AddProduct(tablets);

            //var product = productDisplayer.GetProduct(2);

            //Console.WriteLine(product.Brand);

            //var product2 = productDisplayer2.GetProduct(0);
            //Console.WriteLine(product2.Brand);


            //var product3 = productDisplayer3.GetProduct(0);
            //Console.WriteLine(product3.Brand);

            //var productCatalog = new ProductCatalog<Product>();
            //productCatalog.AddProduct(tv);
            //productCatalog.AddProduct(headPhone);
            //productCatalog.AddProduct(tablets);

            //var product = productCatalog.GetProduct(2);

            //Console.WriteLine(product.Brand);


            //var value = new Nulable<int>(3);

            //var print = value.GetValue();

            //Console.WriteLine(print);

            //value = new Nulable<int>();

            //print = value.GetValue();

            //Console.WriteLine(print);

            var product1 = new TV("Sony");
            var product2 = new HeadPhones("LG");

            var biggerNumber = new ComparableHelper<int>();

            List<int> numbers = new() { 34, 56, 3434, 1000, 4, 1 };

            var result = biggerNumber.GetBiggerNumber(1000, numbers[0]);

            Console.WriteLine($"Bigger Number: {result}");

            var aphabetic = new ComparableHelper<string>();

            var result2 = aphabetic.FirstAlphabetic(product1.Brand, product2.Brand);

            Console.WriteLine($"Alphabetic: {result2}");
        }
    }
}
