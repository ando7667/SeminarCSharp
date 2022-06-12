// ========================================================
// Задача 1: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// ------------------------------------------

/*

int num1, num2, result;
Console.Write( "Input integer number 1: " );
num1 = Convert.ToInt32( Console.ReadLine() );

Console.Write( "Input integer number 2: " );
num2 = Convert.ToInt32( Console.ReadLine() );

if( num1 == num2 ) {
    Console.WriteLine( "These numbers are equal" );
}
else {
    result = num2;
    if( num1 > num2 ) result = num1;
    Console.WriteLine( $"The largest number: {result}" );
}

*/

// =========================================================
// Задача 2: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// --------------------------------------------

/*

int num1, num2, num3, max;
Console.Write( "Input integer number 1: " );
num1 = Convert.ToInt32( Console.ReadLine() );

Console.Write( "Input integer number 2: " );
num2 = Convert.ToInt32( Console.ReadLine() );

Console.Write( "Input integer number 3: " );
num3 = Convert.ToInt32( Console.ReadLine() );

max = num1;
if( num2 > max ) max = num2;
if( num3 > max ) max = num3;

Console.WriteLine( $"The maximum of these numbers: {max}" );

*/

// =========================================================
// Задача 3: Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// --------------------------------------------

/*

int num;
string str;
Console.Write( "Input integer number: " );
num = Convert.ToInt32( Console.ReadLine() );

str = "odd";
if( num % 2 == 0) str = "even";
Console.WriteLine( $"the number {num} is {str}" );

*/

// =========================================================
// Задача 4: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.
// --------------------------------------------

int num, index;
string str;
Console.Write( "Input integer number: " );
num = Convert.ToInt32( Console.ReadLine() );

index = 2;
str = "";

if( num < 2 ) str = "there are no even numbers in a given range!";
while( index <= num ) {
    if( index % 2 == 0) str += index + " ";
    index++;
}
Console.Write(str);