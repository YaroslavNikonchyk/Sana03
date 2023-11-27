int n;
bool acces1 = false, acces2 = false;
Console.WriteLine("Задайте кiлькiсть дiйсних чисел массиву:");
do
{
    if (int.TryParse(Console.ReadLine(), out n) && n > 0)
    {
        acces1 = true;
        double a, b;
        Console.WriteLine("Задайте промiжок генерацiї дiйсних чисел");
        do
        {
            if (double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b) && a < b)
            {
                acces2 = true;
                Random rand = new Random();
                double[] Array = new double[n];
                double arrayMin = double.MaxValue;
                double sum = 0;
                double Max = double.MinValue;
                int maxIndex = 0;
                double abs = double.MinValue;
                double absMax = 0;
                int indexSum = 0;
                int intCount = 0;
                Console.WriteLine("Згенерований массив:");
                for (int i = 0; i < n; i++)
                {
                    Array[i] = Math.Round(a + rand.NextDouble() * (b - a), 2);
                    if (Array[i] < 0) sum += Array[i];
                    if (arrayMin > Array[i]) arrayMin = Array[i];
                    if (Max < Array[i])
                    {
                        Max = Array[i];
                        maxIndex = i;
                    }
                    if (abs < Math.Abs(Array[i]))
                    {
                        abs = Math.Abs(Array[i]);
                        absMax = Array[i];
                    }
                    if (Array[i] > 0) indexSum += i;
                    if (Array[i] == (double)Math.Round(Array[i])) intCount++;
                    Console.Write($"{Array[i]} ");
                }
                Console.WriteLine();
                Console.WriteLine($"Сума вiд'ємних елементiв массиву = {sum}");
                Console.WriteLine($"Мiнiмальний елемент массиву: {arrayMin}");
                Console.WriteLine($"Iндекс максимального елементу массиву: {maxIndex}");
                Console.WriteLine($"Максимальний за модулем елемент массиву: {absMax}");
                Console.WriteLine($"Cума iндексiв додатнiх елементiв: {indexSum}");
                Console.WriteLine($"Кiлькiсть цiлих чисел у масивi: {intCount}");
            }
            else Console.WriteLine("Задано невiрне значення!");
        } while (!acces2);
    }
    else Console.WriteLine("Задано невiрне значення!");
} while (!acces1);