#region Verilen eded 70-den boyukdurse, 70-le arasindaki ferqin 3 qatini ekrana yazdiran, eger kicikdirse ferqin ozunu ekrana yazdiran alqoritm.

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
#endregion