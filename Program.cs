using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
       { // (a)
      int n = 22/8;
      Console.WriteLine(n);
      Console.ReadLine();
       }

       { // (b)
    int n = ((99/8) + (21/11) * 7);
    Console.WriteLine(n);
    Console.ReadLine();
       }

       {// (c)
    int a = 4 , b = 3, p = 8, q = 2;
    double n = ((q/a) -(p/p));
    Console.WriteLine(n);
    Console. ReadLine();
       }
       
       {// (d)
    int a = 6, b= 3 , p= 8, q= 2;
    double n = p/a + q/b;
    Console.WriteLine(n);
    Console.ReadLine();
       }

       {
           //(e)
    double a = 3.3, b = 2.7 , p = 8.7, q = 5.4;
    double n = p/b + q/a;
    Console. WriteLine(n);
    Console.ReadLine();
       }

       {
           // (f)
    int n = 11 + 7/4 + 98% 6*3;
    Console.WriteLine(n);
    Console.ReadLine();
       } 
       {
           // (g)
    int n = 11/31%8*5-12;
    Console.WriteLine(n);
    Console.ReadLine();
       }
       {
           // (h)
    double p = 8;
    int q = 5 ;
    double n = q * p + 3* p* p- (q%3)* p*p*p;
    Console.WriteLine(n);
    Console.ReadLine();
       }
       {
           // (i)
    double p =5;
    int q = 9;
    int n = (q%2)*p+6*p(q%3)+(q%4)*p*p*p;
    Console.WriteLine(n);
    Console.ReadLine();
       }
       {
           // (j)
    int n =3, a= 6, b= 2;
    n*=a + b ;
    a--;
    n%=a;
    Console. WriteLine(n);
    Console.WriteLine(a--);
    Console.WriteLine(a);
    Console.ReadLine();
       }
       { 
           // (k)
    int a, n=5; ++n;
    a= --n ;
    n= n-a;
    Console.WriteLine(n);
    Console.ReadLine();
       }

     }
  }
}