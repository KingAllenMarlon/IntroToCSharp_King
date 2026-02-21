/*
 * Prelim Activity 01: Codac Logistics Delivery & Fuel Auditor
 * Name: Allen Marlon King

 */

using System;

class Program
{
    static void Main()
    {
        // ---------------- TASK 1: DRIVER PROFILE ----------------

        // string is used for name because it stores text
        Console.Write("Enter Driver's Full Name: ");
        string driverName = Console.ReadLine();

        // decimal is used for money to ensure financial precision
        Console.Write("Enter Weekly Fuel Budget: ");
        decimal weeklyBudget = Convert.ToDecimal(Console.ReadLine());

        // double is used for distance because it allows decimal values
        double totalDistance = 0;

        // while loop ensures validation until correct value is entered
        while (true)
        {
            Console.Write("Enter Total Distance Traveled (1.0 - 5000.0 km): ");
            totalDistance = Convert.ToDouble(Console.ReadLine());

            if (totalDistance >= 1.0 && totalDistance <= 5000.0)
                break;
            else
                Console.WriteLine("Invalid distance. Please enter between 1.0 and 5000.0.");
        }

        // ---------------- TASK 2: FUEL EXPENSE TRACKING ----------------

        // 1D array to store 5 days of fuel expenses
        decimal[] fuelExpenses = new decimal[5];
        decimal totalFuelSpent = 0;

        // for loop processes 5 days automatically
        for (int i = 0; i < fuelExpenses.Length; i++)
        {
            Console.Write($"Enter fuel expense for Day {i + 1}: ");
            fuelExpenses[i] = Convert.ToDecimal(Console.ReadLine());

            // accumulate total fuel spent
            totalFuelSpent += fuelExpenses[i];
        }

        // ---------------- TASK 3: PERFORMANCE ANALYSIS ----------------

        // Calculate average
        decimal averageDailyExpense = totalFuelSpent / fuelExpenses.Length;

        // Convert decimal to double for efficiency calculation
        double totalFuelDouble = (double)totalFuelSpent;
        double efficiency = totalDistance / totalFuelDouble;

        string efficiencyRating;

        if (efficiency > 15)
            efficiencyRating = "High Efficiency";
        else if (efficiency >= 10)
            efficiencyRating = "Standard Efficiency";
        else
            efficiencyRating = "Low Efficiency / Maintenance Required";

        // Budget comparison
        bool isUnderBudget = totalFuelSpent <= weeklyBudget;

        // ---------------- TASK 4: AUDIT REPORT ----------------

        Console.WriteLine("\n===== CODAC LOGISTICS WEEKLY AUDIT REPORT =====");
        Console.WriteLine($"Driver Name: {driverName}");
        Console.WriteLine("\nFuel Expenses Breakdown:");

        for (int i = 0; i < fuelExpenses.Length; i++)
        {
            Console.WriteLine($"Day {i + 1}: P{fuelExpenses[i]}");
        }

        Console.WriteLine($"\nTotal Fuel Spent: P{totalFuelSpent}");
        Console.WriteLine($"Average Daily Expense: P{averageDailyExpense}");
        Console.WriteLine($"Fuel Efficiency Rating: {efficiencyRating}");
        Console.WriteLine($"Stayed Under Budget: {isUnderBudget}");
    }
}