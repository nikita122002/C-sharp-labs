
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //uncomment if you need to enter a period instead of a comma
            // System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            double a =0,b = 0, c = 0, d = 0,  x1 = 0,x2 = 0,x3 = 0,dis=0;
            Console.WriteLine("General view of the equation of the 3rd degree: ax^3+bx^2+cx+d");
            while (true)
            {
                try
                {
                    //input and output of the coefficients of the equation of the 3rd degree
                    Console.Write("Enter the coefficients of the equation of the 3rd degree: a= ", a);
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Enter the coefficients of the equation of the 3rd degree: b= ", b);
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Enter the coefficients of the equation of the 3rd degree: c= ", c);
                    c = double.Parse(Console.ReadLine());
                    Console.Write("Enter the coefficients of the equation of the 3rd degree: d= ", d);
                    d = double.Parse(Console.ReadLine());
                    if (a == 0)
                    {
                        Console.WriteLine("Сoefficient A can not be zero, because it will not be a 3-degree equation");
                        Console.ReadKey();
                        break;
                    }
                   // solution of the equation for d=0
                       if (d == 0)
                    {
                                               
                           x1 = 0; 
                              if((b*b-4*a*c)<0)
                              {
                                dis = -(b * b - 4 * a * c);
                              }
                        double discriminant1 = Math.Sqrt(b * b - 4 * a * c);
                           if (discriminant1 >= 0)
                           {
                                x2 = ((-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a);
                                x3 = ((-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a);
                                 Console.WriteLine("root of the equation x1:{0}",Math.Round( x1,1));
                                 Console.WriteLine("root of the equation x2:{0}", Math.Round(x2, 1));                           
                                 Console.WriteLine("root of the equation x3:{0}", Math.Round(x3, 1));                          
                           }
                            else
                           {
                                double discriminant2 = Math.Sqrt(dis);                          
                                 Console.WriteLine("root of the equation x1:{0}", x1);
                                 Console.WriteLine("root of the equation x2:{0}", (-b+"+"+ Math.Round(discriminant2, 1) +"i")+"/"+(2*a));
                                 Console.WriteLine("root of the equation x2:{0:f3}", (-b + "-" +  Math.Round( discriminant2,1) + "i") + "/" + (2 * a));
                            }

                    }
                    // solution of the equation for d!=0 with using the cardano method
                    else
                    {
                        int type = 0;
                        double p1 = 0, p2 = 0, p3 = 0;
                        Kardano( ref type, ref p1, ref p2, ref p3);
                        if (type == 1)
                            Console.WriteLine("type=1.One real and two complex conjugate roots: x1={0} Re[x2,x3]={1} Im[x2,x3]={2}", Math.Round(p1, 1), Math.Round(p2, 1), Math.Round(p3, 1));
                        else
                            Console.WriteLine("Real roots: type={0} p1={1} p2={2} p3={3}", type, Math.Round(p1, 1), Math.Round(p2, 1), Math.Round(p3, 1));
                           Console.ReadKey();
                    }
                       void Kardano  (ref int type, ref double p1, ref double p2, ref double p3)
                       {
                          double eps = 1E-14;
                           double p = (3 * a * c - b * b) / (3 * a * a);
                           double q = (2 * b * b * b - 9 * a * b * c + 27 * a * a * d) / (27 * a * a * a);
                            double det = q * q / 4 + p * p * p / 27;
                        if (Math.Abs(det) < eps)
                            det = 0;
                        if (det > 0)
                        {
                            type = 1; // one real, two complex roots
                            double u = -q / 2 + Math.Sqrt(det);
                            u = Math.Exp(Math.Log(u) / 3);
                            double yy = u - p / (3 * u);
                            p1 = yy - b / (3 * a); //first root
                            p2 = -(u - p / (3 * u)) / 2 - b / (3 * a);
                            p3 = Math.Sqrt(3) / 2 * (u + p / (3 * u));
                        }
                        else
                        {
                            if (det < 0)
                            {
                                type = 2; // three real roots
                                double fi;
                                if (Math.Abs(q) < eps) // q=0
                                    fi = Math.PI / 2;
                                  else
                                  {
                                    if (q < 0) // q<0
                                        fi = Math.Atan(Math.Sqrt(-det) / (-q / 2));
                                           else // q<0
                                             fi = Math.Atan(Math.Sqrt(-det) / (-q / 2)) + Math.PI;
                                  }
                                double r = 2 * Math.Sqrt(-p / 3);
                                p1 = r * Math.Cos(fi / 3) - b / (3 * a);
                                p2 = r * Math.Cos((fi + 2 * Math.PI) / 3) - b / (3 * a);
                                p3 = r * Math.Cos((fi + 4 * Math.PI) / 3) - b / (3 * a);
                            }
                             else // det=0
                             {
                                if (Math.Abs(q) < eps)
                                {
                                    type = 4; // three-fold 
                                    p1 = -b / (3 * a); // three-fold
                                    p2 = -b / (3 * a);
                                    p3 = -b / (3 * a);
                                }
                                  else
                                  {
                                    type = 3; // one and two multiples
                                    double u = Math.Exp(Math.Log(Math.Abs(q) / 2) / 3);
                                       if (q < 0)
                                        u = -u;
                                        p1 = -2 * u - b / (3 * a);
                                        p2 = u - b / (3 * a);
                                        p3 = u - b / (3 * a);
                                  }
                             }
                        }
                       } // end Kardano
                    Console.ReadKey();
                    break;
                }

                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    Console.ReadKey();
                    break;
                   
                }
            }

        }
    }
}