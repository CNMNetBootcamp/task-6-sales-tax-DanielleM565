using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup
            string continueAnswer = "Y"; //repeat code or close program
            string textType; //basically response

            //input
            do
            {
                //process
                textType = CalculateTax();

                //output
                Console.WriteLine(textType);
                
                Console.WriteLine("Do you wish to calculate another order? (Y)es or (N)o");
                continueAnswer = Console.ReadLine();

            } while (continueAnswer.ToUpper() == "Y"); 
 
        }
        public static string CalculateTax()
        {
            //TODO: Initialize all your variables
            double orderTotal;
            double stateTax = 0.03; //magic number
            double localTax = 0.05; //magic number
            double grandTotal = 0.00; //order total plus state and local tax amount
            string response;

            do
            {
                Console.WriteLine("What is your order total?");
            } while (!Double.TryParse(Console.ReadLine(), out orderTotal));
            //TODO: These variables are confusing. You already declared similar types above
            // Distinguish between them and what makes them different. Context is very difficult to code to.
            //Yea I thought that was kind of redundant too

            stateTax = orderTotal * stateTax;
            localTax = orderTotal * localTax;
            grandTotal = orderTotal + stateTax + localTax;

            response = "Your order subtotal is " + orderTotal + " with an added state tax of " + stateTax + ", and a local added tax of " + localTax + ", making the grand total of $" + grandTotal;

            return (response);
        }
    }
}

