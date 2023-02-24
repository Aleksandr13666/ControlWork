# ControlWork

> Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивамиНаписать программу, которая из имеющегося массива строк формирует массив строк, длинна которых не превышает 3 символа.

1. Создаём метод заполнения массива строками.

```C#
string[] InputString(int n)
{
string[] str = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Input a string {0}:\r\n ", i + 1);
    str[i] = Console.ReadLine();
}

return str;
}
```

2. Создаём основной метод, который будет находить строки нужной длинны и заполнять новый массив.

```C#
string[] SplString(string[] str)
{
    string[] strs2 = new string[str.Length];
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if(str[i].Length <= 3)
        {
            strs2[count] = str[i];
            count++;
        }
    }
    return strs2;
}
```

3. Создаём метод вывода массива на экран в консоль.

```C#
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1)Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
```

4. Заполняем массив с клавиатуры и выводим всё на экран в консоль.

```C#

Console.WriteLine("Input quantity of string: ");
int n  = Convert.ToInt32(Console.ReadLine());

string[] inputString = InputString(n);
PrintArray(inputString);
string[] splString = SplString(inputString);
Console.WriteLine();
PrintArray(splString);
```