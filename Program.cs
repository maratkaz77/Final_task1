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

void SelectArr (int[] array)
{
    for ( int i = 0; i < array.Length; i++ ) 
    {
        if(array[i] % 2 == 0)
    Console.Write($"{array[i]} " );
    }
}

FillArray(array);
PrintArray(array);
SelectArr(array);