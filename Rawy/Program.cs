using core.Repository;
using Microsoft.EntityFrameworkCore;
using Rawy.Extensions;
using Rawy.Helpers;
using Repsotiry.Data;
using Repsotiry.GenaricReposiory;

namespace Rawy
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            // Register the DbContext with the connection string
            builder.Services.AddDbContext<RawyDbcontext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddDbContext<IdentityContext>(options =>
               options.UseSqlServer(connectionString));
            builder.Services.AddIdentityServices(builder.Configuration);
            builder.Services.AddAutoMapper(typeof(MappingProfile));
            builder.Services.AddScoped(typeof(IGenaricrepostry<>),typeof(GenaricRepostry<>));



            var app = builder.Build();

            //using var scope = app.Services.CreateScope();
            //var services = scope.ServiceProvider;
            //var _dbcontext=services.GetRequiredService<RawyDbcontext>();
            //var loggerFactory = services.GetRequiredService<ILoggerFactory>();
            //try
            //{ 
            // await _dbcontext.Database.GetAppliedMigrationsAsync();
            //}
            //catch (Exception ex)
            //{
            //    var logger = loggerFactory.CreateLogger<Program>();
            //    logger.LogError(ex, "an error has been occured during apply the migration");
            //}



            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}