using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{
    // TABELA: Konta (Autoryzacja)
    [Table("Konta")]
    public class Konto
    {
        [Key]
        [Column("IdKonta")]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Login { get; set; }

        [Required]
        [MaxLength(255)]
        public string HasloHash { get; set; }

        [Required]
        [MaxLength(30)]
        public string Rola { get; set; }

        public bool Aktywne { get; set; }

        // Relacje
        public ICollection<Pracownik> Pracownicy { get; set; }
        public ICollection<Gosc> Goscie { get; set; }
    }

    // TABELA: Goscie
    [Table("Goscie")]
    public class Gosc
    {
        [Key]
        [Column("IdGoscia")]
        public int Id { get; set; }

        [Column("IdKonta")]
        public int? IdKonta { get; set; }

        [ForeignKey(nameof(IdKonta))]
        public Konto Konto { get; set; }

        [Required]
        [MaxLength(50)]
        public string Imie { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nazwisko { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string Telefon { get; set; }

        [MaxLength(50)]
        public string DokumentTozsamosci { get; set; }

        // Relacje
        public ICollection<Rezerwacja> Rezerwacje { get; set; }
    }

    // TABELA: Pracownicy
    [Table("Pracownicy")]
    public class Pracownik
    {
        [Key]
        [Column("IdPracownika")]
        public int Id { get; set; }

        [Required]
        [Column("IdKonta")]
        public int IdKonta { get; set; }

        [ForeignKey(nameof(IdKonta))]
        public Konto Konto { get; set; }

        [Required]
        [MaxLength(50)]
        public string Imie { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nazwisko { get; set; }

        public DateTime DataZatrudnienia { get; set; }

        public decimal Pensja { get; set; }

        // Relacje
        public ICollection<Rezerwacja> Rezerwacje { get; set; }
    }

    // TABELA: Pokoje
    [Table("Pokoje")]
    public class Pokoj
    {
        [Key]
        [Column("IdPokoju")]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string NumerPokoju { get; set; }

        [Required]
        [MaxLength(50)]
        public string TypPokoju { get; set; }

        public int Pojemnosc { get; set; }

        public decimal CenaPodstawowa { get; set; }

        [MaxLength(20)]
        public string StatusPokoju { get; set; }

        // Relacje
        public ICollection<Rezerwacja> Rezerwacje { get; set; }
    }

    // TABELA: Rezerwacje
    [Table("Rezerwacje")]
    public class Rezerwacja
    {
        [Key]
        [Column("IdRezerwacji")]
        public int Id { get; set; }

        [Required]
        [Column("IdGoscia")]
        public int IdGoscia { get; set; }

        [ForeignKey(nameof(IdGoscia))]
        public Gosc Gosc { get; set; }

        [Required]
        [Column("IdPokoju")]
        public int IdPokoju { get; set; }

        [ForeignKey(nameof(IdPokoju))]
        public Pokoj Pokoj { get; set; }

        [Required]
        [Column("IdPracownika")]
        public int IdPracownika { get; set; }

        [ForeignKey(nameof(IdPracownika))]
        public Pracownik Pracownik { get; set; }

        public DateTime DataPrzyjazdu { get; set; }

        public DateTime DataWyjazdu { get; set; }

        public decimal KwotaCalkowita { get; set; }

        [MaxLength(30)]
        public string StatusRezerwacji { get; set; }

        public string Uwagi { get; set; }

        // Relacje
        public ICollection<Platnosc> Platnosci { get; set; }
    }

    // TABELA: Platnosci
    [Table("Platnosci")]
    public class Platnosc
    {
        [Key]
        [Column("IdPlatnosci")]
        public int Id { get; set; }

        [Required]
        [Column("IdRezerwacji")]
        public int IdRezerwacji { get; set; }

        [ForeignKey(nameof(IdRezerwacji))]
        public Rezerwacja Rezerwacja { get; set; }

        public decimal Kwota { get; set; }

        public DateTime DataPlatnosci { get; set; }

        [MaxLength(20)]
        public string MetodaPlatnosci { get; set; }
    }
}