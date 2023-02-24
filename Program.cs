// Написать программу которая из массива строк формирует новый массива
// для строк которого меньше или равна 3 символа.


Console.WriteLine("Input quantity of string: ");
int n  = Convert.ToInt32(Console.ReadLine());


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