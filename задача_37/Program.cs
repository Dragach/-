//функция которая заполняет массив рандомными числами от 1 до 10
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while ( index < lenght )
    {
        collection[index] = new Random().Next ( 1, 11 );
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
//функция деления с округлением вверх
int divup(int x, int y)
{
    return (x + y - 1 ) / y;
}
int[] array = new int[10];

int a = divup (array.Length, 2);

int[] rarray = new int[a];

FillArray(array);
Console.WriteLine("Исходный массив");
PrintArray(array);

int size = array.Length-1;
int c = rarray.Length;
int i = 0;

while (i<c)
{
    if(i<size)
    {
        rarray[i]=array[i]*array[size];
        
    }
    else
    {
        rarray[i]=array[i];
    }
    i++;
    size = size-1;
}
Console.WriteLine("Массив с результатом");
PrintArray(rarray);



