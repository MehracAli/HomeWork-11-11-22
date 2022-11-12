
Console.WriteLine("Reqem daxil et: ");
int checkNumber = Convert.ToInt32(Console.ReadLine());
int number = 2;
int lastIndex = 1;

for (int i = number; i <= checkNumber; i*=number)
{
    lastIndex = i;
}
//Console.WriteLine(count);


if (lastIndex == checkNumber)
{
    Console.WriteLine("Quvvetidir");
}
else
{
    Console.WriteLine("Quvvet Deyil");
}