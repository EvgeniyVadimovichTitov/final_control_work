Console.Write("Введите длину создаваемого массива: ");
int size = int.Parse(Console.ReadLine()!);
string[] array = new string[size];

void FillArray(string[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.WriteLine("Введите элемент: ");
        massiv[i] = Console.ReadLine()!;
    }
}
int CreateSizeArrayNew(string[] massiv)
{
    int n = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i].Length < 4)
            n++;
    }
    return n;
}
void FillArrayNew(string[] massiv, string[] massivNew)
{
    int j = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i].Length < 4)
        {
            massivNew[j] = massiv[i];
            j++;
        }
    }
}

FillArray(array);

string[] arrayNew = new string[CreateSizeArrayNew(array)];

FillArrayNew(array, arrayNew);

foreach (string el in arrayNew)
    Console.Write("{0} ", el);