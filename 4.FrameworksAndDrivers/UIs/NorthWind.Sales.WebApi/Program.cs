namespace NorthWind.Sales.WebApi;

public class Program
{
    public static void Main(string[] args)
    {
        WebApplication.CreateBuilder(args)
            .CreateWebApplication()
            .ConfigureWebapplication()
            .Run();
    }
}
