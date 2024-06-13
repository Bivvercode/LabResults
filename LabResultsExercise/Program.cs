using LabResultsExercise.Data;
using LabResultsExercise.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<LabResultsImporterService>();

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<ApplicationDbContext>();
        context.Database.Migrate();

        var importerService = services.GetRequiredService<LabResultsImporterService>();
        string filePath = "../LabResults.txt";
        importerService.ImportResultsFromFile(filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

app.Run();
