/*string[ , ] table = new string[2, 5];// 2 кол-во строк; 5 кол-во столбцов

// String.Empty инициализация строк изначально пусто
//table[0 , 0]   table[0 , 1]   table[0 , 2]   table[0 , 3]   table[0 , 4]
//table[1 , 0]   table[1 , 1]   table[1 , 2]   table[1 , 3]   table[1 , 4]

table[1, 2] = "Слово";// обращаемся к 1 строке 2 столбца

for (int i = 0; i < 2; i++)
{
for (int j = 0; j < 5; j++)
{
Console.WriteLine($"-{table[i , j]}-");    
}
}
*/
/////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////
/*int[,] matrix = new int[3,4];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        /*Console.WriteLine($"{matrix[i , j]} ");
        Console.Write($"{matrix[i, j]} ");    
    }
    Console.WriteLine();//принудительно перекидываем на другой столбец
}
*/
/////////////////////////////////////////////////////////////
//int[,] matrix = new int[3,4];// далее в цикле можно вместо 3 и 4 использовать нижепоказанные значения

/*void PrintArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        Console.Write($"{matr[i, j]} ");    
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           matr[i,j] = new Random().Next(1,10);//[1,10]
        }
    }
}


int[,] matrix = new int[3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();//прослойка между нулями и массивом
PrintArray(matrix);
*/
//////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////

/*int[,] pic = new int[,]
{
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};

void PrintImage(int[,] image)
{

    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
        //Console.Write($"{image[i, j]} "); 
        if (image[i,j] == 0) Console.Write($" ");
        else Console.Write($"+");   
        }
    Console.WriteLine();
    }
}

void FillImage(int row, int col)//позиция строки и пикселя с которого начинаем закраску
{
    if (pic[row, col] == 0)//не закрашен
    {
        pic[row, col] = 8;//красить будем восьмеркой
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}

PrintImage(pic);
FillImage(13,13);
PrintImage(pic);
*/

////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////
///////////////////РЕКУРСИЯ/функция вызывает сама себя///
////////////////////////////////////////////////////////

// Рекурсия вычисления факториала
// 5! = 5 * 4 * 3 * 2 * 1
// 5 * 4!
// 4 * 3!
// 3 * 2!
// 2 * 1!

/*int Factorial (int n)
{
// 1! = 1
// 0! = 1
if (n == 1) return 1;
else return n * Factorial(n - 1);
}

Console.WriteLine(Factorial(3)); // 1*2*3 = 6
*/

/*double Factorial (int n)
{
// 1! = 1
// 0! = 1
if (n == 1) return 1;
else return n * Factorial(n - 1);
}

for (int i = 1; i < 40; i++)
{

Console.WriteLine($"{i} = {Factorial(i)}");

}
*/

//Фибоначчи каждое следующее число задается через предыдущее
// F(1) = 1
// F(2) = 1
// F(n) = F(n-1) + F(n-2)

double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
        else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"f{i} = {Fibonacci(i)}");
}







