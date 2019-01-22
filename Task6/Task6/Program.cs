using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup
            string continueAnswer = "Y"; //repeat code or close program
            string textType;

            //input
            do
            {
                //input

                //process
                textType = CalculateTax();

                //output
                Console.WriteLine(textType);

                Console.WriteLine("Do you wish to calculate another order? (Y)es or (N)o");
                continueAnswer = Console.ReadLine();
                

            } while (continueAnswer == "Y"); // use .ToUpper

             
        }
        public static string CalculateTax()
        {
            double orderTotal;
            double stateTax = 0.03;
            double localTax = 0.05;
            double grandTotal = 0.00; //order total plus stat and local tax amount
            string response;

            do
            {
                Console.WriteLine("What is your order total?");
            } while (!Double.TryParse(Console.ReadLine(), out orderTotal));

            double stateTaxAmount; // 3% of order total
            double localTaxAmount; //5% of order total

            stateTaxAmount = orderTotal * stateTax;
            localTaxAmount = orderTotal * localTax;
            grandTotal = orderTotal + stateTaxAmount + localTaxAmount;

            response = "Your order subtotal is " + orderTotal + " with a state tax of " + stateTaxAmount + ", a local tax of " + localTaxAmount + ", and a grand total of $" + grandTotal;

            return (response);
        }
    }
}

