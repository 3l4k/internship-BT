using System;
namespace Task{
    class program{
        static double top1(double a, double b, double d){
            double ans, output;
            ans = (a*b)/(2*d);
            output = Math.Pow(ans, 0.5);
            output*=3;
            return output;
        }
        static double top2(double t, double c, double d){
            double ans, output;
            ans = t*c;
            ans = Math.Pow(ans,0.5);
            ans = ans/(2*d);
            output = ans*ans;
            output = Math.Pow(output,0.5);
            return output;
        }

        static void Main(string[] args){
            double a,b,c,d,t,output;

            Console.WriteLine("The Equation is: ");
            Console.WriteLine("Sqrt((A*b)/(2*D))*3 - Sqrt((sqrt(T*C)/(2*D))^2)");
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("\t\t4*A*C");

            //INPUT A
            Console.Write("Enter the value of a: ");
            a = Convert.ToDouble(Console.ReadLine());
            // INPUT B
            Console.Write("Enter the value of b: ");
            b = Convert.ToDouble(Console.ReadLine());
            // INPUT C
            Console.Write("Enter the value of c: ");
            c = Convert.ToDouble(Console.ReadLine());
            // INPUT D
            Console.Write("Enter the value of d: ");
            d = Convert.ToDouble(Console.ReadLine());
            // INPUT T
            Console.Write("Enter the value of t: ");
            t = Convert.ToDouble(Console.ReadLine());

            output = (top1(a,b,d)-top2(t,c,d))/(4*a*c);
            Console.WriteLine("The answer is: {0}", output);
            
            // double a = 4;
            // double b = Math.Pow(a,0.5);
            // Console.WriteLine("{0}", b);
        }
    }
}