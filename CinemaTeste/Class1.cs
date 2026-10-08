using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json;
using CinemaDomain;
using Microsoft.EntityFrameworkCore;

namespace CinemaTeste
{
    [TestClass]
    internal class TesteCinemaRepository
    {
        public partial class MyDBContext : DbContext
        {
            public DbSet<CinemaDomain.Genero> Genero { get; set; }
            public DbSet<CinemaDomain.Filme> Filme { get; set; }
            public DbSet<CinemaDomain.Sala> Sala { get; set; }
            public DbSet<CinemaDomain.Sessao> Sessao { get; set; }
            public DbSet<CinemaDomain.Ingresso> Ingresso { get; set; }
            public DbSet<CinemaDomain.IngressoItem> IngressoItem { get; set; }



            public MyDBContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                base.OnConfiguring(optionsBuilder);
                var server = "localhost";
                var port = "5432";
                var username = "postgres";
                var password = "ifsp";
                var database = "CinemaDB";
                var conStr = $"Host={server};Port={port};User Id={username};Password={password};Database={database}";

                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseNpgsql(conStr);
                }
            }
        }
        [TestMethod]
        public void CriarBanco() 
        {
            using (var db = new MyDBContext())
            {
                Assert.IsNotNull(db);
            }
        }

        public void InsertGenero()
        {
            using (var db = new MyDBContext())
            {
                var genero = new Genero { Id = 1, Nome = "Ação" };
                db.Genero.Add(genero);
                genero = new Genero { Id = 2, Nome = "Comédia" };
                db.Genero.Add(genero);
                genero = new Genero { Id = 3, Nome = "Drama" };
                db.Genero.Add(genero);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void ListarGenero()
        {
            using (var db = new MyDBContext())
            { 
                foreach (var item in db.Genero)
                {
                    Console.WriteLine(JsonSerializer.Serialize(item));
                }
                
            }
        }
    }
}
