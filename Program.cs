namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to the Address Book System");

            DeleteContact  person = new DeleteContact();

            //----Adding Contact---//
            person.addContact();

            //------Deleting Contact----//
            person.deleteContact();
            person.ListingPeople();

            
        }
    }
}