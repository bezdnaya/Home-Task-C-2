Console.Write("Введите цифрой какой сейчас день недели ");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 8)
{
switch (day)
{
    case 1:
        Console.WriteLine("Понедельник. Ура на работу");
        break;
    case 2:
       Console.WriteLine("Вторник. Рабочий день"); 
       break;
    case 3:
        Console.WriteLine("Среда. Снова работа");
        break;
    case 4:
        Console.WriteLine("Четверг. Ура, завтра пятница");
        break;
    case 5:
        Console.WriteLine("Ура, последний рабочий день");
        break;
    case 6:
        Console.WriteLine("Ура, отдыхаем");
        break;
    case 7:
        Console.WriteLine("Ура, отдыхаем");
        break;
}
}
else
    Console.WriteLine("Неправильно введён день недели");