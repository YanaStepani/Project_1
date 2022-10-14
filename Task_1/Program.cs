/*  Написать программу, которая из имеющегося массива строк 
    сформирует массив из строк, длина которых меньше либо равна 3 символам. */


// Задание входящего массива:
string[] array1 = new string[] {"156", "Hello", "12", "009", "1585"};

// Результирующий массив:
string[] array2 = GetArrayLessThree (array1);

// Вызов метода печати результирующего массива:
PrintArray(array2);

// Метод заполнения второго массива строками из первого массива длинной <= 3: 
string[] GetArrayLessThree (string[] array)
{
    string[] resultArray = new string[array.Length];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[count] = array[i];
            count++;
        }
    }
    return resultArray;
}

// Метод вывода массива строк на консоль:
void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
            Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}


