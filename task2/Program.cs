// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;

while(num > 0)
{
  sum = sum + num % 10;
  num /=10;
}

Console.WriteLine($"Сумма цифр введенного числа: " +sum);


// Решение(сторонний вариант, цикл for)

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();

// int sum = 0;
// for(int i = 0; i < number.Length; i++)
// {
//   string str = Convert.ToString(number[i]);
//   int num1 = Convert.ToInt32(str);
//   sum = sum + num1;
// }

// Console.WriteLine(sum);