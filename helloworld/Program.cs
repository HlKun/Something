using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                .ConfigureServices(svcs => svcs.AddMvc())
                .Configure(app => app.UseMvc())
                .Build()
                .Run();
        }
    }

    public class HelloController:Controller
    {
        [HttpGet("/hello/{name}")]
        public IActionResult SayHello(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}
