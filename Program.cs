using System.Net;

namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to the Address Book System");

            Console.WriteLine("Please Enter Contact Details : firstname, lastname, email, address, city, state, zipCode, phone");
            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            string Address = Console.ReadLine();
            string City = Console.ReadLine();
            string zipCode = Console.ReadLine();
            string State = Console.ReadLine();
            string PhoneNumber = Console.ReadLine();
            string Email = Console.ReadLine();

            AddNewContact contact1 = new AddNewContact(FirstName,LastName,Address,City,zipCode,State,PhoneNumber,Email);
        }
    }
}