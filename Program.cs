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