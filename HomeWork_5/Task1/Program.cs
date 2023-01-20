// Задача 34: Напишите программу реализующую методы формирования массива, 
//заполненного случайными положительными трёхзначными числами, 
//и подсчета количества чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();



int[] numbers = new int[6]; //  ввести кол-во элементов
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
GetSum(numbers);


void FillArrayRandomNumbers(int[] numbers)
{
   for (int i = 0; i < numbers.Length; i++)
   {
      numbers[i] = new Random().Next(100, 1000);
   }
}


void PrintArray(int[] numbers)
{
   Write("[");
   for (int i = 0; i < numbers.Length - 1; i++)
   {
      Write($"{numbers[i]},");
   }
   Write($"{numbers[5]}]"); // здесь указваем на один элемент меньше
}


void GetSum(int[] numbers)
{
   int count = 0;
   for (int j = 0; j < numbers.Length; j++)
      if (numbers[j] % 2 == 0)
      {
         count++;
      }
   Write($" -> {count} из них чётные");

}