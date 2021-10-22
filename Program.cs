using System;

namespace pallio
{
    class Program
    {
        static void Main(string[] args)
        {
            int T,r=0;
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt16(Console.ReadLine());
            int x = num;
            while(x!=0)
            {
                T = x % 10;
                r = (r*10) +T;
                x /= 10;
            }
            if(r==num)
            {
                Console.WriteLine("Its a paliandrome");
            }
            else
            {
                Console.WriteLine("Its a normal number");
            }
        }
    }
}
