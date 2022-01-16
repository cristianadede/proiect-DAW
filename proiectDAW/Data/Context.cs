using proiectDAW.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proiectDAW.Models.One_to_Many;
using proiectDAW.Models.One_to_One;
using proiectDAW.Models.Many_to_Many;

namespace proiectDAW.Data
{
    public class Context : DbContext
    {
        public DbSet<DataBaseModel> DataBaseModels { get; set; }

        // pt one-to-many
        public DbSet<Model1> Models1 { get; set; }
        public DbSet<Model2> Models2 { get; set; }

        // pt many-to-many
        public DbSet<Model3> Models3 { get; set; }
        public DbSet<Model4> Models4 { get; set; }
        public DbSet<ModelLegatura> ModelLegaturas { get; set; }
    
        // pt one-to-one
        public DbSet<Model5> Models5 { get; set; }
        public DbSet<Model6> Models6 { get; set; }

        //pt Utilizator, Comentariu, Film (M-M)
        public DbSet<Utilizator> Utilizators { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Comentariu> Comentarius { get; set; }

        //pt Gen (1-M cu Film)
        public DbSet<Gen> Gens { get; set; }

        //pt ActorFilm, Actor (M-M intre film-actor)
        public DbSet<Actor> Actors { get; set; }
        public DbSet<ActorFilm> ActorFilms { get; set; }

        //pt Detaliu (1-1 cu film)
        public DbSet<Detaliu> Detalius { get; set; }
        public Context(DbContextOptions<Context>options) : base(options)
        {

        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            // pt one-to-many
            modelBuilder.Entity<Model1>()
                        .HasMany(m1 => m1.Models2)
                        .WithOne(m2 => m2.Model1);

            //pt many-to-many
            modelBuilder.Entity<ModelLegatura>().HasKey(ml => new { ml.Model3Id, ml.Model4Id });

            modelBuilder.Entity<ModelLegatura>()
                       .HasOne<Model3>(ml => ml.Model3)
                       .WithMany(m3 => m3.ModelLegaturas)
                       .HasForeignKey(ml => ml.Model3Id);

            modelBuilder.Entity<ModelLegatura>()
                      .HasOne<Model4>(ml => ml.Model4)
                      .WithMany(m4 => m4.ModelLegaturas)
                      .HasForeignKey(ml => ml.Model4Id);

            // pt one-to-one
            modelBuilder.Entity<Model5>()
                       .HasOne(m5 => m5.Model6)
                       .WithOne(m6 => m6.Model5)
                       .HasForeignKey<Model6>(m6 => m6.Model5Id);

            //pt Utilizator, Comentariu, Film
            modelBuilder.Entity<Comentariu>().HasKey(c => new { c.Id });

            modelBuilder.Entity<Comentariu>()
                       .HasOne<Film>(c => c.Film)
                       .WithMany(f => f.Comentarius)
                       .HasForeignKey(c => c.FilmId);

            modelBuilder.Entity<Comentariu>()
                      .HasOne<Utilizator>(c => c.Utilizator)
                      .WithMany(m4 => m4.Comentarius)
                      .HasForeignKey(c => c.UtilizatorId);

            // pt Gen
            modelBuilder.Entity<Gen>()
                        .HasMany(g => g.Films)
                        .WithOne(f => f.Gen);

            //pt ActorFilm, Actor (M-M intre film-actor)
            modelBuilder.Entity<ActorFilm>().HasKey(af => new { af.FilmId, af.ActorId });

            modelBuilder.Entity<ActorFilm>()
                       .HasOne<Actor>(af => af.Actor)
                       .WithMany(a => a.ActorFilms)
                       .HasForeignKey(af => af.ActorId);

            modelBuilder.Entity<ActorFilm>()
                      .HasOne<Film>(af => af.Film)
                      .WithMany(f => f.ActorFilms)
                      .HasForeignKey(af => af.FilmId);

            //pt Detaliu (1-1 cu film)
            modelBuilder.Entity<Detaliu>()
                       .HasOne(f => f.Film)
                       .WithOne(d => d.Detaliu)
                       .HasForeignKey<Film>(d => d.DetaliuId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
