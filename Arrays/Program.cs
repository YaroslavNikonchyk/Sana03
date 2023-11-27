int n;
Console.WriteLine("Задайте кiлькiсть дiйсних чисел массиву:");
if (int.TryParse(Console.ReadLine(), out n))
{
    double sum = 0;
       Random rand = new Random();
    double[] Array = new double[n];
    double arrayMin = Array[0];
    Console.WriteLine("Згенерований массив:");
    for (int i = 0; i < n; i++)
    {
        Array[i] = rand.NextDouble()*10-5;
        Array[i] = Math.Round(Array[i], 2);
        if (Array[i] < 0) sum += Array[i];
        if (arrayMin > Array[i]) arrayMin= Array[i];
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine();
    Console.WriteLine($"Сума вiд'ємних елементiв массиву = {sum}");
    Console.WriteLine($"Мінімальний елемент массиву = {arrayMin}");
}