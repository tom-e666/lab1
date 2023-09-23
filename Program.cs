using System.ComponentModel.Design;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        double a, b, c;
        double ans1, ans2;
        Console.WriteLine("please enter a:");
        a = getValidNum();
        Console.WriteLine("please enter b:");
        b = getValidNum();
        Console.WriteLine("please enter c:");
        c = getValidNum();
        //check a;
        if (a == 0)
        {
            Console.WriteLine("a=0,special case:");
            if (b == 0)
            {
                Console.WriteLine("a=b=0, rare one:");
                if (c == 0)
                {
                    Console.WriteLine("a=b=c=0 this function accepts all value as answer");
                }
                else
                {
                    Console.WriteLine("this function have no x");
                }
            }
            else
            {
                Console.WriteLine($"the asnwer is ans1 = asn2={-c/b}");
            }
        }
        else
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if(delta == 0)
            {
                Console.WriteLine($"delta equal 0, then double ans={-b/2/a}");
            }else if (delta < 0)
            {
                Console.WriteLine("this fn have no ans");
            }
            else
            {
                 ans1=(-b-Math.Sqrt(delta))/2/a;
                ans2= (-b + Math.Sqrt(delta)) / 2 / a;
                Console.WriteLine($"ans1= {ans1} \n ans2= {ans2}");
            }
        }
            Console.WriteLine("well, thank you for trusting this fucked app :) \n automatically close after 4...");
        Thread.Sleep(4000);
        Environment.Exit(0);    

    }
    static int getValidNum()
    {
        int k;
        if(int.TryParse(Console.ReadLine(), out k)) {
            return k;
        }
        else
        {
            Console.WriteLine("you enter wrong!, please enter another:");
            return getValidNum();
        }
    }
}