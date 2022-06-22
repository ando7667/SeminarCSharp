//===============================================================================
// Задача 25: Напишите программу, которая принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵) ; 2, 4 -> 16
//-------------------------------------------------------------------------------

float NumberToPower(int number, int power){
    float result = number;
    if(power == 0) { number = 1; return number;}
    if(power == 1) { return number; }
    for ( int i = 1; i < power; i++ ){
            result *= number;
     }
    return result;
}

Console.Write("Введите число :");
int num = Convert.ToInt32( Console.ReadLine() );
Console.Write("Введите степень числа :");
int pow = Convert.ToInt32( Console.ReadLine() );
Console.WriteLine("Число " + num + " в степени " + pow + " = " + NumberToPower(num,pow));


//===============================================================================
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 3, 44, 3 -> [1, 2, 5, 7, 19, 3, 44, 3]
//-------------------------------------------------------------------------------

/*
//метод для создания массива
int[] CreateRandomArray(int size, int min, int max){
    int[] newArray = new int[size];
    for(int i =0; i < size; i++){
        newArray[i] = new Random().Next(min, max + 1);
//        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
} 

string OutputArrayConsole(int[] array){
    string ss = "";
    for(int i = 0; i < array.Length; i++){
        ss += array[i];
        if( i < array.Length-1 ) ss += ", ";           
    }
    return ss;
}

int[] myArray = CreateRandomArray(8,1,100);
Console.WriteLine("Созданный массив: [" + OutputArrayConsole(myArray) + "]");
*/