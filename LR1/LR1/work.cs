using System;

namespace LR1
{
    // Класс со всей логикой программы
    public class Work
    {
        // Подзадача 1: Ввод массы нутриента с валидацией
        public double GetInput(string prompt, string nutrientName)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, out double value) && value >= 0)
                {
                    return value;
                }
                Console.WriteLine($"Ошибка: количество {nutrientName} должно быть числом >= 0. Повторите ввод.");
            }
        }

        // Подзадача 2: Ввод количества порций с валидацией
        public int GetPortionsInput()
        {
            while (true)
            {
                Console.Write("Введите количество порций: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int portions) && portions > 0)
                {
                    return portions;
                }
                Console.WriteLine("Ошибка: количество порций должно быть целым числом > 0. Повторите ввод.");
            }
        }

        // Подзадача 3: Расчет общей калорийности
        public double CalculateTotalCalories(double proteins, double fats, double carbohydrates)
        {
            return (proteins * 4) + (fats * 9) + (carbohydrates * 4);
        }

        // Подзадача 4: Расчет калорийности на порцию
        public double CalculateCaloriesPerPortion(double totalCalories, int portions)
        {
            return totalCalories / portions;
        }

        // Подзадача 5: Классификация блюда
        public string GetClassification(double totalCalories)
        {
            if (totalCalories <= 200)
                return "низкокалорийное";
            else if (totalCalories <= 500)
                return "средней калорийности";
            else
                return "высококалорийное";
        }

        // Подзадача 6: Вывод результатов
        public void PrintResults(double totalCalories, double caloriesPerPortion, string classification)
        {
            Console.WriteLine($"Общая калорийность: {totalCalories} ккал");
            Console.WriteLine($"Калорийность на порцию: {caloriesPerPortion} ккал");
            Console.WriteLine($"Классификация: {classification}");
        }
    }
}