using Nancy;
namespace TapcoApiApplication
{
        public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", args => "Hallo Tapco!");
        }
    }
}