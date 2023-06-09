﻿namespace FinalTask17._6._6
{
    public class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Account accountOrdinaly = new Account() { Interest = 100.00, Balance = 50000.00, Type = "Usually" };
                IUsually ordinaly = accountOrdinaly;
                ordinaly.CalculateInterest();

                Account accountSalary = new Account() { Interest = 1000.00, Balance = 5000.00, Type = "Salary" };
                ISalary salary = accountSalary;
                salary.CalculateInterest();
                //расчет в обычном профиле
                Calculator.CalculateInterest(accountOrdinaly);
                //расчет в зарплатном профиле
                Calculator.CalculateInterest(accountSalary);
            }
        }
    }
}