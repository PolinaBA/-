// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру от 1 до 7");
string A = Console.ReadLine()!;
int numberA = Convert.ToInt32(A);

if (numberA == 6 || numberA == 7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Будний день");

}