


namespace NotificationSystem.Api
{
    using NotificationSystem.Domain.Events;
    using NotificationSystem.Infraestructure.Services;
    using NotificationSystem.Application.Interfaces;
    using NotificationSystem.Application.Services;
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // Registrar las dependencias de los servicios de notificación
            builder.Services.AddSingleton<NotificationPublisher>();
            builder.Services.AddScoped<INotificationService, NotificationService>();
            builder.Services.AddSingleton<EmailService>();



            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
