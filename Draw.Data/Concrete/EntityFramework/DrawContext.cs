using Draw.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Draw.Data.Concrete.EntityFramework;

public class DrawContext:DbContext
{
    public IConfiguration _configuration { get; set; }
    public DrawContext(IConfiguration configuration)
    {
        this._configuration = configuration;
    }

	public DbSet<MainTitle> MainTitles { get; set; }
	public DbSet<BaseTitle> Titles { get; set; }
	public DbSet<SubTitle> SubTitles { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.ApplyConfiguration(new MainTitleMapping());
		modelBuilder.ApplyConfiguration(new BaseTitleMapping());
		modelBuilder.ApplyConfiguration(new SubTitleMapping());
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		base.OnConfiguring(optionsBuilder);
		optionsBuilder.UseSqlite(_configuration.GetConnectionString("sqlite"));
	}
}
