int [] array = { 14 , 2 , 31 , 4, 58 , 15 , 16 , 27 , 58 };

int n = array.Length;
int find = 58;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}