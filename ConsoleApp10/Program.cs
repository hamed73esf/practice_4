using System;
class test
{
    public static void Main()
    {
        Console.WriteLine("enter a:");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter b:");
        int b=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter c:");
        int c=Convert.ToInt32(Console.ReadLine());
        rishe(a, b, c);
    }
    private static void rishe(int x,int y,int z)
    {
        double delta = (Math.Pow(y, 2)) - (4 * x * z);
        if(delta > 0)
        {
            double javab_1 = (-y + Math.Sqrt(delta)) / 2 * x;
            double javab_2 = (-y - Math.Sqrt(delta)) / 2 * x;
            Console.Write("moadele 2 javab darad--->  ");
            Console.Write("javab 1:");
            Console.Write(javab_1);
            Console.Write("   javab 2:");
            Console.Write(javab_2);
        }
        if(delta == 0)
        {
            double javab_1 = -y / 2 * x;
            Console.Write("moadele 1 javab darad:");
            Console.WriteLine(javab_1);
        }
        if(delta < 0)
        {
            Console.WriteLine("moadele javab nadarad");
        }
    }
}