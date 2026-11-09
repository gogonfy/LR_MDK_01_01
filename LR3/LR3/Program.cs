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

            int totalCost;
            string missingProductName;

            if (shop.TryProcessOrder(out totalCost, out missingProductName))
            {
                Console.WriteLine("Стоимость заказа: {0} руб.", totalCost);
            }
            else
            {
                Console.WriteLine("Недостаточно цветка: {0}.", missingProductName);
            }
        }
    }
}
