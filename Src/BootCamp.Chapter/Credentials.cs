namespace BootCamp.Chapter
{
    // TODO: make a struct and add validation and other needed methods (if needed)
    public class Credentials
    {
        public string Username;
        public string Password;

        public Credentials(string username, string password)
        {
            Username = username;
            Password = password;
        }

        Credentials()
        {

        }

        // TODO: Implement properly.
        public static bool TryParse(string input, out Credentials credentials)
        {
            if(input == null) 
            { 
                credentials = new Credentials();
                return false;
            }
            
            var credential = input.Split(":");
            credentials = new Credentials(credential[0], credential[1]);
            return true;
            
        }
    }
}
