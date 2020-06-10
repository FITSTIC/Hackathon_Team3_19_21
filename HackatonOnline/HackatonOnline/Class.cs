using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackatonOnline
{
    public class Studente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        [Required]
        public string TipoDiploma { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime AnnoDiploma { get; set; }
        public string Indirizzo { get; set; }
        public int Telefono { get; set; }
        [Required]
        public string Città { get; set; }

        public Studente(int Id, string Nome, string Cognome, DateTime DataNascita, string TipoDiploma, string Email, DateTime AnnoDiploma, string Indirizzo, int Telefono, string Città)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.DataNascita = DataNascita;
            this.TipoDiploma = TipoDiploma;
            this.Email = Email;
            this.AnnoDiploma = AnnoDiploma;
            this.Indirizzo = Indirizzo;
            this.Telefono = Telefono;
            this.Città = Città;
        }
        public Studente(int Id, string Nome, string Cognome, string TipoDiploma, string Email, DateTime AnnoDiploma, string Città)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.TipoDiploma = TipoDiploma;
            this.Email = Email;
            this.AnnoDiploma = AnnoDiploma;
            this.Città = Città;
        }
    }
    public interface Personale
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
        [Required]
        public string Email { get; set; }
        public int Telefono { get; set; }
        public DateTime DataNascita { get; set; }
        [Required]
        public DateTime DataAssunzione { get; set; }
    }
    public class Organizzatore : Personale
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
        [Required]
        public string Email { get; set; }
        public int Telefono { get; set; }
        public DateTime DataNascita { get; set; }
        [Required]
        public DateTime DataAssunzione { get; set; }
        public Organizzatore(int Id, string Nome, string Cognome, string Email, int Telefono, DateTime DataNascita, DateTime DataAssunzione)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Email = Email;
            this.Telefono = Telefono;
            this.DataNascita = DataNascita;
            this.DataAssunzione = DataAssunzione;
        }
        public Organizzatore(int Id, string Nome, string Cognome, string Email, DateTime DataAssunzione)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Email = Email;
            this.DataAssunzione = DataAssunzione;
        }
    }
    public class Docente : Personale
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
        [Required]
        public string Email { get; set; }
        public int Telefono { get; set; }
        public DateTime DataNascita { get; set; }
        [Required]
        public DateTime DataAssunzione { get; set; }
        public Docente(int Id, string Nome, string Cognome, string Email, int Telefono, DateTime DataNascita, DateTime DataAssunzione)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Email = Email;
            this.Telefono = Telefono;
            this.DataNascita = DataNascita;
            this.DataAssunzione = DataAssunzione;
        }
        public Docente(int Id, string Nome, string Cognome, string Email, DateTime DataAssunzione)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Email = Email;
            this.DataAssunzione = DataAssunzione;
        }
    }
    public class Tutor : Personale
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
        [Required]
        public string Email { get; set; }
        public int Telefono { get; set; }
        public DateTime DataNascita { get; set; }
        [Required]
        public DateTime DataAssunzione { get; set; }
        public Tutor(int Id, string Nome, string Cognome, string Email, int Telefono, DateTime DataNascita, DateTime DataAssunzione)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Email = Email;
            this.Telefono = Telefono;
            this.DataNascita = DataNascita;
            this.DataAssunzione = DataAssunzione;
        }
        public Tutor(int Id, string Nome, string Cognome, string Email, DateTime DataAssunzione)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Email = Email;
            this.DataAssunzione = DataAssunzione;
        }
    }
    public class Corso
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        [Required]
        public string Sede { get; set; }
        [Required]
        public string AnnoAccademico { get; set; }
        public int OrganizzatoreId { get; set; }

        public Corso(int Id, string Nome, DateTime DataInizio, DateTime DataFine, string Sede, string AnnoAccademico, int OrganizzatoreId)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.DataInizio = DataInizio;
            this.DataFine = DataFine;
            this.Sede = Sede;
            this.AnnoAccademico = AnnoAccademico;
            this.OrganizzatoreId = OrganizzatoreId;
        }
        public Corso(int Id, string Nome, DateTime DataInizio, string Sede, string AnnoAccademico, int OrganizzatoreId)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.DataInizio = DataInizio;
            this.Sede = Sede;
            this.AnnoAccademico = AnnoAccademico;
            this.OrganizzatoreId = OrganizzatoreId;
        }

    }
    public class Iscrizione
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CorsoId { get; set; }
        [Required]
        public int StudenteId { get; set; }
        [Required]
        public DateTime DataIscrizione { get; set; }
        public Iscrizione(int Id, int Corso, int Studente, DateTime DataIscrizione)
        {
            this.Id = Id;
            this.CorsoId = Corso;
            this.StudenteId = Studente;
            this.DataIscrizione = DataIscrizione;
        }
    }
}
