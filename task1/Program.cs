// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень числа B

// 3,5 -> 243(3^5)
// 2,4 -> 16

Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

while(numB>0)
{
  Console.Write(Math.Pow(numA,numB));
  break;
}
