using System.Globalization;

namespace SosimpleProject
{
    class Money
    {
        public double Balance;
        public Money() { Balance = 0; }
        public Money(double balance) {  Balance = balance; }

        public static Money operator +(Money b)
        {
            return new Money() { Balance = +b.Balance };
        }
        public static Money operator -(Money b) 
        {
            if (b.Balance < 0)
            {
                throw new ArgumentOutOfRangeException("Balance cannot be negative.");
            }

            return new Money(-b.Balance);
        }
    }
}