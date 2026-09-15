using LR1;
using System;

namespace LR1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса Work
            Work work = new Work();

            // Ввод данных
            double proteins = work.GetInput("Введите белки (г): ", "белков");
            double fats = work.GetInput("Введите жиры (г): ", "жиров");
            double carbohydrates = work.GetInput("Введите углеводы (г): ", "углеводов");
            int portions = work.GetPortionsInput();

            // Расчеты
            double totalCalories = work.CalculateTotalCalories(proteins, fats, carbohydrates);
            double caloriesPerPortion = work.CalculateCaloriesPerPortion(totalCalories, portions);
            string classification = work.GetClassification(totalCalories);

            // Вывод результатов
            work.PrintResults(totalCalories, caloriesPerPortion, classification);

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}