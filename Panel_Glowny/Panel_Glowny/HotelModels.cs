using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{
    // TABELA: Osoby (Główna tabela z danymi personalnymi)
    [Table("osoby")]
    public class Osoba
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Imie")]
        [Required]
        [MaxLength(50)]
        public string Imie { get; set; }

        [Column("Nazwisko")]
        [Required]
        [MaxLength(100)]
        public string Nazwisko { get; set; }

        // Właściwości nawigacyjne
        public ICollection<Klient> Klienci { get; set; }
        public ICollection<Uzytkownicy> Uzytkownicy { get; set; }
        public ICollection<Pracownik> Pracownicy { get; set; }
    }

    // TABELA: Uzytkownicy (Pracownicy logujący się do systemu)
    [Table("Uzytkownicy")]
    public class Uzytkownicy
    {
        [Key]
        [Column("IdUzytkownika")]
        public int Id { get; set; }

        [Column("Login")]
        [Required]
        [MaxLength(50)]
        public string Login { get; set; }

        [Column("Haslo")]
        [Required]
        [MaxLength(255)]
        public string Haslo { get; set; }

        [Column("Rola")]
        [Required]
        [MaxLength(50)]
        public string Rola { get; set; }

        // Klucz obcy łączący z tabelą Osoby (Nullable, ponieważ w SQL jest DEFAULT NULL)
        [Column("Id_osoby")]
        public int? IdOsoby { get; set; }

        [ForeignKey(nameof(IdOsoby))]
        public Osoba Osoba { get; set; }
    }

    // TABELA: Klienci
    [Table("Klienci")]
    public class Klient
    {
        [Key]
        [Column("IdKlienta")]
        public int Id { get; set; }

        [Column("NumerTelefonu")]
        [Required]
        [MaxLength(20)]
        public string NumerTelefonu { get; set; }

        [Column("Email")]
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        // Klucz obcy łączący z tabelą Osoby (Nullable, ponieważ w SQL jest DEFAULT NULL)
        [Column("Id_osoby")]
        public int? IdOsoby { get; set; }

        [ForeignKey(nameof(IdOsoby))]
        public Osoba Osoba { get; set; }

        // Relacja z rezerwacjami
        public ICollection<Rezerwacja> Rezerwacje { get; set; }
    }

    // TABELA: Pracownicy
    [Table("Pracownicy")]
    public class Pracownik
    {
        [Key]
        [Column("Id_pracownika")]
        public int Id { get; set; }

        [Column("Data_zatrudnienia")]
        public DateTime DataZatrudnienia { get; set; }

        [Column("Pensja")]
        public decimal Pensja { get; set; }

        // Klucz obcy łączący z tabelą Osoby (NOT NULL w SQL)
        [Column("Id_osoby")]
        public int IdOsoby { get; set; }

        [ForeignKey(nameof(IdOsoby))]
        public Osoba Osoba { get; set; }
    }

    // TABELA: Pokoje
    [Table("Pokoje")]
    public class Pokoj
    {
        [Key]
        [Column("IdPokoju")]
        public int Id { get; set; }

        [Column("NumerPokoju")]
        [Required]
        [MaxLength(10)]
        public string NumerPokoju { get; set; }

        [Column("TypPokoju")]
        [Required]
        [MaxLength(50)]
        public string TypPokoju { get; set; }

        [Column("CenaZaNoc")]
        public decimal CenaZaNoc { get; set; }

        [Column("Status")]
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }

        // Relacja z rezerwacjami
        public ICollection<Rezerwacja> Rezerwacje { get; set; }
    }

    // TABELA: Rezerwacje
    [Table("Rezerwacje")]
    public class Rezerwacja
    {
        [Key]
        [Column("IdRezerwacji")]
        public int Id { get; set; }

        [Column("IdKlienta")]
        public int IdKlienta { get; set; }

        [ForeignKey(nameof(IdKlienta))]
        public Klient Klient { get; set; }

        [Column("IdPokoju")]
        public int IdPokoju { get; set; }

        [ForeignKey(nameof(IdPokoju))]
        public Pokoj Pokoj { get; set; }

        [Column("DataPrzyjazdu")]
        public DateTime DataPrzyjazdu { get; set; }

        [Column("DataWyjazdu")]
        public DateTime DataWyjazdu { get; set; }

        [Column("LiczbaNocy")]
        public int LiczbaNocy { get; set; }

        [Column("KwotaLaczna")]
        public decimal KwotaLaczna { get; set; }

        [Column("StatusRezerwacji")]
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }

        [Column("Uwagi")]
        public string Uwagi { get; set; } // Opcjonalne w SQL (DEFAULT NULL), string domyślnie pozwala na null
    }
}