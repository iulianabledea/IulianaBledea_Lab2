using Microsoft.EntityFrameworkCore;
using IulianaBledea_Lab2.Models; // Replace with your actual project's namespace

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddRazorPages();

// Add the DbContext for SQLite
builder.Services.AddDbContext<Lab2Context>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Lab2Context")));

// Build the application
var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    // Use the error handler and HSTS in non-development environments
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

// Enable HTTPS redirection
app.UseHttpsRedirection();

// Serve static files (e.g., CSS, JavaScript)
app.UseStaticFiles();

// Configure routing
app.UseRouting();

// Add authorization middleware (if required)
app.UseAuthorization();

// Map Razor Pages
app.MapRazorPages();

// Run the application
app.Run();