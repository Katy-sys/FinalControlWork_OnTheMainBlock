// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// Метод форматированного вывода на консоль для массива в строку
void PrintArray(string[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    System.Console.Write($"\"{array[^1]}\"");
    System.Console.WriteLine("]");
}

// Метод создает массив со строками начального массива, длина которых
// меньше указанного количества символов.
string[] ArrayRes(string[] array, int m)
{
    int count = 0;
    string[] arrayRes = new string[count];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= m)
        {
            count++;
            string[] arrayNew = new string[count];
            
            // скопировать старый массив в новый
            for (int k = 0; k < arrayNew.Length - 1; k++)
            {
                arrayNew[k] = arrayRes[k];
            }
            // добавить последнюю введенную строку в новый массив
            arrayNew[count - 1] = array[i];
            arrayRes = arrayNew;
        }
    }
    return arrayRes;
}

// Основная программа 
string[] arrayMain = { "1234", "Mo", "T", "", "Thirsday", "_Fr", "Sa", "-2" };
int m = 3;
PrintArray(arrayMain);
PrintArray(ArrayRes(arrayMain, m));


