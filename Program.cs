int[] array = new int[10];
void FillArray (int[] num)
{
    for(int i =0; i< num.Length; i++)
    {
        num [i] = new Random().Next(1,10);
    }
}

void PrintArray(int[] array)
{
       for(int i =0; i< array.Length; i++)
         {
           Console.Write($"{array[i]} " );
         }

    Console.WriteLine();
}