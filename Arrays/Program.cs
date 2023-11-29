using Arrays;

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
                double[] array = arrays.GenerateArray(n,a,b);
                double negativeSum = arrays.SumOfNegativeElements(array);
                double arrayMin = arrays.ArrayMinElement(array);
                double indexMax = arrays.MaxElementIndex(array);
                double absMax = arrays.AbsMaxElement(array);
                double integersSum = arrays.IndexSumOfPositiveElements(array);
                double integersCount = arrays.CountOfIntegers(array);
                Console.WriteLine($"Массив псевдозгенерованих чисел:");
                for (int i = 0; i < array.Length; i++)
                    Console.Write($"{array[i]} ");
                Console.WriteLine();
                Console.WriteLine($"Сума вiд'ємних елементiв массиву = {negativeSum}");
                Console.WriteLine($"Мiнiмальний елемент массиву: {arrayMin}");
                Console.WriteLine($"Iндекс максимального елементу массиву: {indexMax}");
                Console.WriteLine($"Максимальний за модулем елемент массиву: {absMax}");
                Console.WriteLine($"Cума iндексiв додатнiх елементiв: {integersSum}");
                Console.WriteLine($"Кiлькiсть цiлих чисел у масивi: {integersCount}");
            }
            else Console.WriteLine("Задано невiрне значення!");
        } while (!acces2);
    }
    else Console.WriteLine("Задано невiрне значення!");
} while (!acces1);