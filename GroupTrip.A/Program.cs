/*
* Name: Chase Ries
* Course: CSCI 1250, Section 001
* Assignment: Lab 04, The Group Trip
* Date: October 7, 2026
* Description: Rebuilds the trip calculator with methods and arrays 
so it reports on a whole group instead of one person
*/

Console.WriteLine("=== Part 1: The Trip ===");

Console.Write("How many pizzas? ");
double howManyPizzas = Convert.ToDouble(Console.ReadLine());

Console.Write("Price per pizza: ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

double fuel = FuelCost(260, 28, 2.89);
double pizzaCost = howManyPizzas * pricePerPizza;
double tripTotal = fuel + pizzaCost;

Console.WriteLine(" ");
Console.WriteLine("Fuel Cost: " + fuel.ToString("C"));
Console.WriteLine("Pizza Cost " + pizzaCost.ToString("C"));
Console.WriteLine("Trip Total " + tripTotal.ToString("C"));
Console.WriteLine(" ");

Console.WriteLine("=== Part 2: The Group ===");

const int slicesPerPizza = 8;

string[] names = {"Ada", "Grace", "Alan", "Katherine" };
double[] hourlyWorked = { 22, 15, 30, 18};
double[] hourlyRate = { 13.50, 16.00, 11.20, 14.80 };

double totalSlices = howManyPizzas * slicesPerPizza;
double slicesPerPerson = totalSlices / names.Length;
double costPerPerson = tripTotal / names.Length;

Console.WriteLine("People Going: " + names.Length);
Console.WriteLine("Slices each: " + slicesPerPerson.ToString("F1"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
Console.WriteLine(" ");

Console.WriteLine("=== Part 3: Who works how long ===");

for (int i = 0; i < names.Length; i++)
{
    
     double takeHomepayPerHour = TakeHomePay( hourlyWorked[i], hourlyRate[2], 0.18)/ hourlyWorked[i];
    ;double rateMinusTax = TakeHomePay(hourlyWorked[i], hourlyRate[i], 0.18) / hourlyWorked[i];
     ;Console.WriteLine(names[i] + ": takes home " + TakeHomePay( hourlyWorked[i], hourlyRate[i], 0.18).ToString("C") + " for " + hourlyWorked[i] + " hours, " + rateMinusTax.ToString("C") + " per hour, must work " + HoursToCover(costPerPerson, takeHomepayPerHour).ToString("F2") + " hours");
}

double takeHomepay = TakeHomePay( hourlyWorked[2], hourlyRate[2], 0.18) / hourlyWorked[2];
double totalHours = hourlyWorked[0] + hourlyWorked[1] + hourlyWorked[2] + hourlyWorked[3];
double totalPay = TakeHomePay(hourlyWorked[0], hourlyRate[0], 0.18) + TakeHomePay(hourlyWorked[1], hourlyRate[1], 0.18) + TakeHomePay(hourlyWorked[2], hourlyRate[2], 0.18) + TakeHomePay(hourlyWorked[3], hourlyRate[3], 0.18);

Console.WriteLine(" ");
Console.WriteLine("Total hours worked " + totalHours);
Console.WriteLine("Total take home pay: " + totalPay.ToString("C"));
Console.WriteLine("Longest anyone must work: " + HoursToCover(costPerPerson, takeHomePayPerHour).ToString("F2"));



static double FuelCost(double milesForTheTrip, double milesPerGallon, double pricePerGallon)
{
double gallons = milesForTheTrip / milesPerGallon;
return gallons * pricePerGallon;
}


static double TakeHomePay(double hourlyWorked, double hourlyRate, double taxRate)
{
double grossPay = hourlyWorked * hourlyRate;
double taxWithheld = grossPay * taxRate;
return grossPay - taxWithheld;

}


static double HoursToCover(double costPerPerson, double takeHomePerHour)
{
return costPerPerson / takeHomePerHour;
}
