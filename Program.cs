Console.WriteLine("Введите исходное число для конвертирования:");
string x = Console.ReadLine();

Console.WriteLine("Введите основание исходной системы счисления:");
int q1;
if (!int.TryParse(Console.ReadLine(), out q1))
{
    Console.WriteLine("Ошибка: указана некорректная исходная система счисления.");
    return;
}
Console.WriteLine("Введите основание целевой системы счисления:");
int q2; 
if (!int.TryParse(Console.ReadLine(), out q2) || q2 < 2)
{
    Console.WriteLine("Ошибка: указана некорректная целевая система счисления");
    return;
}

try
{
    int decimalNumber = Convert.ToInt32(x, q1);
    string result = Convert.ToString(decimalNumber, q2);
    Console.WriteLine($"Результат: {result}");
}
catch (FormatException)
{
    Console.WriteLine("Ошибка: Введено некорректное число для указанной системы счисления.");
}
catch (ArgumentException)
{
    Console.WriteLine("Ошибка: Указана некорректная система счисления.");
}
catch (OverflowException)
{
    Console.WriteLine("Ошибка: Число слишком велико для конвертации.");
}
