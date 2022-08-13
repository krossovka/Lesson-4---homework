Console.WriteLine("Ведите количество элементов в массиве");
int sizeOfArray1 = Convert.ToInt32(Console.ReadLine());
int sizeOfArray2 = Convert.ToInt32(Console.ReadLine());

int[ , ] array = new int[sizeOfArray1, sizeOfArray2];
for (int i = 0; i < array.Length; i++)
{
    Random random = new Random();
    int value = random.Next(-100, 100);
    array[i, i] = value;
    Console.Write(array[i, i] + " ");
}