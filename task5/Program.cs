﻿using System;

class MatrixMultiplication
{
    static void Main()
    {
        const int ARR_SIZE = 1000;
        int[,] matrix1 = new int[ARR_SIZE, ARR_SIZE];
        int[,] matrix2 = new int[ARR_SIZE, ARR_SIZE];
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);
        if (cols1 != rows2)
        {
            return;
        }

        int[,] resultMatrix = new int[rows1, cols2];
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }

        Console.WriteLine("Результирующая матрица:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
