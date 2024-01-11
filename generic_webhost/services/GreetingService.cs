namespace generic_webhost.services
{
    public class GreetingService : IGreetingService
    {
        private string _currentGreeting = "default greeting";

        public GreetingService()
        {
                
        }

        public string Greeting()
        {
            return _currentGreeting;
        }

        public string GiveGreeting(string greeting)
        {
            _currentGreeting = greeting;

            return _currentGreeting;
        }
    }
}
