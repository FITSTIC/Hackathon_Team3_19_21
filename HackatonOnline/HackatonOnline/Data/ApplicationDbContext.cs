using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HackatonOnline.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Studente> Studenti { get; set; }
        public DbSet<Organizzatore> Organizzatori { get; set; }
        public DbSet<Docente> Docenti { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Corso> Corsi { get; set; }
        public DbSet<Iscrizione> Iscrizioni { get; set; }
        public DbSet<Modulo> Moduli { get; set; }
        public DbSet<Esame> Esami { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
