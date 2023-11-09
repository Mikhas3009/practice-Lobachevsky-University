using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_classes_
{
    class MethodsArr
    {
        private int[,] arr;
        public MethodsArr(ref int[,]arr) {
            this.arr = arr;
        }

        public int getMin(int indexStr)
        {
            if (this.arr.Length <= 0) {
                throw new Exception("Массив не заполнен!!!");
            }
            int numOfStr = this.arr.GetLength(0);
            if (numOfStr < indexStr) {
                throw new Exception("Выход за границу массива");
            }
            int min = this.arr[0, 0];
            for (int i = 0; i < this.arr.GetLength(1); i++) {
                if (min > this.arr[indexStr,i])
                {
                    min = this.arr[indexStr, i];
                }
            }
            return min;
        }

        public int getMax(int indexStr) {
            if (this.arr.Length <= 0)
            {
                throw new Exception("Массив не заполнен!!!");
            }
            int numOfStr = this.arr.GetLength(0);
            if (numOfStr < indexStr)
            {
                throw new Exception("Выход за границу массива");
            }
            int max = this.arr[0, 0];
            for (int i = 0; i < this.arr.GetLength(1); i++)
            {
                if (max < this.arr[indexStr, i])
                {
                    max = this.arr[indexStr, i];
                }
            }
            return max;
        }

        public int getSumStr(int indexStr)
        {
            if (this.arr.Length <= 0)
            {
                throw new Exception("Массив не заполнен!!!");
            }
            int numOfStr = this.arr.GetLength(0);
            if (numOfStr < indexStr)
            {
                throw new Exception("Выход за границу массива");
            }
            int sum = 0;
            for (int i = 0; i < this.arr.GetLength(1); i++)
            {
                sum += this.arr[indexStr, i];
            }
            return sum;
        }




    }
}
