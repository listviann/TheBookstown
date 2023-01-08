using TheBookstown;
using TheBookstown.Domain;
using TheBookstown.Domain.Entities;
using TheBookstown.Domain.Repositories.Abstract;
using TheBookstown.Domain.Repositories.EntityFramework;
using TheBookstown.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.Bind("Project", new Config());

builder.Services.AddTransient<IAuthorRepository, EFAuthorRepository>();
builder.Services.AddTransient<IBookRepository, EFBookRepository>();
builder.Services.AddTransient<IGenreRepository, EFGenreRepository>();
builder.Services.AddTransient<IOrderItemRepository, EFOrderItemRepository>();
builder.Services.AddTransient<IUserRepository, EFUserRepository>();
builder.Services.AddTransient<IUserCartRepository, EFUserCartRepository>();
builder.Services.AddTransient<IPageTextFieldRepository, EFPageTextFieldRepository>();
builder.Services.AddTransient<DataManager>();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
});

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Config.ConnectionString));

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireDigit = false;
}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.Name = "theBookstownAuth";
    options.Cookie.HttpOnly = true;
    options.LoginPath = "/account/login";
    options.AccessDeniedPath = "/account/accessdenied";
    options.SlidingExpiration = true;
});

builder.Services.AddAuthorization(x =>
{
    x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
    x.AddPolicy("UserArea", policy => { policy.RequireRole("ordinary"); });
});

builder.Services.AddControllersWithViews(x =>
{
    x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
    x.Conventions.Add(new UserAreaAuthorization("User", "UserArea"));
}).AddSessionStateTempDataProvider();// To enable the session based TempData provider

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseSession();
app.UseStaticFiles();
app.UseRouting();
app.UseCookiePolicy();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "admin",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "user",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
