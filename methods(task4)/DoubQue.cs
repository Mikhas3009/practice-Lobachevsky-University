using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_task4_
{
    public class DoublyNode<T>
    {
        public DoublyNode(T data)
        {
            this.Data = data;
        }
        public T Data { get; set; }
        public DoublyNode<T> Previous { get; set; }
        public DoublyNode<T> Next { get; set; }
    }
    public class DoubQue<T>
    {
        DoublyNode<T> head;
        DoublyNode<T> tail;
        int size;

        public DoubQue(T[] values) {
            foreach (T item in values)
            {
                this.addFirst(item);
            }
        }
        public DoubQue()
        {
            this.size = 0;
        }

        public DoubQue(T elem) {
            this.size++;
            this.head = new DoublyNode<T>(elem);
            this.tail = head;
        }

        public void addFirst(T data)
        {
            DoublyNode<T> newNode = new (data);
            DoublyNode<T> temp = this.head;
            newNode.Next = temp;
            this.head = newNode;
            if (size == 0)
            {
                this.tail = this.head;
            }
            else {
                temp.Previous = newNode;
            }
            this.size++;
        }
        public void addLast(T data)
        {
            DoublyNode<T> newNode = new(data);
            if (this.size == 0)
            {
                this.head = newNode;
                this.tail = head;
            }
            else
            {
                this.tail.Next = newNode;
                newNode.Previous = this.tail;
            }
            this.size++;
            this.tail = newNode;
        }
        public T removeFirst()
        {
            if (this.size == 0) {
                throw new Exception("DeQue is empty!!!");
            }
            T result = this.head.Data;
            if (this.size == 1)
            {
                this.head = this.tail = null;
            }
            else
            {
                this.head = this.head.Next;
                this.head.Previous = null;
            }
            this.size--;
            return result;
        }
        public T removeLast()
        {
            if (size == 0)
            {
                throw new Exception("DeQue is empty!!!");
            }
            T result = this.tail.Data;
            if (size == 1)
            {
                this.head = this.tail = null;
            }
            else
            {
                this.tail = tail.Previous;
                tail.Next = null;
            }
            this.size--;
            return result;
        }

        public int findElement(T data)
        {
            DoublyNode<T> current = this.head;
            int index = 0;
            while (current != null)
            {
                if (current.Data.Equals(data)) 
                {
                    return index;
                };
                current = current.Next;
                index++;
            }
            return -1;
        }

        public T removeByData(T data)
        {
            DoublyNode<T> current = this.head;
            while (current != null) {
                if (current.Data.Equals(data))
                {
                    if (current.Next == null) {
                        T deleted = removeLast();
                        return deleted;
                    }
                    if (current == head)
                    {
                        T deleted = removeFirst();
                        return deleted;
                    }
                    else {
                        current.Previous.Next = current.Next;
                        current.Next.Previous = current.Previous;
                        this.size--;
                        return current.Data;
                    }
                }
                current = current.Next;
            }
            throw new Exception("Element doesn't exist");
        }

        public void print()
        {
            if (this.size == 0) {
                Console.WriteLine("Queue is empty!");           
            }
            DoublyNode<T> current = this.head;
            while (current != null) {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }

}
