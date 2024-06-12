
string[] arrayStart = new string[] {"hello", "2", "world", ":-)"};
// string[] arrayStart = new string[] {"1234", "1567", "-2", "computer science"};
// string[] arrayStart = new string[] {"Russia", "Denmark", "Kazan"};

string[] arrayFinal = new string[arrayStart.Length];

void ChangeArray(string[] arrayStart, string[] arrayFinal)
{
    int count = 0;
    for (int i = 0; i < arrayStart.Length; i++)
        if(arrayStart[i].Length <= 3)
        {
            arrayFinal[count] = arrayStart[i];
            count++;
        }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

ChangeArray(arrayStart, arrayFinal);
PrintArray(arrayFinal);