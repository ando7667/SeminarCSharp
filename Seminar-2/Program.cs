// ========================================================
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// ------------------------------------------
// Вариант 1. Через математику

// метод для проверки на 3х значное число

bool CheckInput( int innum ) {
    bool bl;
    innum = innum / 100;
    if( innum > 0 && innum < 10 ) {
         bl = true;
    }
    else {
        bl = false;
        Console.WriteLine( "the number is not three-digit, repeat the input!" );
    }
    return bl;
}

// метод ввода числа
int InputNumber() {
    Console.Write( "enter a three-digit number: " );
    return Convert.ToInt32( Console.ReadLine() );
}

// метод фильтрации числа
int FiltrNumber(int aa) {
    aa = aa  % 100 / 10;
    return aa; 
}

// программа
int num;
do {
num = InputNumber();
} while( !CheckInput( num ));

num = FiltrNumber( num );
Console.WriteLine($"the second digit of the number: {num}" );

// конец программы


/*
//Вариант 2. Через массив ( строку )
// метод для проверки на 3х значное число
bool CheckInput( string innum ) {
    bool bl;
    if( innum.Length == 3 ) {
         bl = true;
    }
    else {
        bl = false;
        Console.WriteLine( "the number is not three-digit, repeat the input!" );
    }
    return bl;
}

// метод ввода числа
string InputNumber() {
    Console.Write( "enter a three-digit number: " );
    return Console.ReadLine();
}

// метод фильтрации числа
char FiltrNumber(string aa) {
    return aa[1]; 
}

// программа
string num;
char res;

do {
num = InputNumber();
} while( !CheckInput( num ));

res = FiltrNumber( num );
Console.WriteLine($"the second digit of the number: {res}" );

// конец программы
*/


// =========================================================
// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// --------------------------------------------
/*
// метод для проверки на 3х значное число
bool CheckInput( string innum ) {
    bool bl = false;
    if( innum.Length > 2 ) bl = true;
    return bl;
}


// метод фильтрации числа
char FiltrNumber(string aa) {
    return aa[2]; 
}

// программа
string num;
Console.Write( "enter any positive integer: " );
num = Console.ReadLine();
if( CheckInput( num ) ){
    num = "the third digit of the number : " + FiltrNumber( num );
}
else {
    num = "there is no third digit in the number!";
}
Console.WriteLine( num );

// конец программы
*/


// =========================================================
// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// --------------------------------------------

/*
// метод для проверки на допустимое число 1-7(день недели)
bool CheckInput( int innum ) {
    bool bl = false;
    if( innum >= 1 && innum <= 7 ) bl = true;
    return bl;
}

// метод проверки на вых день
bool CheckDay( int aa ) {
    return ( ( aa == 6 || aa == 7 )? true : false ); 
}

// программа
int num;
string str;
Console.Write( "enter a number (1-7) indicating the day of the week: " );
num = Convert.ToInt32( Console.ReadLine() );

if( CheckInput(num) ){
    if( CheckDay(num)){
        str = "it's a day off";
    }
    else{
        str = "It's a working day";
    }
}
else{
    str = "the day of the week is entered incorrectly!";
}

Console.Write(str);
// конец программы
*/