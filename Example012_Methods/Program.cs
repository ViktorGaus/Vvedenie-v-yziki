/*// Вид 1 Методы которые ничего не возвращают и ничего не принимают

using System.Diagnostics.CodeAnalysis;

void Method1()
{
    Console.WriteLine("Автор Гаус Виктор");
}
//Method1();


// Вид 2 Ничего не возвращают, но могут принимать аргументы

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;  //инкримент -- декремент
    }
}
//Method21("Текс", 4);//сообщение текст 4 раза
//Method21(count: 4, msg: "Текст");то же что и предыдущей другой записью

//Вид 3 Что то возвращают но ничего непринимают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

//Вид 4 Методы которые что то принимают и что то возвращают
string Method4(int count, string text)
{
int i = 0;
string result = String.Empty;//те резалт изночально будет пустой строкой

    while (i < count)
    {
    result = result + text;
    i++;
    }
    return result; 
}

string res = Method4(10, "Гаус ");//10 раз Гаус
//Console.WriteLine(res);

/////////////////////////////////////////////////////
//////////////////////////////////////////////////////
////////////////////////////////////////////////////
/////////////////////////////////////////////////////

// for цикл

string Method44(int count, string text)
{
string result = String.Empty;
for( int i = 0; i < count; i++)
    {
    result = result + text;
    }
    return result; 
}

string res = Method44(10, "Гаус ");
//Console.WriteLine(res);


// цикл внутри цикла
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
    Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}


////// Дан текс. В тексте нужно все пробелы заменить черточками
////// маленькие буквы "к" заменить большими "К", а большие
///// "С" заменить маленькими "с".

string text =    "Я думаю, сказал князь, улыбаясь, что,"
                +"ежели бы вас послали вместо нашего Винценгероде,"
                +"вы бы взяли приступом согласие прусского короля."
                +"Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;

    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replase(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();

newText = Replase(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replase(text, 'С', 'с');
Console.WriteLine(newText);
*/

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
     Console.Write($"{array[i]} ");   
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);




