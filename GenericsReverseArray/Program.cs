// See https://aka.ms/new-console-template for more information

static void Reverse<T>(T[] inputArray)
{
    for (int i = inputArray.Length - 1; i >= 0; i--)
    {
        Console.WriteLine($"{inputArray[i]} ");
    }
}

string[] names = { "Gideon", "Dozie", "Victory" };
int[] numbers = { 1, 2, 3, 4, 5 };


Reverse(names);
Reverse(numbers);

Console.ReadLine();
