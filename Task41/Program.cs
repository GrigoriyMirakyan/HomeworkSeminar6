/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int numbersInput(int numberCount)
{
    Console.WriteLine("Вводите числа через ENTER :");
    int count = 1;
    int countPositive = 0;
    int number = 0;
    while (count <= numberCount)
    {
        Console.Write($"{count} число : ");
        number = int.Parse(Console.ReadLine());
        count++;
        if (number > 0)
            countPositive++;
    }
    return countPositive;
}




Console.Write("Сколько чисел вы хотите ввести :");
int M = int.Parse(Console.ReadLine());

int count = numbersInput(M);
Console.Write($"Чисел больших чем 0 - > {count}");


