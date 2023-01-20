// Задача 38: Напишите программу реализующую методы формирования массива, 
//заполненного случайными вещественными числами и вычисления 
//разницы между максимальным и минимальным элементов массива.



using static System.Console;
Clear();

WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;
GetArray(numbers);

void GetArray(double[] numbers)
{
   for (int z = 0; z < numbers.Length; z++)
   {
      if (numbers[z] > max)
      {
         max = numbers[z];
      }
      if (numbers[z] < min)
      {
         min = numbers[z];
      }
   }
}
WriteLine($" -> Разница между максимальным и минимальным значением = {max - min}");



void FillArrayRandomNumbers(double[] numbers)
{
   for (int i = 0; i < numbers.Length; i++)
   {
      numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
   }
}
void PrintArray(double[] numbers)
{
   Write("[ ");
   for (int i = 0; i < numbers.Length; i++)
   {
      Write($"{numbers[i]} ");
   }
   Write("]");
}
