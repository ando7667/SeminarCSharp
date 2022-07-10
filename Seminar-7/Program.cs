// метод вывода 1мерного массива целых чисел в консоль
void OutputArrayConsole(int[] array)
{
    string ss = String.Empty;
    for(int i = 0; i < array.Length; i++)
    {
        ss += array[i];
        if( i < array.Length-1 ) ss += " ";           
    }
    Console.WriteLine($"Array: [ {ss} ]");
}

// метод вывода 1мерного массива вещественных чисел в консоль
void OutputDoubleArrayConsole(double[] array)
{
    string ss = String.Empty;
    for(int i = 0; i < array.Length; i++)
    {
        ss += array[i].ToString("#.##");
        if( i < array.Length-1 ) ss += " ";           
    }
    Console.WriteLine( ss );
}

//метод для создания 2мерного массива целых чисел
int[,] CreateRandomDimArray( int Row, int Col, int min, int max )
{
    int[,] newArray = new int[Row, Col];
    for(int i =0; i < Row; i++)
        for (int j = 0; j < Col; j++)
            newArray[i,j] = new Random().Next(min, max + 1);
    return newArray;
} 


//метод создания 2мерного массива вещественных чисел
double[,] CreateRandomDoubleDimArray( int Row, int Col, int min, int max )
{
    double[,] newArray = new double[Row, Col];
    for(int i = 0; i < Row; i++)
        for (int j = 0; j < Col; j++)
            newArray[i,j] = min + Math.Round( new Random().NextDouble() * ( max - min ), 1 );
    return newArray;
} 

// метод вывода 2мерного массива целых чисел в консоль
void OutputDimArrayConsole(int[,] array)
{
    string ss = String.Empty;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
             Console.Write( array[i,j] + " ");

        Console.WriteLine();
    }    

}

// метод вывода 2мерного массива вещественных чисел    
void OutputDoubleDimArrayConsole(double[,] array)
{ 
    string ss = String.Empty;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write( array[i,j] + " ");

        Console.WriteLine();
    }    
}

// получение значения элемента массива по координатам
int GetElementDimArray(int[,] array, int[] positions )
{
    return array[ positions[0] - 1, positions[1] - 1 ];
}

// метод ввода строки цифр
string InputStringNumber()
{
    Console.Write($"Введите через пробел позицию элемента в массиве ( строка колонка ) :");
    return Console.ReadLine();
}

// перевод строки позиции элемента в массив 
int[] ConvertStringToArray( string st )
{
    st = st.Replace(","," ")
            .Replace("."," ")
            .Replace("-","");;

    var data =  st.Split(" ")
            .Where(x => !string.IsNullOrWhiteSpace( x ))
            .Select( x => int.Parse(x))
            .ToArray();
    return data;
}

// проверка на наличие элемента в массиве по заданной позиции
bool CheckPositionElement( int[,] array, int [] positions )
{
    if( positions[0] < 1 || positions[0] > array.GetLength(0) ) return false;
    if( positions[1] < 1 || positions[1] > array.GetLength(1) ) return false;
    return true;
}

// среднее арифметическое элементов в каждом столбце
double[] ArithmMeanElementsInEachColumn(int[,] array)
{
    double[] middle = new double[array.GetLength(1)];

    for(int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
            middle[i] += array[j,i];

        middle[i] /= array.GetLength(0);
    }
    return middle;
}


//===================================================== 
// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.
//-----------------------------------------------------

/*
int minElement = 1;
int maxElement = 10;
Console.WriteLine("Задайте количесво строк в массиве: ");
int sizeRow = Convert.ToInt32( Console.ReadLine() );
Console.WriteLine("Задайте количесво столбцов в массиве: ");
int sizeCol = Convert.ToInt32( Console.ReadLine() );

if(sizeCol > 0 && sizeRow > 0)
{
    double[,] myArray = CreateRandomDoubleDimArray(sizeRow, sizeCol, minElement, maxElement);
    OutputDoubleDimArrayConsole(myArray);
}
else
{
    Console.WriteLine("Размеры массива заданы неверно!");
}
*/

//============================================================================
//Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
//----------------------------------------------------------------------------

/*
int sizeCol = 5;
int sizeRow = 5;
int minElement = 10;
int maxElement = 99;

string coordElement = InputStringNumber();
int[] posElement = ConvertStringToArray(coordElement);
Console.WriteLine("позиция элемента: ");
OutputArrayConsole(posElement);
int[,] myArray = CreateRandomDimArray(sizeRow, sizeCol, minElement, maxElement);
OutputDimArrayConsole(myArray);
if( CheckPositionElement( myArray, posElement ) )
{
    Console.WriteLine("В данной позиции найден элемент: " + GetElementDimArray( myArray, posElement));
} 
else
{
    Console.WriteLine("В данной позиции элемент не существует!");
}
*/

//===================================================================================
// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
//-----------------------------------------------------------------------------------

/*
int sizeCol = 6;
int sizeRow = 3;
int minElement = 1;
int maxElement = 9;

int[,] myArray = CreateRandomDimArray( sizeRow, sizeCol, minElement, maxElement );
OutputDimArrayConsole(myArray);
double[] arithmMean = ArithmMeanElementsInEachColumn(myArray); 
Console.Write("Среднее арифметическое каждого столбца: ");
OutputDoubleArrayConsole(arithmMean);
*/