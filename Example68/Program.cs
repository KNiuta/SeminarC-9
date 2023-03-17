
/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
              Даны два неотрицательных числа m и n.
              m = 2, n = 3 -> A(m,n) = 9
              m = 3, n = 2 -> A(m,n) = 29 */

Console.Write("Введите число M: ");
int numberFrist = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(AkkermanFunction(numberFrist,numberSecond));

/// <summary>
/// метод вычисления функции Аккермана
/// </summary>
/// <param name="value1">первое число</param>
/// <param name="value2">второе число</param>
/// <returns>результат вычисления функции Аккермана</returns>
int AkkermanFunction(int value1, int value2)
{
    if (value1 == 0)  return value2 + 1;
    if (value2 == 0 && value1 > 0)  return AkkermanFunction(value1 - 1, 1);
    return (AkkermanFunction(value1 - 1, AkkermanFunction(value1, value2 - 1)));
}
