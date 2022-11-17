Console.WriteLine("Эта прорамма находит максимальное из трех чисел.");
Console.WriteLine("Введите 3 целых числа:");

string? a = Console.ReadLine();
string? b = Console.ReadLine();
string? c = Console.ReadLine();


int intValue1 = Convert.ToInt32(a);
int intValue2 = Convert.ToInt32(b);
int intValue3 = Convert.ToInt32(c);

int max = intValue1;

if ( intValue2 > max ) max = intValue2;
if ( intValue3 > max ) max = intValue3;

Console.WriteLine("Cамое большое число из списка:");
Console.WriteLine(max);
