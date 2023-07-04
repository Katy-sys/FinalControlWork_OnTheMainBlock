// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// // Метод получения значения с консоли
// string GetRows (string message)
// {
//     System.Console.WriteLine(message);
//     string result = System.Console.ReadLine();
//     return result;
// }

// //образование нового массива
// void ReadStringToArray(string[] args)
// {

// }

// //чтение строки


// // 1. Объявление переменных
// int count = 0; // количество строк
// string[] ArrayMain = new string[count]; // массив строк
// int numberRowsInArray; // текущее количество строк в массиве
// string newRows;
// string[] ArrayNext; // дополнительный массив - сохраняет старый массив строк

// GetRows("Enter strings:");


string[] ArrayMain = { "Sunday", "Monday", "Tuersday",
      "Wednesday", "Thirsday", "Friday", "Saturday" };

// Метод форматированного вывода на консоль для массива в строку
void PrintArray(string[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    //Console.ReadKey();
    System.Console.Write($"\"{array[^1]}\"");
    System.Console.WriteLine("]");
}

PrintArray(ArrayMain);