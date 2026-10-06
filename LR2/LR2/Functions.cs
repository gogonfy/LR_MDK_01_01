using System;

namespace LR4
{
    public static class Functions
    {
        // Вывод ассортимента
        public static void ShowAssortment(
            string[] names,
            int[] prices,
            int[] quantities)

        {
            Console.WriteLine("Ассортимент:");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(
                    $"{i + 1}. {names[i]} — {prices[i]} руб., {quantities[i]} шт."
                );
            }

            Console.WriteLine();
        }

        // Ввод номера цветка
        public static int GetFlowerNumber()
        {
            while (true)
            {
                Console.Write("Введите номер цветка (0 — конец заказа): ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    if (number >= 0 && number <= 5)
                    {
                        return number;
                    }
                }

                Console.WriteLine("Ошибка! Введите число от 0 до 5.");
            }
        }

        // Ввод количества цветов
        public static int GetQuantity()
        {
            while (true)
            {
                Console.Write("Введите количество: ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out int quantity))
                {
                    if (quantity >= 0)
                    {
                        return quantity;
                    }
                }

                Console.WriteLine(
                    "Ошибка! Количество должно быть целым числом >= 0."
                );
            }
        }