
int rows = 5;

int columns = 5;
int[,] array = GetArray (rows, columns, 1, 10);
PrintArray(array);

int Frow = 0;
int Srow = 0;
int Trow = 0;
int ForethRow = 0;
int FivethRow = 0;
int i = 0;

for(int j=0;j<5;j++){
    Frow = Frow+array[i,j];
}

i++;
for(int j=0;j<5;j++){
    Srow = Srow+array[i,j];
}

i++;
for(int j=0;j<5;j++){
    Trow = Trow+array[i,j];
}

i++;
for(int j=0;j<5;j++){
    ForethRow = ForethRow+array[i,j];
}
i++;
for(int j=0;j<5;j++){
    FivethRow = FivethRow+array[i,j];
}
double avFrow = Frow/array.GetLength(0);
double avSrow = Srow/array.GetLength(0);
double avTrow = Trow/array.GetLength(0);
double avForethRow = ForethRow/array.GetLength(0);
double avFivethRow = FivethRow/array.GetLength(0);
Console.WriteLine("средние арифметическое по каждому столбу: ");
Console.WriteLine(avFrow);
Console.WriteLine(avSrow);
Console.WriteLine(avTrow);
Console.WriteLine(avForethRow);
Console.WriteLine(avFivethRow);


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
//функция вывода массива
void PrintArray(int[,]array){
    for(int i=0;i<array.GetLength(0); i++){
        for(int j=0;j<array.GetLength(1);j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}