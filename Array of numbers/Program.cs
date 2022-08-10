Console.WriteLine("Ведите количество элементов в массиве");
int sizeOfArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[sizeOfArray];
for (int i = 0; i < array.Length; i++)
{
    Random random = new Random();
    int value = random.Next(-100, 100);
    array[i] = value;
    Console.Write(array[i] + " ");
}
Console.WriteLine("\n" + "Нажмите любую клавишу, чтобы вывести наибольшее значение в массиве");
Console.ReadLine();
int maxValue = array[0];        
for (int i = 0; i < array.Count(); i++) 
{
    if (maxValue < array[i])    
    {
        maxValue = array[i];
    }
}
Console.WriteLine(maxValue);

Console.WriteLine("\n" + "Нажмите любую клавишу, чтобы вывести наименьшее значение в массиве");
Console.ReadLine();
int minValue = array[0];
for (int i = 0; i < array.Count(); i++)
{
    if (minValue > array[i])
    {
        minValue = array[i];
    }
}
Console.WriteLine(minValue);

Console.WriteLine("\n" + "Нажмите любую клавишу, чтобы вывести общую сумму элементов в массиве");
Console.ReadLine();
int sum = 0;
foreach (int i in array)
    {
        sum += i;
    }

Console.WriteLine(sum);

Console.WriteLine("\n" + "Нажмите любую клавишу, чтобы вывести среднее арифметическое элементов в массиве");
Console.ReadLine();
int average = sum / array.Count();
Console.WriteLine(average);

Console.ReadLine();








