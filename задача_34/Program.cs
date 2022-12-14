void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while ( index < lenght )
    {
        collection[index] = new Random().Next ( 100, 1000 );
        index++;
    }
}
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


int[] array = new int[10];

FillArray( array );
PrintArray( array );

int size = array.Length;
int i = 0;
int amount = 0;
while ( i < size )
{
    if ( array[i] % 2 == 0 ) amount++; 
    i++;
}
Console.WriteLine("Колличество четных чисел:");
Console.WriteLine(amount);
