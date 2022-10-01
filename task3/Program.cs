Console.WriteLine("Введите размер трехмерного массива 1:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите размер трехмерного массива 2:");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите размер трехмерного массива 3:");
int z = int.Parse(Console.ReadLine());
int[,,] bigArray = new int[x, y, z];
int size = x * y * z;
int[] values = Enumerable.Range(10, 99).ToArray();

int m = 0;

if(size > 89)
{
    Console.WriteLine("Вы привысили размер возможного массива 2х значных чисел!!! ");
    return;
}

void FillArrayDifferentNumbers(int[,,] one, int[] two)
{
    Random random = new Random();
    for (int i = 0; i < one.GetLength(0); i++)
    {
        for (int j = 0; j < one.GetLength(1); j++)
        {
            for (int k = 0; k < one.GetLength(2); k++)
            {
                one[i, j, k] = two[m];
                m++;
            }
        }
    }
}

void PrintSuperArray(int[,,] one)
{
    for (int i = 0; i < one.GetLength(0); i++)
    {
        for (int j = 0; j < one.GetLength(1); j++)
        {
            for (int k = 0; k < one.GetLength(2); k++)
            {
                Console.Write(one[i, j, k] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[] Shuffle(int[] one)
{
    Random random = new Random();
    for (int i = size - 1; i >= 1; i--)
    {
        int j = random.Next(i + 1);
 
        int temp = one[j];
        one[j] = one[i];
        one[i] = temp;
    }
    return one;
}

Shuffle(values);
FillArrayDifferentNumbers(bigArray, values);
PrintSuperArray(bigArray);

 

 
 