using Nancy;
namespace TapcoApiApplication
{
        public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", args => {
                return Response.AsJson(new Message() { text = "Hallo Tapco!" });
            });
        }
    }
}