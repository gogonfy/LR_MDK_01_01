using System;

namespace LR4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Названия цветов
            string[] names =
            {
                "роза",
                "тюльпан",
                "хризантема",
                "орхидея",
                "гипсофила"
            };

            // Цены
            int[] prices =
            {
                180,
                120,
                350,
                1200,
                90
            };

            // Количество на складе
            int[] quantities =
            {
                24,
                30,
                14,
                6,
                40
            };

            // Количество заказанных цветов
            int[] ordered = new int[5];


            // Подзадача 1
            Functions.ShowAssortment(
                names,
                prices,
                quantities
            );


            // Подзадачи 2-3
            Functions.CreateOrder(ordered);

            // Проверяем наличие всех цветов
            bool available = Functions.CheckAvailability(
                quantities,
                ordered,
                out int notEnoughFlower
            );


            if (!available)
            {
                // Если какого-то цветка не хватает
                Functions.ShowNotEnough(
                    names,
                    notEnoughFlower
                );
            }
            else
            {
                // Подзадача 4
                Functions.CalculatePrice(
                    names,
                    prices,
                    ordered
                );



   