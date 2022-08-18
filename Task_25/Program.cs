// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

using static System.Console;
Clear();
Write("Введите  число A = ");
int A = Convert.ToInt32(ReadLine());
Write("Введите  число B = ");
int B = Convert.ToInt32(ReadLine());
int rais = GetRais(A,B);
WriteLine($"Возведение числа {A} в степень {B} = {rais}");



 int GetRais(int number1,int number2)
{
  int result = number1;  
 
 for(int i = 1;i < number2;i++)
    {
        
result = result * number1;

}
return result;  
}
 















    




