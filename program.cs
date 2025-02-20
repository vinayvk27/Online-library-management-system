using LibraryManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register LibraryDbContext
builder.Services.AddDbContext<LibraryDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("librarydb")));

// ✅ Fix for Session issue
builder.Services.AddDistributedMemoryCache(); 
builder.Services.AddSession();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();
app.UseSession(); // Ensure session is enabled
app.UseAuthorization(); 

// ✅ Fix for `UseEndpoints` (Replace with direct `MapControllerRoute`)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
