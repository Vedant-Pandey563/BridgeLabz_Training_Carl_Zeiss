namespace CalculatorApp
{
    public class Calculator
    {
        public int Add(int a, int b) 
        {
            checked
            {
                return a + b;
            }
        }        
        public long Add(long a, long b)
        {
            checked
            {
                return a + b;
            }
        }

        public int Multiply(int a, int b)
        {
            checked
            {
                return a * b;
            }
        }
        public long Multiply(long a, long b)
        {
            checked
            {
                return a * b;
            }
        }


        public int Subtract(int a, int b)
        {
            if (a < b)
            {
                throw new ArgumentException("a must be greater than b");
            }
            return a - b;
        }
        public long Subtract(long a, long b)
        {
            if (a < b)
            {
                throw new ArgumentException("a must be greater than b");
            }
            return a - b;
        }

        public int Divide(int a, int b)
        {
            if(b == 0)
            {
                throw new DivideByZeroException("Denominator cant be 0");
            }

            return a / b;
        }
        public long Divide(long a, long b)
        {
            if(b == 0)
            {
                throw new DivideByZeroException("Denominator cant be 0");
            }

            return a / b;
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
