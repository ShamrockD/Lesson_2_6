using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6. Загадка. 6 баллов. +1 балл
            /* У вас есть загадка и вы загадываете ему её.Создайте программу, которая будет считывать с консоли ответ:
             -У пользователя есть 3 попытки.После трех ответов программа должна завершиться;
             -Если пользователь вводит правильный ответ, мы выводим в консоль "Правильно!" и выходим из цикла;
             -Если пользователь вводит "Сдаюсь", мы выводим в консоль "Правильный ответ: троллейбус." и выходим из цикла;
             -Если пользователь вводит любой другой ответ, мы выводим в консоль "Подумай еще." и продолжаем цикл.
             Дополнительные балл если программа будет нормально реагировать на троллейбус, ТРОЛЛЕЙБУС и прочие вариации одной и той же строки.
             Троллейбус – пример.*/

            int tryOuts = 3;

            Console.WriteLine("Загадка: " +
                "По асфальту идет дом," +
                "Ребятишек много в нем," +
                "А над крышей вожжи," +
                "Он ходить без них не может.");
            bool tryChecker = true;
            while(tryChecker && tryOuts > 0)
            {
                Console.WriteLine($"Попыток осталось: {tryOuts}");
                tryOuts--;
                string userAnswer = Console.ReadLine();
                switch (userAnswer.ToLower())
                {
                    case "троллейбус":
                        Console.WriteLine("Правильно!");
                        tryChecker = false;
                        break;
                    case "сдаюсь":
                        Console.WriteLine("Правильный ответ: троллейбус.");
                        tryChecker = false;
                        break;
                    default:
                        Console.WriteLine("Подумай еще.");
                        break;
                }
            }
        }
    }
}
