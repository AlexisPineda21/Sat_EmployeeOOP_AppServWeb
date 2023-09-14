// See https://aka.ms/new-console-template for more information
using EmployeeOPP.Classes;

try
{
    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");

    int day, month, year;

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

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


