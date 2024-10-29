Console.WriteLine("введите значение а");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение шага h");
int h = Convert.ToInt32(Console.ReadLine());
if (h <= 0)
{
    Console.WriteLine("ошибка! значение (h) должно быть положительным");
    return;
}
if (a >= b)
{
    Console.WriteLine("Ошибка! Значение (а) должно быть меньше значения (б)");

    return;
}
    static void y (int x)
    {

        if (x <= 0)
        {
            Console.WriteLine("Ошибка: Значение x должно быть положительным для логарифма.");
            return;
        }
    }
int count = ((b - a) / h) + 1;
var x_values = new double[count];
var y_values = new double[count];
var min_y = double.MaxValue;
var max_y = double.MinValue;
int crossing = 0;
for (int i = 0; i < count; i++)
{
    x_values[i] = a + i * h;
    y_values[i] = b + i * h;
    if (double.IsNaN(y_values[i]))

    {
        if (double.IsNaN(y_values[i]))
        {
            Console.WriteLine($"Ошибка: Невозможно вычислить значение функции для x = {x_values[i]}");
            return;
        }

        if (y_values[i] < min_y)
        {
            min_y = y_values[i];
        }
        if (y_values[i] > max_y)
        {
            max_y = y_values[i];
        }
 for (i = (int) 1; i < count; i++)
        {
            if ((y_values[i - 1] >= 0 && y_values[i] < 0) || (y_values[i - 1] <= 0 && y_values[i] > 0))
            {
                crossing++;
            }
        }
    }
    Console.WriteLine("Таблица");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("|       x      |      x(y)       |");
    Console.WriteLine("---------------------------------");
    Console.WriteLine($"Минимальное значение: {min_y}");
    Console.WriteLine($"Максимальное значение: {max_y}");
    Console.WriteLine($"Количество пересечений с осью X: {crossing}");
}