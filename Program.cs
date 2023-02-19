using System.Net;

namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to the Address Book System");

           

            AddNewContact contact1 = new AddNewContact();
            contact1.AddDetails();
            contact1.ListingPeople();
        }
    }
}