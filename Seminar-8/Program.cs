//метод для создания 2мерного массива целых чисел
int[,] CreateRandomDimArray( int Row, int Col, int min, int max )
{
    int[,] newArray = new int[Row, Col];
    for(int i =0; i < Row; i++)
        for (int j = 0; j < Col; j++)
            newArray[i,j] = new Random().Next(min, max + 1);
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

// метод упорядочит по возрастанию элементы каждой строки двумерного массива
int[,] SortStringInDimArray(int[,] array)
{
    
    int temp;
    for(int i = 0; i < array.GetLength(0); i++) // для строк
    {
        
        for (int n = 0; n < array.GetLength(1); n++) // для элементов в строке
        {
            int minindex = n;
             for (int j = n; j < array.GetLength(1); j++ )  // для оставшихся неотсортированных элементов
                if(array[i,minindex] > array[i,j] ) minindex = j;

            temp = array[i,n];
            array[i,n] = array[i,minindex];
            array[i,minindex] = temp;
        }
    }

    return array;
}

// метод находит строку с наименьшей суммой элементов в двумерном массиве
int FindMinSumElementStringInDimArray(int[,] array)
{
    int minstrindex = 0;
    int[] sumstr = new int[array.GetLength(0)]; 
    for( int i = 0; i < array.GetLength(0); i++ )
    {
        for ( int j = 0; j < array.GetLength(1); j++ )
            sumstr[i] += array[i,j];

        if ( sumstr[i] < sumstr[minstrindex] ) minstrindex = i;
    }
    return minstrindex + 1;
}

// метод создает спиральный массив размером sizex х sizey начиная с числа num
int[,] CreateSpiralArray(int sizex, int sizey, int num)
{
    int i = 0;
    int j = 0;
    int iMin = 0;
    int jMin = 0;
    int iMax = sizex-1;
    int jMax = sizey-1;

    int[,] array = new int[sizex, sizey];
    
    for(int n = 0; n < sizex*sizey; n++)
    {
        array[i,j] = num;
        
        if(i == iMin && j < jMax )  j++;      // идем вправо, если текущая сторона верхняя и не достигли правой стороны
        else if( j == jMax && i < iMax ) i++; // идем вниз, если текущая сторона правая и не достигли нижнюю сторону               
        else if( i == iMax && j > jMin ) j--; // идем влево, если текщая сторона нижняя и не достигли левой стороны
        else i--;                             // иначе идем вверх
        
        // Изменяем отступы краев прямоугольника (переключаемся на следующий внутренний прямоугольник),
        // если мы на следующей строке и в 1м столбце и если еще есть столбцы
        if( i == iMin + 1 && j == jMin && jMin != jMax) 
        {
            iMin++;
            iMax--;
            jMin++;
            jMax--;
        }
        num++;
    }

    return array;
}



//=========================================================================
// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
//  1 4 7 2      1 2 4 7
//  5 9 2 3  =>  2 3 5 9
//  8 4 2 4      2 4 4 8
//--------------------------------------------------------------------------

/*
int[,] myArray = CreateRandomDimArray(5, 8, 10, 99 );
OutputDimArrayConsole(myArray);
Console.WriteLine("После: ");
myArray = SortStringInDimArray(myArray);
OutputDimArrayConsole(myArray);
*/


//=========================================================================
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с
// наименьшей суммой элементов: 1 строка
//--------------------------------------------------------------------------

/*
int[,] myArray = CreateRandomDimArray(5, 5, 0, 1 );
OutputDimArrayConsole(myArray);
Console.WriteLine("Строка с наименьшей суммой элементов: " + FindMinSumElementStringInDimArray(myArray) );
*/


//=========================================================================
// Задача 62. Заполните спирально массив 4 на 4.
//  1  2  3  4
//  12 13 14 5
//  11 16 15 6
//  10  9  8 7
//--------------------------------------------------------------------------

/*
int sizeRow = 4;
int sizeCol = 4;
int startnumber = 10; 

int[,] myArray = CreateSpiralArray(sizeRow,sizeCol,startnumber);
OutputDimArrayConsole(myArray);
*/