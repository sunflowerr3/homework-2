// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("введите число!!");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7)
{
    Console.WriteLine("Это выходной");
}
else if (number > 7 || number < 1)
{
    Console.WriteLine ("Неверный ввод");
}
else Console.WriteLine ("Будний день");