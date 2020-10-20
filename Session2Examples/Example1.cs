using System;

namespace Session2Examples
{

    //////////////////////////////////////////////////////////////////////////////////////////
    // C# Syntax
    //
    // Note:
    // The term method is the same as the term function

    // DO use PascalCasing for class names and method names
    public class ClientActivity
    {
        public void ClearStatistics() {
            //...
        }
        public void CalculateStatistics() {
            //...
        }
    }

    // DO use camelCasing for local variables and method arguments  
    public class UserLog
    {
        public void Add(LogEvent logEvent) {
            int itemCount = logEvent.Items.Count;
            // ...
        }
    }

    // DO NOT use Hungarian notation or any other type identification in identifiers 
    // Hungarian notation is putting an abbreviation of the type in the identifier
    public class HungarianExample
    {
        // Correct
        int counter;
        string name;

        // Avoid
        int iCounter;
        string strName;
    }

    // DO NOT use Screaming Caps for constants or readonly variables
    // Screaming Caps is when you use CAPITAL LETTERS for the whole of the identifier
    public class ScreamingCapsExample
    {
        // Correct
        public static const string ShippingType = "DropShip";

        // Avoid
        public static const string SHIPPINGTYPE = "DropShip";
    }

    // Avoid using Abbreviations
    // Exception: Abbreviations commonly used as names such as ID,XML,FTP, URL
    // Abbreviations should be all capitals if used in classes or methods and should be all lowercase in
    // identifiers UNLESS it is 2 letters (like ID)

    // Correct
    // UserGroup userGroup;
    // Assignment employeeAssignment;

    // Avoid
    //  UserGroup usrGrp;
    // Assignment empAssignment;

    // Exceptions
    // CustomerID customerId;
    // XMLDocument xmlDocument;
    // FTPHelper ftpHelper;
    // URIPart uriPart;

    // DO NOT use Underscores in identifiers. Exception: you can prefix private static variables with an underscore

    public class Underscores
    {

        // Correct
        public DateTime clientAppointment;
        public TimeSpan timeLeft;

        // Avoid
        public DateTime client_Appointment;
        public TimeSpan time_Left;

        // Exception
        private DateTime _registrationDate;

    }

    //DO use noun or noun phrases to name a class
    public class Employee
    {
    }
    public class BusinessLocation
    {
    }
    public class DocumentCollection
    {
    }

    // DO prefix interfaces with the letter I.  Interface names are noun (phrases) or adjectives.
    public interface IShape
    {
    }
    public interface IShapeCollection
    {
    }
    public interface IGroupable
    {
    }

    // DO name source files according to their main classes. Exception: file names with partial classes reflect their source or purpose, e.g.designer, generated, etc.
    // DO organise namespaces with a clearly defined structure

    // DO declare all member variables at the top of a class, with static variables at the very top.

    // Correct
    public class Account
    {
        public static string BankName;
        public static decimal Reserves;

        public string Number { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime DateClosed { get; set; }
        public decimal Balance { get; set; }

        // Constructor
        public Account() {
            // ...
        }
    }

}