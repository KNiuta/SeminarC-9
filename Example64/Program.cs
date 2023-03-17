/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"
*/

 Console.Write("Введи число М: ");
int numberFrist = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введи число N: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumbers(numberFrist,numberSecond));


/// <summary>
/// Метод печати всех натуральных чисел в промежудке от M до N 
/// </summary>
/// <param name="start">начальное значение промежутка</param>
/// <param name="end">конечное значение промежутка</param>
/// <returns>вывод натуральных чисел</returns>
string PrintNumbers (int start,int end)
{
              if(start==end) return start.ToString();
              return (start + "," + PrintNumbers(start+1,end));
}
