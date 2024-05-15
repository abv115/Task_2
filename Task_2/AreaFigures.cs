using System.Security.Principal;

namespace Task_2
{
    public abstract class Figure
    {
        public Figure(string FigureName) 
        {
            this.FigureName = FigureName;
        }
        public Figure(string FigureName, double[] SideLengths) 
        {
            this.FigureName = FigureName;
            Array.Resize(ref this.SideLengths, SideLengths.Length);
            this.SideLengths = SideLengths;
        }
        private string FigureName = "Unknown";
        private double[] SideLengths = new double[1];
        public double P,S;
        public void PrintInfo()
        {
            Console.WriteLine($"name = {FigureName} \n Col-vo storon = {SideLengths.Length}");
        }
    }
    public class Triangle:Figure
    {
        public bool DataTriangleChecking(double a, double b, double c)
        {
            if (a>0 && b>0 && c>0)
            {
                if (Math.Max(Math.Max(a, b), c)==a)
                {
                    if (a>b+c) { throw new Exception("Данная фигура не является треугольником, т.к. сумма длин меньших сторон('b' и 'c') меньше большей стороны('a')."); }
                }
                else if (Math.Max(Math.Max(a, b), c)==b)
                {
                    if (b>a+c) { throw new Exception("Данная фигура не является треугольником, т.к. сумма длин меньших сторон('a' и 'c') меньше большей стороны('b')."); }
                }
                else
                {
                    if (c>a+b) { throw new Exception("Данная фигура не является треугольником, т.к. сумма длин меньших сторон('a' и 'b') меньше большей стороны('c')."); }
                }
                return true;
            }
            else { throw new Exception("Длины сторон треугольника должны быть больше нуля."); }
        }
        public Triangle() : base("Triangle") { }
        public Triangle(double a, double b, double c): base("Triangle")
        {
            if(DataTriangleChecking(a, b, c))
            {
                this.a = a; this.b = b; this.c = c;
            }           
        }
        private double a;
        private double b;
        private double c;
        public double AreaOfTriangle()
        {
            P = (a+b+c)/2;
            S = Math.Sqrt(P*(P-a)*(P-b)*(P-c));
            return S;
            //Console.WriteLine($"Площадь треугольника : {S:F3}");
            //Console.ReadKey();
        }
        public double AreaOfTriangle(double a,double b,double c)
        {
            if(DataTriangleChecking(a,b,c))
            {
                P = (a+b+c)/2;
                S = Math.Sqrt(P*(P-a)*(P-b)*(P-c));
            }
            return S;
            //Console.WriteLine($"Площадь треугольника : {S:F3}");
            //Console.ReadKey();
        }
        public bool IsRecTangular(double a,double b,double c) 
        {
            if (Math.Max(Math.Max(a, b), c)==a)
            {
                if (a>b+c) { throw new Exception("Данная фигура не является треугольником, т.к. сумма длин меньших сторон('b' и 'c') меньше большей стороны('a')."); }
                else {
                    if (a>0 && b>0 && c>0)
                    {
                        if (a*a==b*b+c*c) { return true; }
                        else { return false; }
                    }
                    else { throw new Exception("Длины сторон треугольника должны быть больше нуля."); }
                    }
            }
            else if (Math.Max(Math.Max(a, b), c)==b)
            {
                if (b>a+c) { throw new Exception("Данная фигура не является треугольником, т.к. сумма длин меньших сторон('a' и 'c') меньше большей стороны('b')."); }
                else
                {
                    if (a>0 && b>0 && c>0)
                    {
                        if (b*b==a*a+c*c) { return true; }
                        else { return false; }
                    }
                    else { throw new Exception("Длины сторон треугольника должны быть больше нуля."); }
                }
            }
            else
            {
                if (c>a+b) { throw new Exception("Данная фигура не является треугольником, т.к. сумма длин меньших сторон('a' и 'b') меньше большей стороны('c')."); }
                else
                {
                    if (a>0 && b>0 && c>0)
                    {
                        if (c*c==a*a+b*b) { return true; }
                        else { return false; }
                    }
                    else { throw new Exception("Длины сторон треугольника должны быть больше нуля."); }
                }
            }          
        }
    }
    public class Circle : Figure
    {
        public Circle():base("Circle") { }
        public Circle(double R):base("Circle")
        {
            if(R>0) 
            {
                this.R = R;
            }
            else { throw new Exception("Длина радиуса окружности должна быть больше нуля."); }
            
        }
        private double R;
        public double AreaOfCircle() 
        {
            if (R>0)
            {
                S = Math.PI*Math.Pow(R, 2);
            }
            else { throw new Exception("Длина радиуса окружности должна быть больше нуля."); }
            return S;
            //Console.WriteLine($"Площадь круга : {S:F3}");
            //Console.ReadKey();
        }
        public double AreaOfCircle(double R) 
        {
            if (R>0)
            {
                S = Math.PI*Math.Pow(R, 2);
            }
            else { throw new Exception("Длина радиуса окружности должна быть больше нуля."); }
            return S;
            //Console.WriteLine($"Площадь круга : {S:F3}");
            //Console.ReadKey();
        }
    }

}
