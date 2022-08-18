// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
 using static System.Console;
Clear();

int[] Mass = GetmyArray(8);
WriteLine($"[{String.Join(", ", Mass)}]");


int[] GetmyArray(int N)
{
int[] myarray = new int[N];
for (int i=0; i<N; i++)
{
    myarray[i] = new Random().Next(0,33);
}
return myarray;
}   






 
            
    




