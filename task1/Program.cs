//Найти произведение двух матриц.

Console.WriteLine("Введите размер 1го двумерного массива i: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите размер 1го двумерного массива j: ");
int y = int.Parse(Console.ReadLine());
int[,] arrayOne = new int[x, y];

Console.WriteLine("Введите размер 2го двумерного массива i: ");
int z = int.Parse(Console.ReadLine());
Console.WriteLine("Введите размер 2го двумерного массива j: ");
int a = int.Parse(Console.ReadLine());
int[,] arrayTwo = new int[z, a];

int sumElements = (x * y) + (z * a);
int[] allElements = new int[sumElements];
int p = 1;

void FillArray(int[,] one)
{
    for (int i = 0; i < one.GetLength(0); i++)
    {
        for (int j = 0; j < one.GetLength(1); j++)
        {
            one[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] two)
{
    for (int i = 0; i < two.GetLength(0); i++)
    {
        for (int j = 0; j < two.GetLength(1); j++)
        {
            Console.Write(two[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

void ProizvedenieMatrix(int[,] one, int[,] two)
{
    for (int i = 0; i < one.GetLength(0); i++)
    {
        for (int j = 0; j < one.GetLength(1); j++)
        {
            p = p * one[i, j];
        }
    }
    for (int i = 0; i < two.GetLength(0); i++)
    {
        for (int j = 0; j < two.GetLength(1); j++)
        {
            p = p * two[i, j];
        }
    }
    Console.WriteLine("Произведение всех эелементов 2х матриц == " + p);
}

FillArray(arrayOne);
PrintArray(arrayOne);
Console.WriteLine();
FillArray(arrayTwo);
PrintArray(arrayTwo);
ProizvedenieMatrix(arrayOne, arrayTwo);
