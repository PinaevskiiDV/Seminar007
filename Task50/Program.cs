
Console.Write("Введите строку:");
int row = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец:");
int column = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 3;
int m = 4;
Random random = new Random();
int[,] arr = new int[n, m];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write("{0} ", arr[i, j]);
    }
    Console.WriteLine();
}
if (row < 0 | row > arr.GetLength(0) - 1 | column < 0 | column > arr.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[row, column]);
}
Console.ReadLine();