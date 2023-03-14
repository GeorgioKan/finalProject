int ElementsCounter(string[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}

void StringCreator(string[] array1, string[] array2)
{
    int i = 0;
    for (int j = 0; j < array1.Length; j++)
    {
        if (array1[j].Length <= 3)
        {
            array2[i] = array1[j];
            i++;
        }
    }
}

string[] mass = { "1234", "1567", "-2", "computer science", ":-)" };
int numb = ElementsCounter(mass);
string[] newMass = new string[numb];
StringCreator(mass, newMass);
Console.WriteLine("[" + string.Join(" , ", newMass) + "]");