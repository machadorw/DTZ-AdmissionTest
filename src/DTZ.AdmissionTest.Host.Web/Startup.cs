using DTZ.AdmissionTest.Database.MySQL.Repositories;
using DTZ.AdmissionTest.Platform.Entities;
using DTZ.AdmissionTest.Platform.Interfaces;
using DTZ.AdmissionTest.Platform.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DTZ.AdmissionTest.Host.Web
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //Model
            services.AddScoped<IAddresses, Addresses>();
            services.AddScoped<IOrders, Orders>();
            services.AddScoped<IProducts, Products>();
            services.AddScoped<IUsers, Users>();

            //Infra
            services.AddScoped<IAddressesRepository, AddressesRepository>();
            services.AddScoped<IOrdersRepository, OrdersRepository>();
            services.AddScoped<IProductsRepository, ProductsRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
