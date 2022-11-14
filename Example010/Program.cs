int[] array = {5,54,5487,2,67,5,13};

int n = array.Length;
int find = 67;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}