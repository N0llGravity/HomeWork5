/*//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] CreatingArray(int size)
{
   int[] array = new int[size];

        for(int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(100, 1000);
        }
        return array;
}

int EvenNumbersCounter(int[] array)
{
    int count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] % 2 == 0)
            count++;
    
        }  
        return count;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}.");
}


Console.Write("input an array size ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreatingArray(size);

ShowArray(array);                                                                               // для проверки массива 

Console.WriteLine($"Count of even number is {EvenNumbersCounter(array)}");
*/

/*//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//(В качестве позиции будет выбрана точка зрения пользователя т.е. первое значение в массиве под индексом 0 будет нечетным, а под индеком 1 - четным)
int[] CreatingArray(int size)
{
   int[] array = new int[size];

        for(int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(-100, 101);    // диапозон возьмем [-100; 100] чисел для удобства проверки
        }
        return array;
}


void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}.");
}

int SumOfNotEvenPositions(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0)
        sum += array[i];
    }
    return sum;
}


Console.Write("input an array size ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreatingArray(size);
int sum = SumOfNotEvenPositions(array);

ShowArray(array);                                                                               // для проверки массива 
Console.WriteLine($"Sum of not even positions is {sum}");
*/
