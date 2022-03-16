using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SuperKala.Domain.UserAgg;
using SuperKala.Infrastructure.Contexts.Identity;
using SuperKala.Infrastructure.Contexts.Sql;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


#region ServiceContexts
builder
    .Services.
    AddDbContext<DataBaseContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
builder
    .Services
    .AddDbContext<IdentityContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
#endregion


#region ServiceIdentiry
builder
    .Services
    .AddIdentityCore<User>()
    .AddEntityFrameworkStores<IdentityContext>()
    .AddDefaultTokenProviders();
#endregion

var app = builder.Build();



if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}



#region Middleware

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

#endregion



#region Routing
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "Administration",
        pattern: "{area:exists}/{controller=Test}/{action=Index}/{id?}");
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
#endregion


app.Run();



