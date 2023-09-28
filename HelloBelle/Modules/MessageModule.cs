using HelloBelle.Services;

namespace HelloBelle.Modules;

public static class MessageModule
{
    public static void RegisterMessageServices(this IServiceCollection services)
    {
        services.AddScoped<IMessageService, MessageService>();
    }
}