// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива");

// int[] arr = new int[Convert.ToInt32(Console.ReadLine())];

// int count = 0;

// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = new Random().Next(100, 1000);

//     if (arr[i] % 2 == 0)
//     {
//         count = count + 1;
//     }
// }

// Console.WriteLine(String.Join(", ",arr) 
// +"\nКоличество четных чисел в массиве равно: "+count);




// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");

int[] arr = new int[Convert.ToInt32(Console.ReadLine())];

int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100, 1000);

    if (i % 2 != 0)
    {
        sum = sum + arr[i];
    }
}

Console.WriteLine(String.Join(", ",arr) 
+"\nСумма элементов с нечетными идексами равна: "+sum);