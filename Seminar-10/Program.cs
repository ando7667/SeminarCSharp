void ShowStringArray( string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ( (i<array.Length-1)?", ":"" ) );

    Console.WriteLine();
}

string[] CombiningElementsArrayInPairs(string[] array)
{
    int size = array.Length/2;
    bool even = true;
    if ( array.Length % 2 != 0 ) // проверка на четное количество элементов в массиве(у всех пары)
    {
        size++; 
        even = false;
    }

    string[] arraynew = new string [size];
    for( int i = 0, j = 0; i < array.Length; i+=2,j++ )
    {
        if( i < array.Length-1 ) arraynew[j] = array[i] + array[i+1];
        if( i == array.Length-1 && !even ) arraynew[j] = array[i];  // дописываем нечетный элемент(без пары)
       
    }    
    return arraynew;
}

int СountsWordsArrayStartingVowel(string[] array)
{
    int countWords = 0;
    char[] arrayVowel = {'a', 'e', 'i', 'o', 'y', 'u', 'j'};

    for( int i = 0; i < array.Length; i++)
        for(int j = 0; j < arrayVowel.Length; j++)
            if( array[i][0] == arrayVowel[j] ) countWords++;

    return countWords;
}

//=======================================================================
// Задача 1: Задайте массив строк. Напишите программу,
// считает кол-во слов в массиве, начинающихся на гласную букву.
// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1
//----------------------------------------------------------------------


string[] arrayString = { "one", "two", "three", "four", "five","six", "seven", "eight","end"};

Console.WriteLine("the number of words in an array starting in the vowel letter: " + СountsWordsArrayStartingVowel(arrayString) );




//==========================================================================================
// Задача 2: Задайте массив строк. Напишите программу,
// которая генерирует новый массив, объединяя элементы исходного массива попарно.
// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}
//--------------------------------------------------------------------------------------------


/*
string[] arrayString = { "one", "two", "three", "four", "five","six", "seven", "eight","end"};

string[] arrayStringNew = CombiningElementsArrayInPairs(arrayString);

ShowStringArray(arrayStringNew);
*/
