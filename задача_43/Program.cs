//функция которая заполняет массив рандомными числами от 1 до 40
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while ( index < lenght )
    {
        collection[index] = new Random().Next ( 0, 101 );
        index++;
    }
}

// функция которая выводит все элементы массива 
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

//Создается массив случайного размера от 6-ти до 50-ти
int b = new Random().Next ( 6, 51 );
int[] array = new int[b];

//Исходный массив заполняется случайными числами от 0 до 100 и выводится
FillArray(array);
Console.WriteLine("Массив до сортировки: ");
PrintArray(array);

Console.WriteLine(" ");

//Исходный массив сортируется по возрастанию и выводится
Array.Sort(array);
Console.WriteLine("Массив после сортировки: ");
PrintArray(array);