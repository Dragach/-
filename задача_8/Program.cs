Console.WriteLine("Эта программа показывает все четные числа до N.");
Console.WriteLine("Введите целое число N:");

string? N = Console.ReadLine ( );

int a = Convert.ToInt32( N );

Console.Clear();

if ( a % 2 ==0 )
{
    Console.WriteLine ( a );
    int q = a/2;
    q = q - 1;
    while (q>0)
    {
        a = a - 2;
        Console.WriteLine ( a );
        q = q - 1;
    }    
}
else
{
a = a-1;
Console.WriteLine ( a );
    int i = a/2;
    i = i - 1;
    while (i>0)
    {
        a = a - 2;
        Console.WriteLine ( a );
        i = i - 1;
    }    
}



