using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class MyArray
    {
        private const int MIN_ELEMENT = -20;
        private const int MAX_ELEMENT = 20;
        private int[] array;
        private int min;
        private int max;
        private uint length;
        private double mediana;
        public MyArray(uint size) { 
            this.array = new int[size];
            this.max = 0;
            this.length = size;
            this.min = 0;
            this.mediana = 0;
        }

        static public int[] findCommon(MyArray arr1, MyArray arr2) {
            int maxLen = Math.Max((int)arr1.length, (int)arr2.length);
            int[] res = new int[maxLen];
            Array.Fill(res,0);
            int index = 0;
            for (int i = 0; i < maxLen;i++){
                if (arr1.length > arr2.length)
                {  
                    int[] elems = Array.FindAll(arr2.array, elem => elem == arr1.array[i]);
                    if (elems.Length>0)
                    {
                        res[index] = elems[0];
                        index++;
                    }       
                }
                else {
                    int[] elems = Array.FindAll(arr1.array, elem => elem == arr2.array[i]);
                    if (elems.Length > 0)
                    {
                        res[index] = elems[0];
                        index++;
                    };
                }
            }
            Array.Resize(ref res, index);
            return res;
        }
        static public MyArray sumTwo(MyArray arr1, MyArray arr2)
        {
            if (arr1.length != arr2.length) {
                throw new Exception("Длины суммированных массивов не равны");
            }
            MyArray arr = new(arr1.length);
            for (int i = 0; i < arr1.length; i++) {
                arr.array[i] = arr1.array[i] + arr2.array[i];
            }
            return arr;
        }
        static public MyArray multiplication(MyArray arr1, MyArray arr2) {
            if (arr1.length != arr2.length)
            {
                throw new Exception("Длины суммированных массивов не равны");
            }
            MyArray arr = new(arr1.length);
            for (int i = 0; i < arr1.length; i++)
            {
                arr.array[i] = arr1.array[i] * arr2.array[i];
            }
            return arr;
        }

        static public int[] initialization(int size)
        {
            if (size <= 0) {
                throw new Exception("Размер массива должен быть положительным!!!");
            }
            Random rnd = new Random();
            int[] newArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                newArray[i]= rnd.Next(MIN_ELEMENT,MAX_ELEMENT);
            }
            return newArray;
        }  
        public MyArray initialization()
        {
            Random rnd = new Random();
            array[0] = rnd.Next(MIN_ELEMENT, MAX_ELEMENT);
            this.max = this.array[0];
            this.min = this.array[0];
            int sum = 0;
            for (int i = 1; i < this.array.Length; i++)
            {

                this.array[i] = rnd.Next(MIN_ELEMENT, MAX_ELEMENT);
                if (this.array[i] > this.max){
                    this.max = this.array[i];
                }
                if (this.array[i] < this.min){
                    this.min = this.array[i];
                }
                sum += this.array[i];
            }
            this.mediana = sum / this.length;
            return this;
        }

        public void print()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine('\n');
        }

        public int getMax()
        {
            return this.max;
        }

        public double getMed()
        {
            return this.mediana;
        }

        public int getMin()
        {
            return this.min;
        }

        public void mySort() {
            for (int i = 0; i < this.length; i++) {
                for (int j = 0; j < this.length; j++) {
                    if (this.array[i] > this.array[j]) {
                        int tmp = this.array[i];
                        this.array[i] = this.array[j];
                        this.array[j] = tmp;
                    }
                }
            }
        
        
        }

    }
}
