Console.WriteLine ("Эта программа находит большее число из двух.");
Console.WriteLine ("Введите первое число:");
string? A = Console.ReadLine ( );
Console.WriteLine ("Введите второе число:");
string? B = Console.ReadLine ( );

int intValue1 = Convert.ToInt32 ( A );
int intValue2 = Convert.ToInt32 ( B );

int max = intValue1;

if ( max < intValue2 )
{
    max = intValue2;
    
    Console.Write ("Ответ:");
    Console.WriteLine ( max );
}
else

Console.WriteLine ("Ответ:");
Console.WriteLine (max);
