namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to the Address Book System");

            AddMultipleContact person = new AddMultipleContact();

            person.addContact();
            person.ListingPeople();
        }
    }
}