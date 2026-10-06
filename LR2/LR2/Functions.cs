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

        // Формирование заказа
        public static void CreateOrder(
            int[] ordered)
        {
            while (true)
            {
                int number = GetFlowerNumber();

                // 0 — завершение заказа
                if (number == 0)
                {
                    break;
                }

                int quantity = GetQuantity();

                // Добавляем количество к выбранному цветку
                ordered[number - 1] += quantity;

                Console.WriteLine();
            }
        }

        // Проверка наличия цветов
        public static bool CheckAvailability(
            int[] quantities,
            int[] ordered,
            out int notEnoughFlower)
        {
            notEnoughFlower = -1;

            for (int i = 0; i < quantities.Length; i++)
            {
                if (ordered[i] > quantities[i])
                {
                    notEnoughFlower = i;
                    return false;
                }
            }

            return true;
        }

        // Расчёт стоимости заказа
        public static int CalculatePrice(
            string[] names,
            int[] prices,
            int[] ordered)
        {
            int totalPrice = 0;

            Console.WriteLine();
            Console.WriteLine("Расчёт стоимости:");

            for (int i = 0; i < names.Length; i++)
            {
                if (ordered[i] > 0)
                {
                    int price = prices[i];
                    int quantity = ordered[i];

                    // Стоимость данного вида цветов
                    int result = price * quantity;

                    Console.WriteLine(
                        $"{price} × {quantity} = {result} руб. ({names[i]})"
                    );

                    // Добавляем к общей стоимости
                    totalPrice += result;
                }
            }

            Console.WriteLine();
            Console.WriteLine(
                $"Итого: {totalPrice} руб."
            );

            return totalPrice;
        }