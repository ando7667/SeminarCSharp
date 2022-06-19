// ==========================================================================
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом. 14212 -> нет;12821 -> да; 23432 -> да; 
//--------------------------------------------------------------------------
/*
// метод проверки на полиндром
string FiltrNumber(string aa) {
    string str = "Не является полиндромом";
    int indexmax = aa.Length;
    int result = indexmax/2;
    int count = 0;
    indexmax--;
    while( indexmax > count) {
        if( aa[count] == aa[indexmax] ) {
            result--;
        }
        indexmax--;
        count++;
    }
    if(result == 0) str = "Является полиндромом";

    return str; 
}

string strIn;

Console.Write( "enter a five-digit number: " );
strIn = Console.ReadLine();
if( strIn.Length == 5 ) {
    strIn = FiltrNumber( strIn );   
}
else{
    strIn = "Вы ввели не 5и значное число!";
}
Console.WriteLine(strIn);
*/

// =============================================================================
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84 ;  A (7,-5, 0); B (1,-1,9) -> 11.53
// ------------------------------------------------------------------------------

/*
// метод для проверки введенных координат по шаблону через регулярное выражение
using System.Text.RegularExpressions;
Regex rg = new Regex(@"^[-+]?(\d+),[-+]?(\d+),[-+]?(\d+)$");

bool CheckInput( string ss ) {
    bool result =  false;
    if( rg.IsMatch(ss) ) {
        result = true;
    }
    else{
        Console.WriteLine("Координаты введены неправильно! Повторите ввод.");
    }
    return result;
}

// метод ввода строки координат
string InputCoordinat(int ii) {
    Console.Write($"Введите через запятую координаты {ii}й точки в 3D пространстве( x,y,z ) :");
    return Console.ReadLine();
}

// метод вычисления расстояния между 2мя точками в 3D пространстве
double distance( int[][] arr ) {
    double result = 0;
    result = Math.Sqrt( Math.Pow(arr[1][0]-arr[0][0],2) + Math.Pow(arr[1][1]-arr[0][1],2) + Math.Pow(arr[1][2]-arr[0][2],2) );
    return result; 
}

// программа
string num;                         // хранит введенную строку координат точки - x,y,z
int[][] arr_coord = new int[2][];   // массив точек
int[] coord = new int[3];           // массив координат точки
double distTwoPoint;                // тут будет расстояние между 2мя точками
int point = 2;                      // количество вводимых точек

// цикл для ввода координат точек
for (int i = 0; i < point; i++ ){
    // цикл для корректного ввода координат точки
    do {
        num = InputCoordinat(i+1);
    } while( !CheckInput( num ));

    // Console.WriteLine($"ВВеденные координаты: {num}" ); //для отладки
    coord = num.Split(',').Select(int.Parse).ToArray();
    arr_coord[i] = coord;
}
//Console.WriteLine($"Point-1 => x={arr_coord[0][0]},y={arr_coord[0][1]},z={arr_coord[0][2]}"); //для отладки
//Console.WriteLine($"Point-2 => x={arr_coord[1][0]},y={arr_coord[1][1]},z={arr_coord[1][2]}"); //для отладки
distTwoPoint = distance(arr_coord);
Console.WriteLine($"Расстояние между двумя заданными точками в 3D пространстве = {String.Format("{0:F2}",distTwoPoint)} ");

// конец программы
*/


// ==============================================================================
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт
// таблицу кубов чисел от 1 до N. 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125
// -----------------------------------------------------------------------------

/*
string TabCub( int aa ) {
    string ss;
    if( aa > 0 ) {
        ss = "Таблица кубов для чисел от 1 до " + aa + " -> ";
        for( int i = 1; i <= aa; i++ ) {
            ss += String.Format( "{0:F0}", Math.Pow(i,3) );
            if(i != aa) ss += ", "; 
        }
    }
    else{
        ss = "Введено неправильное число!";
    }
    return ( ss );
}

int num;
string str;
Console.Write("Введите число: ");
num = Convert.ToInt32( Console.ReadLine() );

str = TabCub( num );
Console.WriteLine(str);

*/