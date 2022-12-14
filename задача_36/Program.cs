//функция которая заполняет массив рандомными числами от -10 до 10
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while ( index < lenght )
    {
        collection[index] = new Random().Next ( -10, 11 );
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

int[] array = new int[5];

FillArray(array);
PrintArray(array);

int size = array.Length;
int i = 1;
int result = 0;

while ( i < size )
{
    result = array[i] + result;
    i++;
}
Console.WriteLine("Cумма всех элементов массива с нечетным индексом:");
Console.WriteLine(result);