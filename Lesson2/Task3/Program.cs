// int n = 10;
int[] array = { 2,6,98,12,45,3,8,25,67,15};
int i = 0;
while (i < array.Length)
{
    if(array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}
