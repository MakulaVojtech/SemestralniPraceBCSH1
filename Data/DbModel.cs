using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Makula_semestralni_prace.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Makula_semestralni_prace.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Competitor> Competitors { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Competition> Competition { get; set; }
    public DbSet<Round> Rounds { get; set; }
    public DbSet<Game> Games { get; set; }

    public string DbPath { get; init; }

    public DatabaseContext()
    {
        var path = Environment.CurrentDirectory;
       
        DbPath = System.IO.Path.Join(path, "Data/blogging.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source={DbPath}");
    }

}
