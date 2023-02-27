// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Clear();


int EntNum(string text)
{
    System.Console.Write(text);
    int result = int.Parse(Console.ReadLine()!); 
    return result;
}


int[] EntArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = EntNum($"Введите {i + 1}й элемент: ");
    }
    return array;
}



void PrintArray(int[] entarray)
{
    for (int i = 0; i < entarray.Length; i++)
    {
        Console.Write($"{entarray[i]} ");
    }
}



int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}



int lenght = EntNum("Введите кол-во символов: ");
int[] array = EntArray(lenght);
PrintArray(array);
Console.WriteLine($" -> {CountPositive(array)}");




// int CheckNumber(int a, int s, int d, int f, int g, int h)
// {
//     int count = 0;
//     if (a > 0)
//     {
//         count++;
//     }
//     if (s > 0)
//     {
//         count++;
//     }
//     if (d > 0)
//     {
//         count++;
//     }
//     if (f > 0)
//     {
//         count++;
//     }
//     if (g > 0)
//     {
//         count++;
//     }
//     if (h > 0)
//     {
//         count++;
//     }
//     return count;
// }




// int ent1 = EntNum("ВВедите сторону 1: ");
// int ent2 = EntNum("ВВедите сторону 2: ");
// int ent3 = EntNum("ВВедите сторону 3: ");
// int ent4 = EntNum("ВВедите сторону 4: ");
// int ent5 = EntNum("ВВедите сторону 5: ");
// int ent6 = EntNum("ВВедите сторону 6: ");

// int res = CheckNumber(ent1, ent2, ent3, ent4, ent5, ent6);
// Console.WriteLine(res);