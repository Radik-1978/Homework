// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
using static System.Console;
Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  WriteLine("этот день выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
  WriteLine("это не день недели");
  }
  else 
  WriteLine("этот день не выходной");
}

CheckingTheDayOfTheWeek(dayNumber);

