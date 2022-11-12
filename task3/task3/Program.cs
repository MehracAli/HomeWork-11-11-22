
Console.WriteLine("Reqem daxil et: ");
int num = Convert.ToInt32(Console.ReadLine());
int defaultNum = 70;
int threeX = 3;

if (num > defaultNum)
{
    threeX *= num - defaultNum;
    Console.WriteLine("Ferqin 3 qati: ");
    Console.WriteLine(threeX);
}
else
{
    defaultNum-=num;
    Console.WriteLine("Ferq: ");
    Console.WriteLine(defaultNum);
}