// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Stack<char> stack = new();
string imput = Console.ReadLine();
int resultPosition = 0;
bool isCorrect = true;
for (int i = 0; i < imput.Length; i++) {
    switch (imput[i])
    {
        case '(':
            {
                stack.Push(imput[i]);
                break;
            }
        case ')':
            {
                try {
                    stack.Pop();
                } 
                catch {
                    resultPosition = i;
                    isCorrect = false;
                }
                break;
            }
        default: 
            {
                continue;
            }
    }
}
if (stack.Count == 0&&isCorrect) {
    Console.WriteLine("Скобки расставлены правильно!");
}
if (!isCorrect) {
    Console.WriteLine("Закрывающая скобка на " + (resultPosition+1)+" позиции");
}
if (stack.Count > 0) {
    Console.WriteLine("Число лишних открывающих скобок: " + stack.Count());
}
