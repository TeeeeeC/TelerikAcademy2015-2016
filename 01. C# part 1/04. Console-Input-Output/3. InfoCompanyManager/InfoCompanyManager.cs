using System;

class InfoCompanyManager
{
    static void Main()
    {
        /*
         Problem 2. Print Company Information
            A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
            Write a program that reads the information about a company and its manager and prints it back on the console.
         */
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string address = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string website = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Company Info");
        Console.WriteLine("Company name: {0}", companyName);
        Console.WriteLine("Company address: {0}", address);
        Console.WriteLine("Phone number: {0}", phoneNumber);

        short codeFax = 0;

        if (short.TryParse(faxNumber, out codeFax))
        {
            Console.WriteLine("Fax number: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax number: {0}", faxNumber);
        }

        Console.WriteLine("Web site: {0}", website);
        Console.WriteLine();
        Console.WriteLine("Manager Info");
        Console.WriteLine("Manager first name: {0}", managerFirstName);
        Console.WriteLine("Manager last name: {0}", managerLastName);
        Console.WriteLine("Manager age: {0}", managerAge);
        Console.WriteLine("Manager phone: {0}", managerPhoneNumber);
    }
}

