

int row = new Random().Next(2, 6);
int column = new Random().Next(2, 6);
int[,] arr = new int[row, column];
double[] average = new double[column];
Random rnd = new Random();

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        arr[i, j] = rnd.Next(1, 10);

        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i = 0; i < column; i++)
{
    for (int j = 0; j < row; j++)
    {
        average[i] += arr[j, i];
    }
}

Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца:");

for (int i = 0; i < column; i++)
{
    Console.Write("{0: 0.000}",(average[i] / row) + "; ");
}
