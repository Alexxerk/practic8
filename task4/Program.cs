//Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника.

float y = 0;
int i, c;
Console.WriteLine("Введите количество строк треугольника Паскаля:");
int s = int.Parse(Console.ReadLine());
float factorial(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}
        
for (i = 0; i < s; i++)
    {
        float[] array = new float[i + 1];
        for (c = 0; c <= i; c++)
        {
            y = factorial(i) / (factorial(c) * factorial(i - c));
            array[c] = y;
        }
        Console.SetCursorPosition((Console.WindowWidth - array.Length) / 2, Console.CursorTop);
        for (c = 0; c <= i; c++)
        {
            Console.Write(array[c]);
            Console.Write(" ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
            

            