using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpressions
{
    public class CarRepository
    {
        public List<Car> GetCars()
        {
            return new List<Car>()
            {
                new Car() {Brand = "Seat", Price = 25000 },
                new Car() {Brand = "Ferrari", Price = 125000 },
                new Car() {Brand = "Magda", Price = 45000 },
                new Car() {Brand = "Porche", Price = 89000 },
            };
        }
    }
}
