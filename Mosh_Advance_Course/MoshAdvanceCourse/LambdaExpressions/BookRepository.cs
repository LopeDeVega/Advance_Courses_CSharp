using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book(){ Title = "Game of Throne", Price = 65.45},
                new Book(){ Title = "The Prince" , Price = 9.99},
                new Book(){ Title = "The pilard of the world", Price = 49.50},
                new Book(){ Title = "The Shining", Price = 25.25 }
            };
        }
    }
}
