using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthWind.Sales.IoC;

namespace NorthWind.Sales.WebApi
{
    public static class WebApplicationHelper
    {
        public static WebApplication CreateWebApplication( this WebApplicationBuilder builder){
            
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddNothwindSalesServices(
                builder.Configuration, "NorthWindDB"
            );

            return builder.Build();
        }

        public static WebApplication ConfigureWebapplication( this WebApplication app){
            if(app.Environment.IsDevelopment()){
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseNorthWindSalesEndPoints();

            return app;
        }
    }
}