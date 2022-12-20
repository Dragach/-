//функция получения массива от пользователя не считывая пустые элементы
int[] GetArray (string sArray)
{
    string[] i = sArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[i.Length];
    for (int count = 0; count < result.Length; count++)
    {
        result[count] = int.Parse(i[count]);
    }
    return result;
}
//функция подсчета положительных элементов массива
int Elements(int[] a)
{
    int c = 0;
    foreach (var item in a)
    {
        if (item>0) c++;
    }
    return c;
}

Console.Write("Введите числа через пробел:");

int[] array = GetArray(Console.ReadLine()!);
Console.WriteLine($"Колличество чисел>0: {Elements(array)}");


