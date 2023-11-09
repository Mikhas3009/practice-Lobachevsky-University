using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_1task_
{
    internal class MyStack<T>
    {
        public MyStack() { 
            this.size = 0;
            this.values = new T[0];
        }

        public MyStack(T[]args) {
            this.size = args.Length;
            this.values = new T[args.Length];
            for (int i = 0; i < args.Length; i++) {
                values[i] = args[i];
            }
        }

        private int size;
        private T[] values;

        public int getSize() {
            return this.size;
        }
        public void printStack() {
            foreach (T elem in this.values)
            {
                Console.WriteLine(elem);
            }
        }
        public void back() {
            Console.WriteLine(this.values[this.size - 1]);
        }

        public string clear() {
            this.size = 0;
            Array.Resize(ref this.values, this.size);
            return "OK";
        }
        public void exit()
        {
            Console.WriteLine("Bye");
            Environment.Exit(0);
        }
        public string push(T elem) {
            Array.Resize(ref this.values, this.size+1);
            size++;
            this.values[size-1] = elem;
            return "OK";
        }


        public T pop()
        {
            if (size<=0) {
                throw new Exception("Stack is Empty!!!");
            }
            T res = this.values[this.size-1];
            Array.Resize(ref this.values, this.size-1);
            this.size--;
            return res;
        }
    }
}
