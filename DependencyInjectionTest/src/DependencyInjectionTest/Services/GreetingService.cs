namespace DependencyInjectionTest.Services
{
    public class GreetingService : IGreetingService
    {
        public string Greet()
        {
            return "Hello with dependency injection :)";
        }
    }
}