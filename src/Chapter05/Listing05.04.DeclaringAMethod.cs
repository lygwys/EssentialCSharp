namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_04
{
    #region INCLUDE
    public class IntroducingMethods
    {
        public static void Main()
        {
            string firstName;
            string lastName;
            string fullName;
            string initials;

            System.Console.WriteLine("Hey you!");

            firstName = GetUserInput("Enter your first name: ");
            lastName = GetUserInput("Enter your last name: ");

            fullName = GetFullName(firstName, lastName);
            initials = GetInitials(firstName, lastName);
            DisplayGreeting(fullName, initials);
        }

        static string GetUserInput(string prompt)
        {
            System.Console.Write(prompt);
            return System.Console.ReadLine() ?? string.Empty;
        }

        static string GetFullName(  
              string firstName, string lastName) =>
                  $"{ firstName } { lastName }";


        static void DisplayGreeting(string fullName, string initials)
        {
            System.Console.WriteLine(
                $"Hello { fullName }! Your initials are { initials }");
            return;
        }

        static string GetInitials(string firstName, string lastName)
        {
            return $"{ firstName[0] }. { lastName[0] }.";
        }
    }
    #endregion INCLUDE
}
