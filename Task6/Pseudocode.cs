//Create a program that calculates the state and local sales tax on an order. The user should be asked what the order total was. The tax calculation should be done using a module and the tax percentage passed in. State tax is 5% and local tax is 3%. Output to the screen the subtotal, the taxes amounts and the grand total.

//setup
double orderTotal;
double stateTax = 0.03;
double stateTaxAmount; // 3% of order total
double localTax = 0.05;
double localTaxAmount; //5% of order total
double grandTotal = 0.00; //order total plus stat and local tax amount
string continueAnswer = "Y"; //repeat code or close program



//process

module CalculateTax(double orderTotal, double stateTaxAmount, double localTaxAmount)
    {
    double stateTax = 0.03;
    double localTax = 0.05;
        stateTaxAmount = orderTotal * stateTax;
        localTaxAmount = orderTotal * localTax;
        grandTotal = orderTotal + stateTaxAmount + localTaxAmount;

    return (stateTaxAmount, localTaxAmount, grandTotal);
}



    do
	{
        //input
        PUT "What is your order total?"
        GET orderTotal;

        //process call
        CalculateTax(orderTotal, stateTaxAmount, localTaxAmount);

        //output
        PUT "Your order subtotal is " + ordertotal + " with a state tax of " + stateTaxAmount + ", a local tax of " + localTaxAmount + ", and a grand total of $" + grandTotal;

        PUT "Do you wish to calculate another order? (Y)es or (N)o"
	} while (continueAnswer = "Y"); // use .ToUpper

