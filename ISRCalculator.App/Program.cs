using System;
using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Enums;
using ISRCalculator.Core.Services;
using ISRCalculator.Core.Managers;

namespace MyCompany.Intranet.Console;

public static class Program{
    public static void Main(string[] args)
    {
        float salary = 0;

        System.Console.WriteLine("Please enter Salary");
        Single.TryParse(System.Console.ReadLine(), out salary);

        var user = new User{Salary = salary};

        var service = new ISRService();
        var manager = new ISRManagers(service);
        
        ISR isr = manager.GetISR(user);

        System.Console.WriteLine($"ISR is of {isr.index} typeof {isr.ISRType}");
    }
}
