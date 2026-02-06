using Class_library;

try
{
    var employee1 = new SalaryEmployee
    {
        Id = 1010,
        FirstName = "Juan",
        LastName = "Guisao",
        BornDate = new(2000, 12, 3),
        HireDate = new(2020, 2, 14),
        IsActive = true,
        Salary = 1600000
    };

    var employee2 = new HourlyEmployee
    {
        Id = 2020,
        FirstName = "Juan",
        LastName = "Castro",
        BornDate = new(1998, 12, 3),
        HireDate = new(2010, 2, 14),
        IsActive = true,
        WorkingHour = 123.5f,
        HourValue = 85000
    };

    var employee3 = new CommisionEmployee
    {
        Id = 3030,
        FirstName = "Juan",
        LastName = "Perez",
        BornDate = new(1990, 12, 3),
        HireDate = new(2023, 2, 14),
        IsActive = true,
        CommisionPercentaje = 0.1f,
        Sales = 20000000
    };

    var employee4 = new BaseCommisionEmployee
    {
        Id = 4040,
        FirstName = "Juan",
        LastName = "xxx",
        BornDate = new(1998, 12, 3),
        HireDate = new(2005, 2, 14),
        IsActive = true,
        CommisionPercentaje = 0.025f,
        Sales = 30000000,
        Salary = 620000
    };

    decimal payRoll = 0;
    Employee[] employees = new Employee[] { employee1, employee2, employee3, employee4 };

    foreach (var employee in employees)
    {
        Console.WriteLine(employee);
        payRoll += employee.GetValueToPay();
    }
    Console.WriteLine($"===================================================");
    Console.WriteLine($"TOTAL PAYROL                        {payRoll,20:C2}");

    var invoice1 = new Invoice
    {
        Id = 1234,
        Description = "Papel",
        Quantity = 84,
        Price = 12000
    };

    var invoice2 = new Invoice
    {
        Id = 1235,
        Description = "Cuaderno",
        Quantity = 50,
        Price = 5000
    };

    var invoice3 = new Invoice
    {
        Id = 1236,
        Description = "iPad",
        Quantity = 3,
        Price = 680000
    };

    decimal totalIvoices = 0;
    Invoice[] invoices = new Invoice[] { invoice1, invoice2, invoice3 };

    foreach (var invoice in invoices)
    {
        Console.WriteLine(invoice);
        totalIvoices += invoice.GetValueToPay();
    }
    Console.WriteLine($"===================================================");
    Console.WriteLine($"TOTAL INVOICES                      {payRoll,20:C2}");

    Console.WriteLine($"===================================================");
    Console.WriteLine($"===================================================");
    Console.WriteLine($"GENERAL TOTAL                       {payRoll + totalIvoices,20:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}