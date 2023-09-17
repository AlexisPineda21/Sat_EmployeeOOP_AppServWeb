﻿// See https://aka.ms/new-console-template for more information
using EmployeeOPP.Classes;
using System;

try
{
    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");

    int day, month, year;
    string firstName;
    string lastName;
    decimal salary;

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización clase Date
    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

    Console.Write("Ingresar Nombre completo: ");
    firstName = Console.ReadLine();

    Console.Write("Ingresar Apellidos: ");
    lastName = Console.ReadLine();

    Console.Write("Ingresar Salario devengado: ");
    salary = Decimal.Parse(Console.ReadLine());


    //HardCoding = Quemar código

    SalaryEmployee salaryEmployee = new SalaryEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = salary
    };


    Console.WriteLine(salaryEmployee);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


