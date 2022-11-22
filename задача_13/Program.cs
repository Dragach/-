Console.WriteLine("Эта прорамма генерирует случайное число в диапазоне от 1 до 100 000 включительно и выводит третью цифру заданного числа ");

int number = new Random().Next( 1, 100001 );
string strNumbers = number.ToString();
Console.WriteLine( strNumbers );

if ( strNumbers.Length < 3 )
{
    Console.WriteLine("3-го числа нет");
}
else
{
   Console.WriteLine("Третья цифрв заданного чилса:");
    Console.WriteLine(strNumbers[2]);
}