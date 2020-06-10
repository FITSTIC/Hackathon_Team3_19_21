using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
    public class Esame
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Punteggio { get; set; }
        [Required]
        public string Modulo { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public int StudenteId { get; set; }
        [Required]




        public Esame (int Id, int Punteggio, string Modulo, DateTime Data, int StudenteId)
        {
            this.Id = Id;
            this.Punteggio = Punteggio;
            this.Modulo = Modulo;
            this.Data = Data;
            this.StudenteId = StudenteId;

        }
    }
    public class Modulo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DataInizio { get; set; }
        public DateTime DataFine {get; set;}
        public string Materia { get; set; }
        public string Nome { get; set; }
        [Required]
        public int CorsoId { get; set; }
        [Required]
        public int DocenteId { get; set; }
        [Required]
        public int TutorId { get; set; }
        [Required]


        public Modulo(int Id, DateTime DataInizio, DateTime DataFine, string Materia, string Nome, int CorsoId, int DocenteId, int TuttorId)
        {
            this.Id = Id;
            this.DataInizio = DataInizio;
            this.DataFine = DataFine;
            this.Materia = Materia;
            this.Nome = Nome;
            this.CorsoId = CorsoId;
            this.DocenteId = DocenteId;
            this.TutorId = TutorId;

        }

    }
    
}
