int N = new Random().Next(1, 65536);
if (N >= 10000)
{
    int n1 = N / 10;
    int n2 = n1 / 10;
    int n3 = n2 % 10;
    Console.WriteLine("Ваше число: " +N);
    Console.WriteLine("Третья цифра вашего числа: " +n3);
}
else if (N >= 1000)
{

    int n1 = N / 10;
    int n2 = n1 % 10;
    Console.WriteLine("Ваше число: " +N);
    Console.WriteLine("Третья цифра вашего числа: " +n2);
}
else if (N >= 100)
{
    int n1 = N % 10;
    Console.WriteLine("Ваше число: " +N);
    Console.WriteLine("Третья цифра вашего числа: " +n1);
}
else
{
    Console.WriteLine("Ваше число: " +N);
    Console.WriteLine("Третьей цифры нет");
}