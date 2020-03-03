using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using OnlineSinavSistemi.Bll.Abstract;
using OnlineSinavSistemi.Bll.Concrete;
using OnlineSinavSistemi.Dal.Concrete;
using Swashbuckle.AspNetCore.Swagger;

namespace OnlineSinavSistemi.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(c=> 
                {
                c.SwaggerDoc("v1", new Info { Title = "WebApplication1", Version = "v1" });
                    c.SwaggerDoc("v2", new Info { Title = "WebApplication2", Version = "v2" });
            });

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(jwtBearerOptions =>
    {
        jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateActor = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = "qwer",
            ValidAudience = "asdf",
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("fatmabetulyilmaz"))
        };
    });

            services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin",
                    builder => builder.WithOrigins("http://localhost:26847", "https://localhost:44391")); });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<OnlineSinavSistemiContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }



            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<OnlineSinavSistemiContext>();
                context.Database.Migrate();

            }


            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Online Sinav Sistemi API v1");
                c.SwaggerEndpoint("/swagger/v2/swagger.json", "Online Sinav Sistemi API v2");
            });
            app.UseCors(builder =>
    builder.WithOrigins("http://localhost:26847", "https://localhost:44391"));
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
