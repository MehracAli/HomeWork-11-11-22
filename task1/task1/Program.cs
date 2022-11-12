#region Ədədin 2-nin qüvvəti olub olmadığını tapan alqoritm.

Console.Write("Quvveti yoxlanan reqem daxil et: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Quvvet olmasi yoxlanan reqem daxil et: ");
int checkNumber = Convert.ToInt32(Console.ReadLine());

int lastIndex = 1;

for (int i = number; i <= checkNumber; i*=number)
{
    lastIndex = i;
}
//Console.WriteLine(lastIndex);

Console.Write("Daxil etdiyin reqem: ");
if (lastIndex == checkNumber)
{
    //Console.BackgroundColor = ConsoleColor.Green;
    //Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(number+"'in quvvetidir!");
}
else
{
    //Console.BackgroundColor = ConsoleColor.Red;
    //Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(number+"'in quvveti deyil!");
}
#endregion