// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write($"Введи число М(количество чисел): ");
int massiv = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[massiv];

void InputNumbers(int massiv)
{
for (int i = 0; i < massiv; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int AmountPositiveNumbers(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if(arr[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(massiv);

Console.WriteLine($"Количество чисел больше 0: {AmountPositiveNumbers(arr)} ");
