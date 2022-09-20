// See https://aka.ms/new-console-template for more informationЗадача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
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
Console.WriteLine("введите элемент из массива выше: ");
int n = int.Parse(Console.ReadLine());
int temp = 0;

for (int i = 0; i < arrray.GetLength(0); i++)
{
    for (int j = 0; j < arrray.GetLength(1); j++)
    {
        if (arrray[i,j] == n)
        {
            Console.WriteLine("число " + n + " присутсвует в массиве");
            return;
        }
        if (arrray[i,j] != n)
        {
            temp = arrray[i,j]; 
        }

    }
}
if (temp !=n)
{
    Console.WriteLine("числа " + n + " нет в массиве");
}



