#region X, Y və Z ədədləri verilir. Hansı ədədin böyük olduğunu ekrana çıxardan bir alqoritm yazırsız.

Console.WriteLine("X daxil et: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y daxil et: ");
int numY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z daxil et: ");
int numZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Boyuk olan");
if (numX > numY && numX > numZ)
{
    Console.WriteLine(numX);
}
else if (numY > numX && numY > numZ)
{
    Console.WriteLine(numY);
}
else
{
    Console.WriteLine(numZ);
}
#endregion