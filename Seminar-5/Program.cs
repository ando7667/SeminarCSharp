//===============================================================================
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
//-------------------------------------------------------------------------------

//метод для создания массива
int[] CreateRandomArray( int size, int min, int max ) {
    int[] newArray = new int[size];
    for(int i =0; i < size; i++){
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
} 

//метод подсчет четных эелементов массива
int CountEvenNumberInArray( int[] array ) {
    int count = 0;
    for( int i = 0; i < array.Length; i++ ){
        if ( array[i] % 2 == 0 ) count++;
    }
    return count;
}

/*
int[] myArray = CreateRandomArray(10,100,999);
Console.WriteLine("The number of even numbers in the array: " + CountEvenNumberInArray(myArray) );
*/

//===============================================================================
// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19 ; [-4, -6, 89, 6] -> 0
//-------------------------------------------------------------------------------

//метод подсчета суммы элементов, стоящих в нечетных позициях массива
int SumNumberOnOddPositionInArray( int[] array ) {
    int summ = 0;
    for( int i = 1; i < array.Length; i++ ){
        if ( i % 2 > 0 ) summ += array[i];
    }
    return summ;
}

/*
int[] myArray = CreateRandomArray(10,1,10);
Console.WriteLine("The sum of the elements in the odd positions of the array: " + SumNumberOnOddPositionInArray(myArray) );
*/


//===============================================================================
// Задача 38: Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76
//-------------------------------------------------------------------------------


//метод создания массива
double[] CreateRandomDoubleArray( int size, int min, int max ) {
    double[] newArray = new double[size];
    for(int i =0; i < size; i++){
        newArray[i] = min + Math.Round( new Random().NextDouble() * ( max - min ), 1 );
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
} 

//метод поиска максимального элемента в массиве
double MaxElementInArray(double[] array){
    double max = array[0];
    for(int i = 1; i < array.Length; i++){
        if( array[i] > max ) max = array[i];
    }
    return max;
}

//метод поиска миниимального элемента в массиве
double MinElementInArray(double[] array){
    double min = array[0];
    for(int i = 1; i < array.Length; i++){
        if( array[i] < min ) min = array[i];
    }
    return min;
}

// задача 38
/*
double[] myArray = CreateRandomDoubleArray(20,1,10);
double min = MinElementInArray(myArray);
double max = MaxElementInArray(myArray);
//Console.WriteLine($"Minimum element in the array: {min}" ); // для проверки
//Console.WriteLine($"Maximum element in the array: {max}" ); // для проверки
Console.WriteLine("The difference between min and max: " + Math.Round( max - min,1 ));

// конец
*/