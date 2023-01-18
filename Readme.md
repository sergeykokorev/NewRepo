## **Тело программы** ##

Console.Write("Введите количество элеметнов массива: ");    
int lengthArray = Convert.ToInt32(Console.ReadLine());
string[] array = new string[lengthArray];

string[] newArray = new string[ReadLengthNewArray(array)];          -**Создаем новый массив"**


CreateNewArray(newArray,array);   -**Создание нового массива и вывод результата на экран**
PrintArray(newArray);


## **Вводим функции**   ##


**Вводим вручную элементы массива, функция FillArray**
  

    void FillArray(string[] array)                              
    {  
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку: ");
        array[i] = Console.ReadLine();
    }
    }

**Ищем количество элементов больше 2 символов и ищем размерность нового массива, функция ReadLengthNewArray**

    int ReadLengthNewArray(string[] array)                    
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 2) count++;
    return count;
    }
**Заносим элементы в новый массив, функция CreateNewArray**

    void CreateNewArray(string[] newArray, string[] array)      
    {
        int numberPosition = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 2)
            {
                newArray[numberPosition] = array[i];
                numberPosition++;
            }
        }
    }

**Заносим элементы в новый массив, функция PrintArray**

    void PrintArray(string[] newArray)                           
        for (int i = 0; i < newArray.Length; i++)
        Console.Write($"({newArray[i]}) ");
    }

    