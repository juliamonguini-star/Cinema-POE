using CinemaDomain;
using RepositoryCinema.Mapping;

namespace CinemaRepository.Context
{
    public class MyDBContext : MyDBContext
    {
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Filme> Filme { get; set; }
        public DbSet<Sala> Sala { get; set; }
        public DbSet<Sessao> Sessao { get; set; }
        public DbSet<Ingresso> Ingresso { get; set; }
        public DbSet<IngressoItem> IngressoItem { get; set; }

        public MyDBContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Genero>(new GeneroMap().Configure);
            modelBuilder.Entity<Filme>(new FilmeMap().Configure);
            modelBuilder.Entity<Sala>(new SalaMap().Configure);
            modelBuilder.Entity<Sessao>(new SessaoMap().Configure);
            modelBuilder.Entity<Ingresso>(new IngressoMap().Configure);
            modelBuilder.Entity<IngressoItem>(new IngressoItemMap().Configure);
        }
    }
}