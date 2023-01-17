Console.Write("Введите количество элеметнов массива: ");    //Инициируем массив
int lengthArray = Convert.ToInt32(Console.ReadLine());
string[] array = new string[lengthArray];

FillArray(array);

string[] newArray = new string[ReadLengthNewArray(array)];  // Создаем новый массив

CreateNewArray(newArray,array);
PrintArray(newArray);


void FillArray(string[] array)                              // Вводим массив
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку: ");
        array[i] = Console.ReadLine();
    }
}

int ReadLengthNewArray(string[] array)                       // Ищем количество строк > 2 символов
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 2) count++;
    return count;
}