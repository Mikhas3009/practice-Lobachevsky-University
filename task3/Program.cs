using task3;
using System;

public class Task3 {
    public static void Main(String[] args)
    {
        MyArray arr = new(10);
        arr.initialization();
        arr.print();

        Console.WriteLine("Минимальный элемент: "+ arr.getMin());
        Console.WriteLine("Максимальный элемент: " + arr.getMax());
        Console.WriteLine("Медиана: " + arr.getMed());
        Console.WriteLine("Отсортированный: " );
        arr.mySort();
        arr.print();


        Console.WriteLine("Первый массив ");
        MyArray arr2 = new(5);
        arr2.initialization();
        arr2.print();
        MyArray arr3 = new(5);
        arr3.initialization();
        Console.WriteLine("Второй массив");
        arr3.print();
        MyArray sumArray = MyArray.sumTwo(arr2, arr3);
        Console.WriteLine("Сумма");
        sumArray.print();
        sumArray = MyArray.multiplication(arr2, arr3);
        Console.WriteLine("Произведение");
        sumArray.print();
        int[]commons = MyArray.findCommon(arr2, arr3);
        Console.WriteLine("Одинаковые элементы");
        foreach (var item in commons)
        {
            Console.WriteLine(item);
        }
    }
}
