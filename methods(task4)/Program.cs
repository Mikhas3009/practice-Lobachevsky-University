// See https://aka.ms/new-console-template for more information
using methods_task4_;

DoubQue<int> myQue = new();

Console.WriteLine("1 - добавить в начало 2 - добавить в конец, 3 - удалить первый, 4 - удалить последний, 5 - печать, 6 - поиск элемента, 7 -удаление по значению" );
while (true) {
    string op = Console.ReadLine();
    switch (op)
    {
        case "1": {
                Console.WriteLine("Введите добавляемый элемент:");
                int elem = Convert.ToInt32(Console.ReadLine());
                myQue.addFirst(elem);
                break;
        }
        case "2":
            {
                Console.WriteLine("Введите добавляемый элемент:");
                int elem = Convert.ToInt32(Console.ReadLine());
                myQue.addLast(elem);
                break;
            }
        case "3":
            {
                try {
                    Console.WriteLine("Удаленный элемент: "+myQue.removeFirst());
                }
                catch(Exception err) {
                    Console.WriteLine(err.Message);
                }
                break;
            }
        case "4":
            {
                try
                {
                    Console.WriteLine("Удаленный элемент: " + myQue.removeLast());
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
                break;
            }
        case "5":
            {
                myQue.print();
                break;
            }
        case "6":
            {
                Console.WriteLine("Введите искомый элемент:");
                int elem = Convert.ToInt32(Console.ReadLine());
                int index = myQue.findElement(elem);
                if (index != -1) {
                    Console.WriteLine("Его позиция:" + index);
                }
                else {
                    Console.WriteLine("Элемент не найдет");
                }

                break;
            }
        case "7":
            {
                Console.WriteLine("Введите удаляемый элемент:");
                int elem = Convert.ToInt32(Console.ReadLine());
                try {
                    Console.WriteLine("Удаленный элемент"+myQue.removeByData(elem));
                } 
                catch (Exception err){
                    Console.WriteLine(err.Message);
                }
                break;
            }
        default: {
            Environment.Exit(0);
            break;
        }
    }

}
myQue.addFirst(1);
myQue.addFirst(7);
myQue.addLast(15);
myQue.addLast(122);
myQue.addFirst(9);
myQue.print();
Console.WriteLine(myQue.findElement(3));
myQue.removeFirst();
myQue.print();
myQue.removeLast();
myQue.print();
myQue.removeByData(3);
myQue.print();