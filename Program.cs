/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/


Console.WriteLine("Введите длину массива");
int a = int.Parse(Console.ReadLine());

string[] UserArray = CreateArrayByUser(a);

Console.WriteLine();

PrintArray(UserArray);

string[] array = CheckAndCreateNewArray(UserArray);

Console.WriteLine();

PrintArray(array);


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


string[] CheckAndCreateNewArray(string[] UserArray)
{
    int sum = 0;
    for (int i = 0; i < UserArray.Length; i++)
    {
        if(UserArray[i].Length <= 3)
        {
            sum++;
        }
    }

    string[] array = new string[sum];

    int j = 0;

    for (int i = 0; i < UserArray.Length; i++)
    {
        if(UserArray[i].Length <= 3)
        {
            array[j] = UserArray[i];
            j++;
        }
    }
    return array;
}

void PrintArray(string[] array){

    Console.WriteLine(string.Join(",", array));
}
