using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleUI
{
    public class Program
    {
        private static ShoppingCartModel cart = new ShoppingCartModel();

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            PopulateCartWithDemoData();
            Console.WriteLine($"The total for the cart with discount: {cart.GenerateTotal(SubTotalAlert, CalculateLeveledDiscount, AlertUser):C2}");
            Console.WriteLine();
            Thread.Sleep(3000);
            decimal total = cart.GenerateTotal(
                (subTotal) => {
                    Console.WriteLine($"The subtotal for cart 2: {subTotal:C2}");
                    Thread.Sleep(3000);
                },
                (products, subTotal) => {
                    if(products.Count > 3)
                    {
                        return subTotal * 0.50M;
                    }
                    else
                    {
                        return subTotal;
                    }
                },
                (message) => {
                    Console.WriteLine($"Cart 2 Alert: {message}");
                    Thread.Sleep(3000);
                }
            );
            Console.WriteLine($"The total for the cart 2: {total:C2}");
            Thread.Sleep(3000);
            Console.WriteLine();
            Console.Write("Please  press any key to exit the application...");
            Console.ReadKey();
        }

        private static void SubTotalAlert(decimal subTotal)
        {
            Console.WriteLine($"The subtotal for the cart: {subTotal:C2}");
            Thread.Sleep(3000);
        }

        private static void AlertUser(string message)
        {
            Console.WriteLine(message);
            Thread.Sleep(3000);
        }

        private static decimal CalculateLeveledDiscount(List<ProductModel> items, decimal subTotal)
        {
            if (subTotal > 100)
            {
                return subTotal * 0.80M;
            }
            else if (subTotal > 50)
            {
                return subTotal * 0.85M;
            }
            else if (subTotal > 10)
            {
                return subTotal * 0.90M;
            }
            else
            {
                return subTotal;
            }
        }

        private static void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { Id = Guid.NewGuid(), ItemName = "Cereal", Price = 3.63M});
            cart.Items.Add(new ProductModel { Id = Guid.NewGuid(), ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { Id = Guid.NewGuid(), ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { Id = Guid.NewGuid(), ItemName = "Blueberries", Price = 8.84M });
        }
    }
}
