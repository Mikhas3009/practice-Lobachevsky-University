// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
int numOfFreePlace = 0;
int[] res = new int[n];
Array.Fill(res, -1);
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = rnd.Next(0, 2);
        Console.Write(matrix[i, j]);
        Console.Write(' ');
    }
    Console.WriteLine();
}
Console.WriteLine("Введите Число билетов");
int k = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++) {
    for (int j = 0;j<m; j++) {
        if (matrix[i, j] == 0) {
            numOfFreePlace++;
        }
    }
    if (numOfFreePlace >= k) {
        res[i] = i + 1;
    }
    numOfFreePlace = 0;
}
Console.WriteLine("\nНомер ряда: ");
int index = Array.FindIndex(res, elem => elem != -1);
Console.WriteLine(res[index]);

