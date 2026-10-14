/*
* Name: Chase Ries
* Course: CSCI 1250, Section 001
* Assignment: Lab 04, The Group Trip
* Date: October 7, 2026
* Description: Rebuilds the trip calculator with methods and arrays 
so it reports on a whole group instead of one person
*/
using System;
class Program
{
    static void Main()
    {
       const int slicesPerPizza = 8;
       const double taxRate = 0.18;

       Console.WriteLine("=== Part1: Road Trip ===");
       Console.Write("What was the round trip in miles?");
       double milesForTheTrip = double.Parse(Console.ReadLine());
       Console.Write ("What is the miles per gallon of the car you are using? ");
       double milesPerGallon = double.Parse(Console.ReadLine());
       Console.Write("Price per gallon: ");
       double priceperGallon = double.Parse(Console.ReadLine());

       double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;
       double fuelCost = gallonsNeeded * priceperGallon;

       Console.WriteLine();
       Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
       Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));
       Console.WriteLine();

       Console.WriteLine("=== Part 2: Pizza party ===");
       Console.WriteLine("How many people are going? ");
       int howManyPeopleGoing = int.Parse(Console.ReadLine());
       Console.WriteLine("How many pizzas? ");
       int howManyPizzas = int.Parse(Console.ReadLine());
       Console.WriteLine("What is the price per Pizza? ");
       double pricePerPizza = double.Parse(Console.ReadLine());

       int totalSlices = howManyPizzas * slicesPerPizza;
       double slicesPerPerson = (double)totalSlices / howManyPeopleGoing;
       double pizzaCost = howManyPizzas * pricePerPizza;

       Console.WriteLine();
       Console.WriteLine("Total Slices " + totalSlices);
       Console.WriteLine("Slices per person " + slicesPerPerson.ToString("F1"));
       Console.WriteLine("Pizza cost" + pizzaCost.ToString("C"));
       Console.WriteLine();

       Console.WriteLine("=== Part 3: Paycheck ===");
       Console.WriteLine("What are the hourly hours worked this week? ");
       double hourlyWorked = double.Parse(Console.ReadLine());
       Console.WriteLine("What is the hourly rate? ");
       double hourlyRate = double.Parse(Console.ReadLine());

       double grossPay = hourlyWorked * hourlyRate;
       double taxWithheld = grossPay * taxRate;
       double takeHomepay = grossPay - taxWithheld;

       Console.WriteLine();
       Console.WriteLine("Gross pay " + grossPay.ToString("C"));
       Console.WriteLine("Tax withheld " + taxWithheld.ToString("C"));
       Console.WriteLine("Take home pay " + takeHomepay.ToString("C"));
       Console.WriteLine();

       Console.WriteLine("=== Part 4: The whole trip ===");
       double tripTotal = fuelCost + pizzaCost;
       double costPerPerson = tripTotal/howManyPeopleGoing;
       double takeHomepayPerHour = takeHomepay/hourlyWorked;
       double hoursMustWorked = costPerPerson/takeHomepayPerHour;

       Console.WriteLine("tripTotal " + tripTotal.ToString("C"));
       Console.WriteLine("Cost Per person " + costPerPerson.ToString("C"));
       Console.WriteLine("Take Home Pay per Hour" + takeHomepayPerHour.ToString("C"));
       Console.WriteLine("Hours you must work " + hoursMustWorked.ToString("F2"));
    }
}