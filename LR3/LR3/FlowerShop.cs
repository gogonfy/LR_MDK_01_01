using System;

namespace LR3
{
    /// <summary>
    /// Цветочный магазин: ассортимент, корзина покупателя и обработка заказа.
    /// </summary>
    public class FlowerShop
    {
        // Массив ассортимента и массив выбранных количеств по позициям.
        private readonly Product[] assortment_;
        private readonly int[] requested_;

        public FlowerShop()
        {
            assortment_ = new Product[]
            {
                new Product("роза", 180, 24),
                new Product("тюльпан", 120, 30),
                new Product("хризантема", 350, 14),
                new Product("орхидея", 1200, 6),
                new Product("гипсофила", 90, 40)
            };

            requested_ = new int[assortment_.Length];
        }

        public void PrintAssortment()
        {
            Console.WriteLine("Ассортимент:");

            for (int i = 0; i < assortment_.Length; i++)
            {
                Product product = GetProduct((ProductType)(i + 1));
                Console.WriteLine("{0}. {1} — {2} руб., {3} шт.",
                    i + 1, product.GetName(), product.GetPrice(), product.GetQuantity());
            }
        }

        private Product GetProduct(ProductType type)
        {
            // Значения enum начинаются с 1, поэтому индекс массива на единицу меньше.
            int index = (int)type - 1;
            return assortment_[index];
        }

        private static int ReadIntInRange(string prompt, int min, int max)
        {
            int value = 0;
            bool isValid = false;

            for (int attempt = 0; !isValid; attempt++)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (!int.TryParse(input, out value))
                {
                    Console.WriteLine("Ошибка: введите целое число.");
                }
                else if (!IsInRange(value, min, max))
                {
                    Console.WriteLine("Ошибка: число должно быть в диапазоне от {0} до {1}.", min, max);
                }
                else
                {
                    isValid = true;
                }
            }

            return value;
        }

        private static bool IsInRange(int value, int min, int max)
        {
            return value >= min && value <= max;
        }

        private static int ReadNonNegativeInt(string prompt)
        {
            int value = 0;
            bool isValid = false;

            for (int attempt = 0; !isValid; attempt++)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (!int.TryParse(input, out value))
                {
                    Console.WriteLine("Ошибка: введите целое число.");
                }
                else if (IsNegative(value))
                {
                    Console.WriteLine("Ошибка: количество не может быть отрицательным.");
                }
                else
                {
                    isValid = true;
                }
            }

            return value;
        }

        private static bool IsNegative(int value)
        {
            return value < 0;
        }

        public void ReadOrder()
        {
            // Очищаем корзину перед новым заказом.
            for (int i = 0; i < requested_.Length; i++)
            {
                requested_[i] = 0;
            }

            const string numberPrompt = "Введите номер цветка (0 — конец заказа): ";

            for (int number = ReadIntInRange(numberPrompt, 0, assortment_.Length);
                 number != 0;
                 number = ReadIntInRange(numberPrompt, 0, assortment_.Length))
            {
                int quantity = ReadNonNegativeInt("Введите количество: ");
                requested_[number - 1] += quantity;
            }
        }
    }
}
