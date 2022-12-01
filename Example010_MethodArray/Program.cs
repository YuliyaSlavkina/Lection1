int[] array = { 18, 22, 35, 4, 56, 73, 22 };

int n = array.Length;
int find = 22;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}