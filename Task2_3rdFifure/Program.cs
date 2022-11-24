Console.WriteLine ("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
    Console.WriteLine("Третьей цифры нет");
if (number > 99 && number < 1000)
    Console.WriteLine($"Третья цифра {number%10}");
if (number > 999)
{
    string strNumber = number.ToString();
    int n = strNumber.Length;
    int index = 0;
    int count = 1;
    while (index < n-3)
    {
        count = count * 10;
        index++;
    }
    number = number / count;
    Console.WriteLine($"Третья цифра {number%10}");


    

}