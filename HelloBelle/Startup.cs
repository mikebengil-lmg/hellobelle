using HelloBelle.Modules;
using HelloBelle.Services;

namespace HelloBelle;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Configure your services here, such as adding controllers and registering dependencies.
        
        services.AddControllers();
        //services.AddScoped<IMessageService, MessageService>();
        services.RegisterMessageServices();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/hellobelle/Error");
            app.UseHsts();
        }

        // Configure middleware here, such as routing, authentication, and authorization.

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=hellobelle}/{action=Index}/{id?}");
        });
    }
}
