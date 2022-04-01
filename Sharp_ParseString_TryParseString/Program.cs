using System;
using System.Globalization;


namespace Sharp_ParseString_TryParseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              string str = "5";

            //парсим str в переменную a
            int a = int.Parse(str);
            */

            /*string str = "5.9";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            //парсим str в переменную a
            double a = double.Parse(str, numberFormatInfo);*/

            /*
            string str = "1hgdhgf";
            try
            {
                int a = Convert.ToInt32(str);
                Console.WriteLine("Успешная конвертация");
            }
            catch (Exception)
            {

                Console.WriteLine("Ошибка при конвертации");
            }
            */

            string str = "1 ора";
            int a;

            //метот принимает 2 параметра
            //первый параметр это строка
            //второй параметр переменная которая сохранит спарсенное значение наружу благодаря модификатору out
            //Метот TryParse помимо спарсенной величины, возвращает булевое значение
            //при успехе возвращает True
            //при неудаяе False
            bool result = int.TryParse(str, out a);

            if(result)
            {
                Console.WriteLine($"Операция успешна, значение = {a}");
            }
            else
            {
                Console.WriteLine("Не удалось конвертировать!");
            }
        }
    }
}
