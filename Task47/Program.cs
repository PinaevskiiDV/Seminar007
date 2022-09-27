Console.WriteLine("Введите количество строк массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int column = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[rows, column]; 
Random random = new Random();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < column; j++)
    {
        array[i, j] = random.NextDouble() * 10; 
        Console.Write("{0,9:F2}", array[i, j]);
    }
    Console.WriteLine();
}