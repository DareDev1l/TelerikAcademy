using System;

// A company has name, address, phone number, fax number, web site and manager. The manager has first name,
// last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints it back on the console.

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();


        Console.Write("Web site: ");
        string webSite = Console.ReadLine();


        Console.Write("Manager First name: ");
        string managerFirstName = Console.ReadLine();


        Console.Write("Manager Last Name: ");
        string managerLastName = Console.ReadLine();


        Console.Write("Manager Age: ");
        int managerAge = int.Parse(Console.ReadLine());

        Console.Write("Manager Phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("\n{0} \n{1} \n{2} \n{3} \n{4} \n{5} \n{6} \n{7} \n{8}"
            , companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerAge, managerPhone);

    }
}
