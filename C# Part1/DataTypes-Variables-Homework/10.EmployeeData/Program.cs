using System;

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)

class Program
{
    static void Main(string[] args)
    {
        string firstName;
        string secondName;

        // 0 - 100 , byte is most approppriate
        byte age;

        // 'm' or 'f'
        char gender;

        // it wouldn't be used in calculations , so string is the best option
        string idNumber;

        // It might be used in calculations( for example in a loop to print all employee's information)
        int employeeNumber;
    }
}