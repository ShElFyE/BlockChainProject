int n = 0;
Console.WriteLine("Введите число:");
n = int.Parse(Console.ReadLine());
if (n > 1)
{
    for (var i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            Console.WriteLine(" не просте");
        }
        else
        {
            Console.WriteLine("просте");
        }
    }
}
else
{
    Console.WriteLine(" не просте");
}