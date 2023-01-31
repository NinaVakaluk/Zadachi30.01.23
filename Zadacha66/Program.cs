//Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите число  M"); 
int M = int.Parse(Console.ReadLine()!); 
Console.WriteLine("Введите число  N"); 
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumberSum(M,N)); 
 
int NumberSum(int M,int N) 
{ 
    if(M == N ) return M; 
    
    return (M  + NumberSum(M+1, N)); 
}