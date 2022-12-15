// функция которая печатает массив
void PrintArray( int[] col )
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {   
        Console.WriteLine(col[position]);
        position++;
    }
}

//задаем массив целых чисел от -10 до 10
int[] array = new int[] {-10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

//находим разницу между максимальным и минимальным элементом массива
int dif = array.Length - 1;

//Выводим массив 
PrintArray(array);
Console.WriteLine(" ");

//Выводим наш ответ 
Console.WriteLine(dif);
