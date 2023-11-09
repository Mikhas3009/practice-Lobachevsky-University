using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_task2_
{
    internal class MyQueue<T>
    {
        public MyQueue() {
            this.size = 0;
            this.values = Array.Empty<T>();
        
        }

        public MyQueue(T[] args) {
            this.size = args.Length;
            this.values = new T[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                values[i] = args[i];
            }
        }

        private int size;
        private T[] values;

        public int getSize() {
            return this.size;
        }

        public string push(T elem) {
            Array.Resize(ref this.values, this.size + 1);
            this.size++;
            for (int i = this.size - 1; i > 0; i--)
            {
                this.values[i] = this.values[i - 1];
            }
            this.values[0] = elem;
            return "OK";

        }

        public void printQue() {
            Console.WriteLine("Очередь:");
            foreach (T elem in this.values)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine("");
        }

        public T pop()
        {
            if (size <= 0) {
                throw new Exception("Queue is empty");
            }
            T elem = this.values[this.size-1];
            Array.Resize(ref this.values, size - 1);
            size--;
            return elem;
        }

        public void front() {
            if (size <= 0) {
                throw new Exception("Queue is empty");
            }
            Console.WriteLine("Первый элемент:" + this.values[0]);
        }

        public void clear() {
            this.values = Array.Empty<T>();
            this.size = 0;
            Console.WriteLine("OK");
        }

        public void exit() {
            Console.WriteLine("Bye");
            Environment.Exit(0);
        }
    }
}
