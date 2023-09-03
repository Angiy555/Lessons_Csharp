int [] array = {11,25,34,4,25,67,78,8};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n) 
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
}
