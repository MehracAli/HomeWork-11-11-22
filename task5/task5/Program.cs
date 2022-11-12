Console.WriteLine("n reqemini daxil et: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("m reqemini daxil et: ");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int i = n; i <= m; i++)
{
    if (i % 2 != 0)
    {
        //Console.WriteLine(i);
        count++;
    }
}

Console.WriteLine("Tek reqemlerin sayisi: "+count);