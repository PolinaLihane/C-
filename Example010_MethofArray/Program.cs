using static System.Console;
Clear();
int[] array = {1,2,3,4,5,14,4,9};

int n = array.Length;
int find = 4;

int index =0;

while (index < n)
{
    if (array[index] == find)
    {
        WriteLine(index);
        break;
    }
    index++;
}