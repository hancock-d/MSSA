namespace _4._1_Address_Book_Dictionary
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ABookData.phoneBook.Add("Dave Hancock".ToLower(), new Person() { FirstName = "Dave", LastName = "Hancock", PhoneNumber = "555-373-0661", PhoneType = PhoneType.Cell, Address = "Cincinnati, OH" });
            ABookData.phoneBook.Add("Frankie Spirakes".ToLower(), new Person() { FirstName = "Frankie", LastName = "Spirakes", PhoneNumber = "555-802-1708", PhoneType = PhoneType.Cell, Address = "Tacoma, WA" });
            ABookData.phoneBook.Add("Lindsey Thielmann".ToLower(), new Person() { FirstName = "Lindsey", LastName = "Thielmann", PhoneNumber = "555-738-5840", PhoneType = PhoneType.Cell, Address = "Chicago, IL" });
            ABookData.phoneBook.Add("Brian Blake".ToLower(), new Person() { FirstName = "Brian", LastName = "Blake", PhoneNumber = "555-374-1266", PhoneType = PhoneType.Cell, Address = "Asheville, NC" });
            ABookData.phoneBook.Add("Jer Bear".ToLower(), new Person() { FirstName = "Jer", LastName = "Bear", PhoneNumber = "555-609-9925", PhoneType = PhoneType.Cell, Address = "Chicago, IL" });
            ABookData.phoneBook.Add("Charlie Sparks".ToLower(), new Person() { FirstName = "Charlie", LastName = "Sparks", PhoneNumber = "555-652-1331", PhoneType = PhoneType.Cell, Address = "Cincinnati, OH" });
            ABookData.phoneBook.Add("Jenny Makemine".ToLower(), new Person() { FirstName = "Jenny", LastName = "Makemine", PhoneNumber = "555-867-5309", PhoneType = PhoneType.Cell, Address = "Everywhere, USA" });


            Application.Run(new AddressBook());
        }
    }
}