// Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. 
//Первоначальный массив нужно ввести либо с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении нужно пользоваться именно массивами, не коллекциями.


// Задаём массив из пяти строк с клавиатуры
string phrase1 = ReadString("Input first string: ");
string phrase2 = ReadString("Input second string: ");
string phrase3 = ReadString("Input third string: ");
string phrase4 = ReadString("Input fourth string: ");
string phrase5 = ReadString("Input fifth string: ");

string[] Array = {phrase1, phrase2, phrase3, phrase4, phrase5};

// вводим счётчик от i до величины массива
int count = 0;
int j = 0;

// создаём новый массив из строк длиной <= 3
for (int i = 0; i < Array.Length; i++)
{
    if(Array[i].Length <= 3) count++;
}

string[] Result = new string[count];

for (int i = 0; i < Array.Length; i++)
{
    if(Array[i].Length <= 3)
    {
        Result[j]=Array[i];
        j++;
    }
}

//печатаем введённый массив
PrintArray(Array);
Console.WriteLine();
PrintArray(Result);

string ReadString(string message)
{
    Console.WriteLine(message);
    return Convert.ToString(Console.ReadLine());
}

//печатаем новый массив, соответствующий требованиям задачи
void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
}
