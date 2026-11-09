using System;
using System.Text;

namespace LR3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            FlowerShop shop = new FlowerShop();
            shop.PrintAssortment();
            shop.ReadOrder();
        }
    }
}
