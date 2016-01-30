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
        public void DeleteCharacter(ref string firstString, string secondString)
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
            firstString = sb.ToString();
        }
        static void Main(string[] args)
        {
            string firstString = "qwerty";
            Console.WriteLine("Первая строка: " + firstString);
            string secondString = "eryuiop";
            Console.WriteLine("Вторая строка: " + secondString);

            StringProcessing searchDelete = new StringProcessing();
            searchDelete.DeleteCharacter(ref firstString, secondString);

            Console.WriteLine("Первая строка после анализа: " + firstString);

            Console.ReadKey();
        }
    }
}