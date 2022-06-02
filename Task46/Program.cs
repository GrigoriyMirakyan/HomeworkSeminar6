//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

//не уверен, что корректно заданы формулы, искал правильные в интернете



int GetNumber(string msg) //функция считывающая введенное число + проверка что число является числом)
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            return number;

        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число.");
        }
    }
}

(double, double) Calculation(int b1, int k1, int b2, int k2)// расчет пересечения
{
    double x = (double)(b2 - b1) / (k1 - k2);
    double y = (double)(k1 * x + b1);
    return (x, y);
}




int b1 = GetNumber("Введите значение b1");
int k1 = GetNumber("Введите значение k1");
int b2 = GetNumber("Введите значение b2");
int k2 = GetNumber("Введите значение k2");

if (k1 == k2)
    Console.WriteLine("Линии не пересекаются");
else
{
    (double x, double y) = Calculation(b1, k1, b2, k2);
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} - > точка пересечения ({x:N1}; {y:N1})");
}