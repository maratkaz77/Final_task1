int[] array = new int[10];
void FillArray (int[] num)
{
    for(int i =0; i< num.Length; i++)
    {
        num [i] = new Random().Next(1,10);
    }
}
