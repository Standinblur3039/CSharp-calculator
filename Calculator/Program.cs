using System;


namespace Program
{
    class Program
        
    {
        static void Main(string[] args)
        {
            int x, y;
            
            Console.WriteLine("Enter the value of X and Y:");
             x = Convert.ToInt32(Console.ReadLine());
             y = Convert.ToInt32(Console.ReadLine());

            Myfirstclass calculator = new Myfirstclass();

            int ADD = calculator.add(x, y);
            Console.WriteLine("addition:" + ADD);
            

            Console.WriteLine("Enter the value of X and Y:");
             x = Convert.ToInt32(Console.ReadLine());
             y = Convert.ToInt32(Console.ReadLine());

            int SUB = calculator.sub(x, y);
            Console.WriteLine("subtraction:" + SUB);

            Console.WriteLine("Enter the value of X and Y:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            int MUL = calculator.mul(x, y);
            Console.WriteLine("multiplication:" + MUL);
            

            Console.WriteLine("Enter the value of X and Y:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            float DIV = calculator.div(x, y);
            Console.WriteLine("division:" + DIV);
            Console.Read();






        }
        class Myfirstclass
        {
            public int add(int x, int y)
            {
                return x + y;
            }

            public int sub(int x, int y)
            {
                return x - y;

            }

            public int mul(int x, int y)
            {
                return x * y;
            }

            public float div( float x,float y)
            {
                return  x / y ;
            }

        }
    }
}





