using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Square(5));

            Func<int, int, int> sum = (numb1, numb2) => numb1 + numb2;
            var result = sum(4, 5);

            Console.WriteLine(result);

            int[] productPrice = { 110, 25, 85, 4, 24, 63, 17 };

            var cheap = CheaperThan(productPrice, prod => prod < 25);

            Console.WriteLine(string.Join(", ", cheap));

            var books = new BookRepository().GetBooks();

            var filteredBooks = ValueFilter(books, book => book.Price < 10);

            foreach(var fBook in filteredBooks)
            {
                Console.WriteLine($"Book: { fBook.Title}");
            }

            var cars = new CarRepository().GetCars();

            var fitelredCars = ValueFilter(cars, card => card.Price > 50000);

            foreach(var fCar in fitelredCars)
            {
                Console.WriteLine($"Cars: {fCar.Brand }");
            }
        }

        static List<T> ValueFilter<T> (List<T> Products, Func<T, bool> condition)
        {
            List<T> result = new List<T>();

            foreach(var product in Products)
            {
                if (condition(product))
                {
                    result.Add(product);
                }
            }

            return result;
        }

        static int Square(int numb) => numb * numb;

        //static int [] CheaperThan(int[] products, int value)
        //{
        //    List<int> result = new List<int>();

        //    for (int i = 0; i < products.Length; i++)
        //    {
        //        if (products[i] < value)
        //        {
        //            result.Add(products[i]);
        //        }
        //    }

        //    return result.ToArray();
        //}

        //Using -> Lamb and Generics
        static T[] CheaperThan<T>(T[] products, Func<T, bool> condition)
        {
            List<T> result = new List<T>();

            for (int i = 0; i < products.Length; i++)
            {
                if (condition(products[i]))
                {
                    result.Add(products[i]);
                }
            }

            return result.ToArray();
        }
    }
}
