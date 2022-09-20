// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
int[,] GetArrayint(int m,int n)
{
    int [,] fill = new int [m,n];
    for (int i = 0;i < m; i++)
    {
        for(int j = 0; j < n;j++)
        {
            fill[i,j] = new Random().Next(1,10);
        }
    }
    return fill;
}


void PrintArray(int[,]array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0 ; j< array.GetLength(1);j++)
        {
            Console.Write(array[i,j]);
        }
        Console.WriteLine();
    }
}
Console.Write("введите ол-во строчек ");
int rows = int.Parse(Console.ReadLine());
Console.Write("введите ол-во столбов ");
int colums = int.Parse(Console.ReadLine());
int [,] my = GetArrayint(rows,colums);
PrintArray(my);
double[,]GetArraydouble(int m,int n)
{
    double[,] doub = new double[m,n];
    for (int i = 0;i < m; i++)
    {
        for(int j = 0; j < n;j++)
        {
            doub[i,j] =20* new Random().NextDouble();
        }
    }
    return doub;
}
double[,]mydoub = GetArraydouble(rows,colums);

void PrintArraydouble(double[,]array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0 ; j< array.GetLength(1);j++)
        {
            Console.Write(array[i,j]);
        }
        Console.WriteLine();
    }
}
PrintArraydouble(mydoub);