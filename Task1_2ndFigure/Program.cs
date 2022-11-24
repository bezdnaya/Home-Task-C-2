Console.WriteLine ("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
number = number - (number/100)*100;
Console.WriteLine($"Вторая цифра числа: {number / 10}");
