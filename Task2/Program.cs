using System;

namespace PolymorphismApplication {
   class solve {
      void calc(double a, double b, double c) {
        double d = (b*b)-(4*a*c);
        d = Math.Pow(d,0.5);
        double x1 = ((0-b)+d)/(2*a);
        double x2 = ((0-b)-d)/(2*a);
         Console.WriteLine("X1: {0}\nX2: {1}", x1,x2);
      }
      void calc(double r) {
        double A = 3.142*r*r;
         Console.WriteLine("Radius: {0}\nArea: {1}",r,A);
      }
      void calc(double a, double b) {
        double c = (a*a)+(b*b);
        c = Math.Pow(c,0.5);
         Console.WriteLine("The hypthoneus is: {0}", c);
      }
      static void Main(string[] args) {
         solve s = new solve();
         int checker;
         Console.WriteLine("Enter \n1 to solve quadratic formula, \n2 to find area of circle, \n3 to find hypothenus using pythagoras formula: ");
         checker = Convert.ToInt32(Console.ReadLine());
         switch (checker)
         {
            case 1:
                // Quadratic formula
                double a,b,c;
                Console.WriteLine("a^2X+bX+c=0");
                Console.Write("Enter the value of a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the value of b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the value of c: ");
                c = Convert.ToDouble(Console.ReadLine());
                s.calc(a,b,c);
                break;
            case 2:
                // Area of circle
                double r;
                Console.Write("Enter the value of r: ");
                r = Convert.ToDouble(Console.ReadLine());
                s.calc(r);
                break;
            case 3:
                // Pythagoras Theorm: Hypothenus
                Console.WriteLine("According to Pythagoras Theorm: C^2 = A^2 + B^2");
                double e,f;
                Console.Write("Enter the value of a: ");
                e = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the value of b: ");
                f = Convert.ToDouble(Console.ReadLine());
                s.calc(e,f);
                break;
            default:
                Console.WriteLine("Invalid Option");
                break;
         }
         
      }
   }
}