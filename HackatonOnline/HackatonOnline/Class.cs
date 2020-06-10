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
    
}
