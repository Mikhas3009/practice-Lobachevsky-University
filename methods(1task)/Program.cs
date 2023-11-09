// See https://aka.ms/new-console-template for more information
using methods_1task_;

Console.WriteLine("Hello, World!");
int[] array = { 1, 2, 3, 4, 5 };
MyStack<int> stack = new(array);
Console.WriteLine(stack.pop());
Console.WriteLine(stack.push(1212));
stack.back();
Console.WriteLine("Размер стека:"+stack.getSize());
stack.clear();
stack.printStack();
Console.WriteLine("Размер стека:" + stack.getSize());
try {
    stack.pop();
}
catch (Exception err){
    Console.WriteLine(err.Message);
}
stack.exit();
