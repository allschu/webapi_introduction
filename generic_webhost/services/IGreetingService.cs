namespace generic_webhost.services
{
    public interface IGreetingService
    {
        public string Greeting();
        public string GiveGreeting(string greet);
    }
}
