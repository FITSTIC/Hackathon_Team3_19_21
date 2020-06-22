using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GestionaleFitstic.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Studente> Studenti { get; set; }
        public DbSet<Organizzatore> Organizzatori { get; set; }
        public DbSet<Docente> Docenti { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Corso> Corsi { get; set; }
        public DbSet<Modulo> Moduli { get; set; }
        public DbSet<Esame> Esami { get; set; }
        public DbSet<Iscrizione> Iscrizioni { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Studente>().HasData(
                new Studente
                {
                    Id = 1,
                    Nome = Marco,
                    Cognome = Rossi,
                    DataNascita = new DateTime(1995, 10, 6, 11, 5, 30),
                    TipoDiploma = "Perito Informatico",
                    Email = "Marco.Rossi@email.com",
                    AnnoDiploma = new DateTime(2014, 8, 6, 12, 10, 5),
                    Indirizzo = "via Roma 45",
                    Telefono = 3333333331,
                    Città = Cesena,
                },
                new Studente
                {
                    Id = 2,
                    Nome = Sara,
                    Cognome = Greco,
                    DataNascita = new DateTime(1994, 11, 9, 5, 5, 32),
                    TipoDiploma = "Liceo Artistico Architettura e Ambiente",
                    Email = "Sara.Greco@email.com",
                    AnnoDiploma = new DateTime(2013, 8, 6, 12, 10, 5),
                    Indirizzo = "via Roma 46",
                    Telefono = 3333333332,
                    Città = Cesena,
                },
                new Studente
                {
                    Id = 3,
                    Nome = Mirco,
                    Cognome = Grassi,
                    DataNascita = new DateTime(1995, 10, 06, 11, 05, 30),
                    TipoDiploma = "Liceo Scientifico Scienze Applicate",
                    Email = "Mirco.Grassi@email.com",
                    AnnoDiploma = new DateTime(2014, 8, 6, 12, 10, 5),
                    Indirizzo = "via Roma 47",
                    Telefono = 3333333333,
                    Città = Cesena,
                },
                new Studente
                {
                    Id = 4,
                    Nome = Rebecca,
                    Cognome = Esposito,
                    DataNascita = new DateTime(1999, 10, 06, 11, 05, 30),
                    TipoDiploma = "Liceo Linguistico",
                    Email = "Rebecca.Esposito@email.com",
                    AnnoDiploma = new DateTime(2018, 8, 6, 12, 10, 5),
                    Indirizzo = "via Roma 48",
                    Telefono = 3333333334,
                    Città = Cesena,
                },
                new Studente
                {
                    Id = 5,
                    Nome = Gianluca,
                    Cognome = Ricci,
                    DataNascita = new DateTime(1999, 10, 06, 11, 05, 30),
                    TipoDiploma = "Perito Informatico",
                    Email = "Gianluca.Ricci@email.com",
                    AnnoDiploma = new DateTime(2019, 8, 6, 12, 10, 5),
                    Indirizzo = "via Roma 49",
                    Telefono = 3333333335,
                    Città = Cesena,
                }
            );
            builder.Entity<Organizzatore>().HasData(
                new Organizzatore
                {
                    Id = 1,
                    Nome = Luca,
                    Cognome = Argangeli,
                    Email = "Luca.Arcangeli@email.com",
                    Telefono = 3333333336,
                    DataNascita = new DateTime(1988, 8, 6, 12, 10, 5),
                    DataAssunzione = new DateTime(2006, 8, 6, 12, 10, 5),
                }
            );
            builder.Entity<Docente>().HasData(
                new Docente
                {
                    Id = 1,
                    Nome = Matteo,
                    Cognome = Venturi,
                    Email = "Matteo.Venturi@email.com",
                    Telefono = 3333333337,
                    DataNascita = new DateTime(1988, 8, 6, 12, 10, 5),
                    DataAssunzione = new DateTime(2010, 8, 6, 12, 10, 5),
                }
            );
            builder.Entity<Tutor>().HasData(
                new Tutor
                {
                    Id = 1,
                    Nome = Manuel,
                    Cognome = Coppola,
                    Email = "Manuel.Coppola@email.com",
                    Telefono = 3333333338,
                    DataNascita = new DateTime(1988, 8, 6, 12, 10, 5),
                    DataAssunzione = new DateTime(2009, 8, 6, 12, 10, 5),
                }
            );
            builder.Entity<Corso>().HasData(
                new Corso
                {
                    Id = 1,
                    Nome = "Turing",
                    DataInizio = new DateTime(2019, 10, 6, 8, 10, 5),
                    DataFine = new DateTime(2021, 6, 6, 13, 10, 5),
                    Sede = "Via Milano 12",
                    AnnoAccademico = "2019/2021",
                    OrganizzatoreId = 1,
                }
            );
            builder.Entity<Modulo>().HasData(
                new Modulo
                {
                    Id = 1,
                    DataInizio = new DateTime(2019, 11, 6, 8, 10, 5),
                    DataFine = new DateTime(2020, 2, 6, 8, 10, 5),
                    Materia = "Informatica",
                    Nome = "logiche di programmazione",
                    CorsoId = 1,
                    DocenteId = 1,
                    TutorId = 1,
                }
            );
            builder.Entity<Iscrizione>().HasData(
                new Iscrizione
                {
                    Id = 1,
                    CorsoId = 1,
                    StudenteId = 1,
                    DataIscrizione = new DateTime(2019, 6, 10, 8, 10, 5),
                },
                new Iscrizione
                {
                    Id = 2,
                    CorsoId = 1,
                    StudenteId = 2,
                    DataIscrizione = new DateTime(2019, 6, 10, 8, 10, 5),
                },
                new Iscrizione
                {
                    Id = 3,
                    CorsoId = 1,
                    StudenteId = 3,
                    DataIscrizione = new DateTime(2019, 6, 10, 8, 10, 5),
                },
                new Iscrizione
                {
                    Id = 4,
                    CorsoId = 1,
                    StudenteId = 4,
                    DataIscrizione = new DateTime(2019, 6, 10, 8, 10, 5),
                },
                new Iscrizione
                {
                    Id = 5,
                    CorsoId = 1,
                    StudenteId = 5,
                    DataIscrizione = new DateTime(2019, 6, 10, 8, 10, 5),
                }
            );
            builder.Entity<Esame>().HasData(
                new Esame
                {
                    Id = 1,
                    Punteggio = 80,
                    Modulo = 1,
                    Data = new DateTime(2020, 2, 5, 8, 10, 5),
                    StudenteId = 1,
                },
                new Esame
                {
                    Id = 2,
                    Punteggio = 70,
                    Modulo = 1,
                    Data = new DateTime(2020, 2, 5, 8, 10, 5),
                    StudenteId = 2,
                },
                new Esame
                {
                    Id = 3,
                    Punteggio = 90,
                    Modulo = 1,
                    Data = new DateTime(2020, 2, 5, 8, 10, 5),
                    StudenteId = 3,
                },
                new Esame
                {
                    Id = 4,
                    Punteggio = 85,
                    Modulo = 1,
                    Data = new DateTime(2020, 2, 5, 8, 10, 5),
                    StudenteId = 4,
                },
                new Esame
                {
                    Id = 5,
                    Punteggio = 75,
                    Modulo = 1,
                    Data = new DateTime(2020, 2, 5, 8, 10, 5),
                    StudenteId = 5,
                }
            );
        } 
    }
}
