/*
Name: Xavier Nazario
COP2360 - Assignment 4
Aug. 29, 2024
Collaboration Statement: I watched a video on Youtube and the
Beginner's Guide to Console Input in C# material provided.
I watched a video because I needed more visual examples of exception handling
to make the code appear cleaner, the video I watched was,
C# exception handling, by the channel Bro Code.
*/
using System.Linq.Expressions;

namespace PhoneBook;

using System;
using System.IO;
class Program
{
    // Multiple Programs to reflect exception handling
    // Main Structure
    static void Main(string [] args)
    {
        // Create .txt named ./phonebook
        // Use filePath string
        // Use int for menu display choice
        const string filePath = "./phonebook.txt";
        int choice;

        // do Statement for menu options
        // Use switch Statement for user choices
        // DON'T FORGET SENTINEL VALUE (-1) for loop exit
        // Display header for names and numbers viewing (extra mile)
        do
        {
            // Display menu
            // !!!!3!!!!! options, sent value is MUST
            Console.WriteLine("Phone Book Application");
            Console.WriteLine("1. Add New Contact");
            Console.WriteLine("2. View All Contacts");
            Console.WriteLine("-1. Exit");
            Console.Write("Enter your choice: ");

            // Convert user string input to int
            // Declare choice
            choice = int.Parse(Console.ReadLine());

            // switch Statement user choices
            // **Need break statements in switch**
            // filePath for .txt file edits
            switch (choice)
            {
                // Declare AddContact and ViewContacts
                // filePath programs addressed below
                // NOT ERRORS
                case 1:
                    AddContact(filePath);
                    break;
                case 2:
                    ViewContacts(filePath);
                    break;
                case -1:
                    Console.WriteLine("Exiting the application.");
                    break;
                // Bad input
                default:
                    Console.WriteLine("Please enter 1, 2, or -1.");
                    break;
            }

            Console.WriteLine();

            // while Statement to keep loop running
            // SENT value ends (-1)
        } while (choice != -1);
    }

    // AddContact and ViewContacts programs
    // static void var(string filePath)
    static void AddContact(string filePath)
    {
        // Write to file
        // Prompt user for contact information
        // Declare name and phoneNumber
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Phone Number: ");
        string phoneNumber = Console.ReadLine();

        // exception handling
        // try
        // Use StreamWriter
        try
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{name}\t{phoneNumber}");
            }

            Console.WriteLine("Contact added to phonebook.");
        }
        // catch exception
        catch (Exception)
        {
            Console.WriteLine($"An error occured. Please try again.");
        }
    }

    static void ViewContacts(string filePath)
    {
        // Check for file
        // nest if Statement in try block
        try
        {
            if (File.Exists(filePath))
            {
                // Display header
                // Make border
                Console.WriteLine("Name\tPhone Number");
                Console.WriteLine("------------------------");

                // Display contacts
                // Use StreamReader
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    // Use while Statement
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            // If does not exist
            else
            {
                Console.WriteLine("Phonebook is empty.");
            }
        }
        // catch exception
        catch (Exception)
        {
            Console.WriteLine($"An error occured. Please try again.");
        }
    }
}