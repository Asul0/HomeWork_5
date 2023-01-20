// Напишите программу реализующую методы формирования 
//массива, заполненного случайными числами и подсчета 
//суммы элементов, стоящих на нечётных позициях.

using static System.Console;
Clear();


int[] numbers = new int[6];           //  ввести кол-во элементов
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
GetSum(numbers);


void GetSum(int[] numbers)
{
int sum = 0;

for (int j = 1; j < numbers.Length; j += 2)
   sum = sum + numbers[j];
WriteLine($" -> сумма элементов cтоящих на нечётных позициях = {sum}");
}


void FillArrayRandomNumbers(int[] numbers)
{
   for (int i = 0; i < numbers.Length; i++)
   {
      numbers[i] = new Random().Next(1, 10);
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