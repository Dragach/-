

Console.WriteLine("Введите колличество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество cтолбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray (rows, columns, 0, 100);

Console.WriteLine("Введите строку требуемого элемента массива: ");
int wichRow = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите столбец требуемого элемента массива: ");
int wichColumn = int.Parse(Console.ReadLine()!);

int LR = array.GetLength(0);
int LC = array.GetLength(1);

if (wichRow<LR & wichColumn<LC)
{
    Console.WriteLine(array[wichRow, wichColumn]);
}
else
{
    Console.WriteLine("Такого элемента не существует");
}


//функция создание слчайного двумерного массива 
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i=0; i<m; i++){
        for(int j=0; j<n; j++){
            result[i,j] = new Random().Next(minValue,maxValue);
        }
    }
    return result;
}
