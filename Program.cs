/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/


Console.WriteLine("Введите длину массива");
int a = int.Parse(Console.ReadLine());

string[] CreateArrayByUser(int a)
{

    string[] array = new string[a];

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Console.ReadLine();
    }

    return array;
}

string[] UserArray = CreateArrayByUser(a);