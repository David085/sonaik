using Microsoft.EntityFrameworkCore;
using System;

public class Contexto : DbContext
{
	public Contexto()
	{

	}

	public DbSet<Qr> Qr { get; set; }

	public DbSet<Usuario> Usuario { get; set; }

	public DbSet <Zapato> Zapato { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
	 optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=sonaik;Integrated Security=True");
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Qr>().HasKey(x => x.id);
		modelBuilder.Entity<Usuario>().HasKey(x => x.id);
	}

}
