// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбе
int[,]GetMass(int m,int n)
{
int[,] mas = new int [m,n];
for (int i = 0; i<m; i++)
{
    for (int j= 0;j<n;j++)
    {
        mas[i,j] = new Random().Next (0,10);
    }
}
return mas;
}
void PrintArray(int[,] arr)
{
   for (int i = 0; i<arr.GetLength(0); i++)
{
    for (int j= 0;j<arr.GetLength(1);j++)
    {
        Console.Write(arr [i,j]);
    } 
    Console.WriteLine();
}
}
int [,] arrray = GetMass(3,4);
PrintArray (arrray);
double sum = 0;
for (int j =0;j < arrray.GetLength(1);j++ )
{
     for (int i = 0; i < arrray.GetLength(0);i++)
    {
        
        sum = sum + arrray[i,j];
    }
    sum = sum/arrray.GetLength(0);
Console.WriteLine($"среднее арифметичесое столба: {j+1} = {Math.Round(sum,1)}");
}
