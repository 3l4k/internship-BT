using System;

namespace Task4
{
    class Outputs
    {
        public void Invalid()
        {
            Console.WriteLine("Invalid Interval\n\tReenter values");
        }
        public void Valid(int max = 0, int min = 0, int interval = 0)
        {
            int n = (max - min) / interval;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += min;
                min += interval;
                n = (max - min) / interval;
            }
            Console.WriteLine("The sum is: {0}", sum);
        }
    }

    class project
    {
        static void Main(string[] args)
        {
            Outputs outs = new Outputs();
            int a = 0;
            int min, max, interval;
            while (a < 1)
            {
                Console.Write("Enter max: ");
                max = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter min: ");
                min = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter interval: ");
                interval = Convert.ToInt32(Console.ReadLine());
                if ((max - min) % interval != 0)
                {
                    outs.Invalid();
                    a = 0;
                }
                else
                {
                    outs.Valid(max,min,interval);
                    a += 1;
                }
            }
        }
    }
}