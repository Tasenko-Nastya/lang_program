int[] array = {11, 21, 31, 146, 25, 61, 17, 38, }; 
int n = array.Length;
int find = 61;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
