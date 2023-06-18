// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
string A = Console.ReadLine()!;
int numberA = Convert.ToInt32(A);

int counter = 0;
if (numberA > 99) 
{
    while (counter < 3)
    {
        int lastDigit = numberA % 10;
        numberA = numberA / 10;
        counter ++;
        if (counter == 3)
        {
         Console.WriteLine(lastDigit);
        }
    }
}

else 
{ 
    Console.WriteLine("Третьего числа нет");
}