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
	 optionsBuilder.UseSqlServer();
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		 modelBuilder.Entity<Qr>().HasKey(x => x.id)  
	}

}
