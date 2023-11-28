// See https://aka.ms/new-console-template for more information
using Implicit_Explicit_OperatorOverloading_Nullable.Models;

Console.WriteLine("Hello, World!");
Celcius celcius = new(1280);
Kelvin kelvin = celcius;
Console.WriteLine(kelvin.Degree);
Employee employee = new Employee();
employee.ShowingHowManyEmployeesMeetRequirements(new DateTime(2002, 2, 12), new DateTime(2009, 2, 12),2000);
Console.WriteLine(employee.ShowingHowManyEmployeesMeetRequirements(new DateTime(2002, 2, 12), new DateTime(2009, 2, 12), 2000));