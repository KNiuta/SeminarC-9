

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
              сумму натуральных элементов в промежутке от M до N.

              M = 1; N = 15 -> 120
              M = 4; N = 8. -> 30 */

 Console.Write("Введи число N: ");
int numberFrist = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введи число M: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNumbers(numberFrist,numberSecond));


/// <summary>
/// Метод нахождения суммы элементов в заданном промежутке от N до M
/// </summary>
/// <param name="number1">начальное значение промежутка</param>
/// <param name="number2">конечное значение промежутка</param>
/// <returns>сумма элементов</returns>
int SumNumbers(int number1, int number2)
{
              if(number1==number2) return number1;
              return (number2+SumNumbers(number1,number2-1));
}
