using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DeletingCharacters
{
    class StringProcessing
    {
        //Написать метод, входными параметрами которого являются две строки.
        //Метод должен в первой заданной строке удалить каждый символ, принадлежащий и второй заданной строке.
        //При решении не использовать готовые строковые функции
        public void DeleteCharacter(string firstString, string secondString, out string outputString)
        {
            StringBuilder sb = new StringBuilder();
            HashSet<char> secondStringInSet = new HashSet<char>();

            //Добавим символы второй строки в HashSet
            for (int i = 0; i < secondString.Length; i++)
            {
                secondStringInSet.Add(secondString[i]);
            }

            //Добавим в StringBuilder только те символы, которых нет во второй строке, но есть в первой
            for (int i = 0; i < firstString.Length; i++)
            {
                if (!secondStringInSet.Contains(firstString[i]))
                {
                    sb.Append(firstString[i]);
                }
            }

            //Вернем результат в виде строки
            outputString = sb.ToString();
        }
        static void Main(string[] args)
        {
            string outputString;

            string firstString = "qwerty";
            Console.WriteLine("Первая строка: " + firstString);
            string secondString = "eryuiop";
            Console.WriteLine("Вторая строка: " + secondString);

            StringProcessing searchDelete = new StringProcessing();
            searchDelete.DeleteCharacter(firstString, secondString, out outputString);

            Console.WriteLine("Первая строка " + firstString);
            Console.WriteLine("Результат после анализа: " + outputString);

            Console.ReadKey();
        }
    }
}