#region Verilen 2 eded arasindaki ededleri ekrana yazdiran alqoritm.

Console.WriteLine("Birinci ededi daxil et: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ikinci ededi daxil et: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Araliq: ");
int count = 1;
for (int i = num1; i <= num2; i++)
{
    Console.WriteLine(i);

    if (num2 < num1)
    {
        count = i;
        Console.WriteLine(count);
    }
}

for (int i = num1; i >= num2; i--)
{
    Console.WriteLine(i);
}
#endregion