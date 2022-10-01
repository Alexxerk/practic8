//В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

Console.WriteLine("Введите размер двумерного массива i: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите размер двумерного массива j: ");
int y = int.Parse(Console.ReadLine());
int[,] array = new int[x, y];
int[,] twoArray = new int[x - 1, y - 1];
 
int min = 0;
int k = 0;
int a = 0;
int m = 0;
int n = 0;

void FillArray(int[,] one)
{
    for (int i = 0; i < one.GetLength(0); i++)
    {
        for (int j = 0; j < one.GetLength(1); j++)
        {
            one[i, j] = new Random().Next(1, 100);
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

void FindMinimalElement(int[,] one)
{
    min = one[0, 0];
    for (int i = 0; i < one.GetLength(0); i++)
    {
        for (int j = 0; j < one.GetLength(1); j++)
        {
            if(min > one[i, j])
            {
                min = one[i, j];
                k = i;
                a = j;
            }       
        }
    }
    Console.WriteLine("Индекс == (" + k + ", " + a + ") минимального элемента массива == " + min);
}
int j = 0;
int[,] DeleteStringAndСolumn(int[,] one, int[,] two) //Вообщем не могу понять почему переполнение происходит пробовал по разному, запарился((
{
    for (int i = 0; i < two.GetLength(0); i++)
    {
        if(i == k) m++;
        two[i, j] = one[m, n];
        m++;
        for (int j = 0; j < two.GetLength(1); j++)
        {
            if(j == a) n++;
            two[i, j] = one[m, n];
        }
    }
    return two;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
FindMinimalElement(array);
j = 0;
DeleteStringAndСolumn(array, twoArray);
PrintArray(twoArray);