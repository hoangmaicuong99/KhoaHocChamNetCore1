using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DISampleService;
using DISampleService.DIL;

namespace DISample
{
    public class Startup
    {
        IWebHostEnvironment _env;
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            _env = env;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            //Môi trường cho sẵn
            if(_env.IsProduction())
            {
                /* tính trừu tượng. IProductService lấy thuộc tính ProductBesterService sài,
                chỉ cần sửa ở đây là tất cả các lớp ProductBesterService sẽ được sửa
                (ProductService) ** nếu muốn nó thành lớp đó***/
                services.AddTransient<IProductService, ProductBesterService>();
            }// Môi trường mới tự tạo
            else if(_env.IsEnvironment("EnviromentNew"))
            {
                services.AddTransient<IProductService, ProductServiceEnviromentNew>();
            }
            else
            {
                services.AddTransient<IProductService, ProductService>();
            }

            // Test 3 loại vòng đời
            // Transient một yêu cầu có thể tạo ra nhiều guid => Tạo 2 interface
            services.AddTransient<ITransientService, GuiService>();
            // Scoped một yêu cầu 1 gui duy nhất => Tạo 2 interface
            services.AddScoped<IScopedService, GuiService>();
            // Singleton nhiều yêu cầu cũng 1 guid duy nhất 
            services.AddSingleton<ISingletonService, GuiService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
