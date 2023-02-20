namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to the Address Book System");

            EditContact person = new EditContact();

            //-----Add contact----//
            person.AddDetails();
            //person.ListingPeople();


            //-----Modify Contact-----//
            person.editContact();
            person.ListingPeople();
        }
    }
}