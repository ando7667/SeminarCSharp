//===============================================================================
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2 ; 1, -7, 567, 89, 223-> 3
//-------------------------------------------------------------------------------

using System.Linq;

//метод создания массива
int[] CreateRandomArray(int size, int min, int max){
    int[] newArray = new int[size];
    for(int i =0; i < size; i++){
        newArray[i] = new Random().Next(min, max + 1);
    }
    return newArray;
} 

// метод конвертации строки чисел в массив целых чисел
int[] ConvertStringToArray( string st )
{
    st = st.Replace(" ","")
            .Replace(".","")
            .Replace("--","-");;

    var data =  st.Split(",")
            .Where(x => !string.IsNullOrWhiteSpace( x ))
            .Select( x => int.Parse(x))
            .ToArray();
    return data;
}

// метод вывода массива в консоль
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

// метод ввода строки цифр
string InputStringNumber()
{
    Console.Write($"Введите через запятую произвольное кол-во цифр :");
    return Console.ReadLine();
}

// метод подсчета элементов массива больше нуля
int CountElementsGreaterZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++ )
        if(array[i] > 0) count++;

    return count;
}

// метод копирования массива поэлементно
int[] CopyArray(int[] arr)
{
    int[] arrnew = new int[arr.Length];
    for( int i = 0; i < arr.Length; i++ )
        arrnew[i] = arr[i];

    return arrnew;
}


// программа
/*
string inputdata = InputStringNumber();
int[] array = ConvertStringToArray(inputdata);
OutputArrayConsole(array);
Console.WriteLine("the number of elements in the array is greater than zero : " + CountElementsGreaterZero(array) );
*/

//===============================================================================
// Задача 45: Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования.
//-------------------------------------------------------------------------------
/*
int sizearray = 20;
int minrange = 1;
int maxrange = 100;
int[] arr = CreateRandomArray(sizearray,minrange,maxrange);
Console.Write("Input ");
OutputArrayConsole(arr);
int[] arrcopy = CopyArray(arr);
Console.Write("Сopied ");
OutputArrayConsole(arrcopy);
*/