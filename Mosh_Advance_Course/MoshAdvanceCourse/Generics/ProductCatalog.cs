using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class ProductCatalog<T>  where T : Product 
    {
        private readonly T[] productsArr = new T [100];
        private int count = 0;
        
        public void AddProduct(T product)
        {
            if(count > productsArr.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), count, $"Index must be between 0 and {count - 1}.");
            }
            productsArr[count++] = product;
        }

        public T GetProduct(int i)
        {

            if(i < 0 || i >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(i), i, $"Index must be between 0 and {count - 1}.");
            }
            return productsArr[i];
        }
    }
}
