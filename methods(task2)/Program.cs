// See https://aka.ms/new-console-template for more information
using methods_task2_;
int[] elements = { 1, 2, 3, 4 };
MyQueue<int> myQ = new(elements);
myQ.printQue();
Console.WriteLine(myQ.push(1010));
myQ.printQue();
Console.WriteLine(myQ.pop());
Console.WriteLine("Размер очереди:"+myQ.getSize());
myQ.printQue();
myQ.clear();
myQ.printQue();
try {
    myQ.front();   
}
catch (Exception err){
    Console.WriteLine(err.Message);
}
myQ.exit();