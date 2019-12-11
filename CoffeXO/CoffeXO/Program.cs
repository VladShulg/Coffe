using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace CoffeXO
{
    public class AdminData
    {
        public string Password { get; set; }

        public string Email { get; set; }
    }
    public class Ev
    {
        public string Name { get; internal set; }

        public string ImgSrc { get; set; }

        public string Info { get; set; }

        public string Day { get; set; }

        public string Time { get; set; }

        public string Id { get; internal set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
