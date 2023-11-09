// See https://aka.ms/new-console-template for more information
using lab1_classes_;
using System.Runtime.CompilerServices;

Console.WriteLine("Введите число строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int rows = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[lines,rows];

for (int i = 0; i < lines; i++) {
    Console.WriteLine($"Заполните {i+1} строку через пробел: ");
    string val = Console.ReadLine();
    string[] elements = val.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0; j < rows; j++) {
        int elem;
        if (j >= elements.Length)
        {
            array[i, j] = 0;
        }
        else {
            bool success = int.TryParse(elements[j], out elem);
            if (success){
                array[i, j] = elem;
            }
            else{
                array[i, j] = 0;
            }
        } 
    }
}
Console.WriteLine("Введенный массив:");
for (int i = 0; i < lines; i++)
{
    for (int j = 0; j < rows; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

MethodsArr arr = new MethodsArr(ref array);
//Минимальный элемент
try {
    for (int i = 0; i < lines;i++) {
        Console.WriteLine($"Строка: {i+1}, Минимальный элемент: {arr.getMin(i)} ");
    }
}
catch (Exception ex) {
    Console.WriteLine(ex.Message);
}

//Максимальный элемент
try{
    for (int i = 0; i < lines; i++)
    {
        Console.WriteLine($"Строка: {i + 1}, Максимальный элемент: {arr.getMax(i)} ");
    }
}
catch (Exception ex){
    Console.WriteLine(ex.Message);
}

//Сумма строки
try
{
    for (int i = 0; i < lines; i++)
    {
        Console.WriteLine($"Строка: {i + 1}, Сумма элемент: {arr.getSumStr(i)} ");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}