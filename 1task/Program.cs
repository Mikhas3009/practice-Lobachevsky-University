using System;
using System.Linq.Expressions;

public class Task1 {

    private const int N = 10;
    static void Main(string[] args)
    {
        int[] myArray = new int[N];
        Array.Fill(myArray, 0);
        System.Console.WriteLine("Введите K");
        int K = Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("Введите M");
        int M = Convert.ToInt32(System.Console.ReadLine());

        try{
           myArray =  myInsert(myArray, K, M);
        }
        catch (Exception err){
            Console.WriteLine(err.Message);
        }
        finally {
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
        }
        //2 задание
        for(int i =0; i< myArray.Length/2; i++){
            int tmp = myArray[i];
            myArray[i]=myArray[i+myArray.Length/2];
            myArray[i+myArray.Length/2]= tmp;
        }
        Console.WriteLine("\n 2 Задание");
        foreach (var item in myArray)
        {
            Console.WriteLine(item);
        }

    }

    static int[] myInsert(int[] myArray,int K, int M)
    {
        if (K > myArray.Length){
            throw new Exception("Позиция K не может быть больше чем длина массива!");
        }
        if (K<0) {
            throw new Exception("K не может быть отрицательным!");
        }
        Array.Resize(ref myArray, M+myArray.Length);

        for (int i = K-1; i < K + M-1; i++) {
            System.Console.WriteLine("Введите вставляемый элемент:");
            int elem = Convert.ToInt32(System.Console.ReadLine());
            int tmp = myArray[i];
            myArray[i] = elem;
            myArray[i+K] = tmp;
        }

        return myArray;
    }



}
