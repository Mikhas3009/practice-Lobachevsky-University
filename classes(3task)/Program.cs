// See https://aka.ms/new-console-template for more information
using classes_3task_;

MyArray<int> myArray = new(10);
MyArray<int>.InputDataRandom(ref myArray);

Console.WriteLine("1 - сложить два, 2 - добавить в конец, 3 - удалить по значению, 4  - найти по значению, 5 - печать, 6 - поиск макс элемента, 7 - сортировка");
while (true)
{
    string op = Console.ReadLine();
    switch (op)
    {
        case "1":
            {
                Console.WriteLine("Введите добавляемый элемент:");
                int elem = Convert.ToInt32(Console.ReadLine());
                var newArr = MyArray<int>.Add(myArray, myArray);
                MyArray<int>.print(ref newArr, 0,10);
                break;
            }
        case "2":
            {
                Console.WriteLine("Введите добавляемый элемент:");
                int elem = Convert.ToInt32(Console.ReadLine());
                MyArray<int>.InputData(ref myArray, elem);
                break;
            }
        case "3":
            {
                Console.WriteLine("Введите удаляемый элемент:");
                int elem = Convert.ToInt32(Console.ReadLine());
                try
                {
                    Console.WriteLine("Удаленный элемент" + myArray.removeValue(elem));
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
                break;
            }
        case "4":
            {
                Console.WriteLine("Введите искомый элемент:");
                int elem = Convert.ToInt32(Console.ReadLine());
                var elements = myArray.findValue(elem);
                Console.WriteLine(elements);

                break;
            }
        case "5":
            {
                MyArray<int>.print(ref myArray,0,myArray.length);
                break;
            }
        case "6":
            {
                int index = MyArray<int>.findMax(ref myArray);
                Console.WriteLine(index);
                break;
            }
        case "7":
            {
                MyArray<int>.Sort(ref myArray);
                break;
            }
        default:
            {
                Environment.Exit(0);
                break;
            }
    }

}