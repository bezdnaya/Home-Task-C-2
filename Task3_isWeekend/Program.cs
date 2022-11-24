Console.Write("Введите цифрой какой сейчас день недели ");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 6)
Console.WriteLine("Это рабочий день");
if (day > 5 && day < 8)
Console.WriteLine("Это выходной");
if (day > 7)
Console.WriteLine("Такого дня недели не существует");
// проверка2