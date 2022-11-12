Console.WriteLine("Birinci ededi daxil et: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ikinci ededi daxil et: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Araliq: ");
for (int i = num1; i <= num2; i++)
{
    Console.WriteLine(i);
}
for (int i = num1; i >= num2; i--)
{
    Console.WriteLine(i);
}