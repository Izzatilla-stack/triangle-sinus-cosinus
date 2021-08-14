using System;

namespace sin_cos
{
    class Program
    {


        static void Sinus(double a, double b , double c)
        {
            if (a <= 30)
            {
                double sin_30 = (a / 2) / a;
                Console.WriteLine("sin 1..30 : "+ sin_30);

            }
            if (b <= 30)
            {
                double sin_30 = (b / 2) / b;
                Console.WriteLine("sinus  1..30 : " + sin_30);
            }
            if (c<=30)
            {
                double sin_30 = (c / 2) / c;
                Console.WriteLine("sinus  1..30 : " + sin_30);
            }

            //45 degreeeeeee

            if (a>=31 && a <= 45 )
            {
                double sin_45 = a / a * Math.Sqrt(2);
                Console.WriteLine("sinus  30..45 : " + sin_45);

            }
            if (b >= 31 && b <= 45)
            {
                double sin_45 = b / b * Math.Sqrt(2);
                Console.WriteLine("sinus 30..45 : " + sin_45);

            }
            if (c >= 31 && c <= 45)
            {
                double sin_45 = c / c * Math.Sqrt(2);
                Console.WriteLine("sinus 30..45 : " + sin_45);

            }

            //60 degrreee
            if (a >= 45 && a <= 60 )
            {
                double sin_60 = a / a * Math.Sqrt(3) / 2;
                Console.WriteLine("sinus 45..60 : " + sin_60);

            }

            if (b >= 45 && b <= 60)
            {
                double sin_60 = b / b * Math.Sqrt(3) / 2;
                Console.WriteLine("sinus 45..60 : " + sin_60);

            }
            if (c >= 45 && c <= 60)
            {
                double sin_60 = c / c * Math.Sqrt(3) / 2;
                Console.WriteLine("sinus 45..60 : " + sin_60);

            }

            //90 degreee

            if (a >= 60 && a <= 90 )
            {
                double sin_90 = a / a;
                Console.WriteLine("sinus 60..90 : " + sin_90);

            }
            if (b >= 60 && b <= 90)
            {
                double sin_90 = b / b;
                Console.WriteLine("sinus 60..90 : " + sin_90);

            }
            if (c >=60 && c <= 90)
            {
                 
                double sin_90 = c / c;
                Console.WriteLine("sinus 60..90 : " + sin_90);

            }

            double sin_angle = (a - b / c) * Math.Sqrt(a) /2 * Math.Sqrt(b) ;
            double area = a * b / 2;
            double law_area = 2 / b * c * Math.Sqrt((area))*Math.Sqrt(area-a) * Math.Sqrt(area - b) * Math.Sqrt(area - c);
            

            Console.WriteLine("sinus angle : "+sin_angle);
            Console.WriteLine("sinus area : "+area);
            Console.WriteLine("law area of sinus : "+law_area);
        }

       static void Cosinus(double a_cos, double b_cos )
        {
            //double a_cos = Convert.ToDouble(Console.ReadLine());
            //double b_cos= Convert.ToDouble(Console.ReadLine());

            double cos = a_cos + b_cos / 2 * Math.Sqrt(3)- a_cos - b_cos / 2 / Math.Sqrt(2);
            double cos_angle = a_cos * a_cos * Math.Sqrt(a_cos + b_cos * 0.5 * Math.Sqrt(3) / 2);

            Console.WriteLine(cos);
            Console.WriteLine(cos_angle);
        }

        static void Ctg ( double a_ctg , double b_ctg)
        {
            double ctg = a_ctg + b_ctg / Math.Sqrt(3) / 2 * a_ctg;
            double ctg_angle = 2 * a_ctg / a_ctg * b_ctg - 1 / 2 * a_ctg / b_ctg - a_ctg / 2;

            Console.WriteLine(ctg);
            Console.WriteLine(ctg_angle);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Trignometric values in Degree");
            Console.WriteLine("sin (60)     = {0}", Math.Sin(60 * Math.PI / 180));
            Console.WriteLine("cos (60)     = {0}", Math.Cos(60 * Math.PI / 180));
            Console.WriteLine("tan (60)     = {0}", Math.Tan(60 * Math.PI / 180));
            Console.WriteLine("arcsin (1/2) = {0}", Math.Asin(0.5) * 180 / Math.PI);
            Console.WriteLine("arccos (1/2) = {0}", Math.Acos(0.5) * 180 / Math.PI);
            Console.WriteLine("arctan (1/2) = {0}", Math.Atan(0.5) * 180 / Math.PI);
            


            Console.WriteLine("Insert a");
            double a = Convert.ToDouble(Console.ReadLine());
            //
            Console.WriteLine("insert b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("insert c");
            double c = Convert.ToDouble(Console.ReadLine());


            if (a >= 180 || b >= 180 || c >= 180)
            {
                Console.WriteLine("SystemOutOfRangeExeption.xs");
            }
            if (a + b + c > 180 || a + b > 180 || a + c > 180)
            {
                Console.WriteLine("SystemOutOfRangeExeption.xs");
            }


            Sinus(a,b,c);


            Console.WriteLine("hey bro now insert Cos a");

            double a_cos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("insert Cos b");
            double b_cos = Convert.ToDouble(Console.ReadLine());

            Cosinus(a_cos, b_cos);


            Console.WriteLine("insert ctg a ");
            double a_ctg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("insert ctg b");
            double b_ctg = Convert.ToDouble(Console.ReadLine());

            Ctg(a_ctg, b_ctg);



            
            Triangle();
        }
        
        static void Triangle ()
        {
            int val = 5;
            int i, j, k;
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }

    }
}
