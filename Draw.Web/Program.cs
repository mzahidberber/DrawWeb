

using Draw.Business.Concrete;
using Draw.Core.Business;
using Draw.Core.Data;
using Draw.Data.Abstract;
using Draw.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddScoped(typeof(IGenericService<,>),typeof(GenericManager<,>));
        builder.Services.AddScoped(typeof(IGenericRepository<>),typeof(EfGenericRepository<>));
        builder.Services.AddScoped<IMainTitleService, MainTitleManager>();
        builder.Services.AddScoped<ISubTitleService, SubTitleManager>();
        builder.Services.AddScoped<IBaseTitleService, BaseTitleManager>();
        builder.Services.AddScoped<IMainTitleRepository, EfMainTitleDal>();
        builder.Services.AddScoped<ISubTitleRepository, EfSubTitleDal>();
        builder.Services.AddScoped<IBaseTitleRepository, EfBaseTitleDal>();

		builder.Services.AddTransient<DrawContext>();

		using (DrawContext context = new DrawContext(builder.Configuration))
		{
			var pendingMigrations = context.Database.GetPendingMigrations();
			if (pendingMigrations.Any())
				context.Database.Migrate();
		}

        // Add services to the container.
        builder.Services.AddControllersWithViews().AddNewtonsoftJson(options =>
        {
            options.SerializerSettings.Formatting = Formatting.Indented;
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
        }
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

		app.MapControllerRoute(
	        name: "doc",
	        pattern: "doc",
	        defaults: new { controller = "Home", action = "DrawCAD" });
		app.MapControllerRoute(
			name: "api",
			pattern: "api",
			defaults: new { controller = "Home", action = "DrawApi" });
		app.MapControllerRoute(
			name: "geo",
			pattern: "geo",
			defaults: new { controller = "Home", action = "DrawGeo" });
		app.MapControllerRoute(
			name: "auth",
			pattern: "auth",
			defaults: new { controller = "Home", action = "DrawAuth" });

		app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}