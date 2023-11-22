using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace classes_3task_
{
    internal class MyArray<T>
    {
        public MyArray(UInt32 size) { 
            this.length = size;
            this.data = new();
        }


        public UInt32 length;
        private Dictionary<UInt32, T> data;

        public T this[UInt32 i]
        {
            get { return this.data[i]; }
            set { this.data[i] = value; }
        }
        public static void InputData(ref MyArray<T> array, T value)
        {
            array.data[array.length] = value;
            array.length++;
        }

        public static void InputDataRandom(ref MyArray<int> array) {
            Random random = new Random();
            for (uint i = 0; i < array.length; i++) {
                array.data.Add(i,(random.Next(0,10000)));
            }
        }

        public static void print(ref MyArray<T> array, UInt32 start, UInt32 end) {
            for (var i = start; i < end; i++) {
                Console.WriteLine(i+" Элемент: " + array.data[i]);
            }
        }

        public List<T> findValue(T value) {
            if (!this.data.ContainsValue(value)) {
                return new List<T>();
            }
            List<T> indexes = new();
            for (uint i = 0; i < this.length; i++) {
                if (this.data[i].Equals(value)) {
                    indexes.Add(this.data[i]);
                }
            }
            return indexes;
        }

        public T removeValue(T value) {
            if (!this.data.ContainsValue(value))
            {
                throw new Exception("Deleted elem not found!");
            }
            var values = new List<KeyValuePair<uint, T>>();
            for (uint i = 0;i< this.length;i++)
            {
                if (this.data[i].Equals(value))
                {
                    this.data.Remove(i);
                    this.length--;
                }
                
            }
            uint index = 0;
            foreach (var item in this.data)
            {
                values.Add(new KeyValuePair<uint, T>(index,item.Value));
                index++;
            }
            this.data = new Dictionary<uint, T>(values);
            return value;
        }

        public static int findMax(ref MyArray<int> arr) {
            var max = arr.data[0];
            foreach (var item in arr.data)
            {
                if (item.Value > max) { 
                    max = item.Value;
                }
            }
            return max;
        }

        public static MyArray<int> Add(MyArray<int>arr1, MyArray<int> arr2) {
            if (arr1.length != arr2.length) {
                throw new Exception("Массивы разной длины!!!");
            }
            var newArr = new MyArray<int>(arr1.length);
            for (uint i = 0; i < newArr.length; i++) {
                newArr.data.Add(i,arr1.data[i] + arr2.data[i]);
            }
            return newArr;
        }
        public static void Sort(ref MyArray<int>array) {
            for (uint i = 0; i < array.length; i++) {
                for (uint j = 0; j < array.length; j++) {
                    if (array.data[i] < array.data[j]) {
                        var tmp = array.data[i];
                        array.data[i] = array.data[j];
                        array.data[j] = tmp;
                    }
                }
            }
        }
    }
}
