using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{
    // TABELA: Osoby (G³ówna tabela z danymi personalnymi)
    [Table("osoby")]
    public class Osoba
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Imie")]
        public string Imie { get; set; }

        [Column("Nazwisko")]
        public string Nazwisko { get; set; }

        // W³aœciwoœci nawigacyjne
        public ICollection<Klient> Klienci { get; set; }
        public ICollection<Uzytkownik> Uzytkownicy { get; set; }
        public ICollection<Pracownik> Pracownicy { get; set; }
    }

    // TABELA: Uzytkownicy (Pracownicy loguj¹cy siê do systemu)
    [Table("Uzytkownicy")]
    public class Uzytkownik
    {
        [Key]
        [Column("IdUzytkownika")]
        public int Id { get; set; }

        [Column("Login")]
        public string Login { get; set; }

        [Column("Haslo")]
        public string Haslo { get; set; }

        [Column("Rola")]
        public string Rola { get; set; }

        // Klucz obcy ³¹cz¹cy z tabel¹ Osoby
        [Column("Id_osoby")]
        public int IdOsoby { get; set; }
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
        public string NumerTelefonu { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        // Klucz obcy ³¹cz¹cy z tabel¹ Osoby
        [Column("Id_osoby")]
        public int IdOsoby { get; set; }
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

        // Klucz obcy ³¹cz¹cy z tabel¹ Osoby
        [Column("Id_osoby")]
        public int IdOsoby { get; set; }
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
        public string NumerPokoju { get; set; }

        [Column("TypPokoju")]
        public string TypPokoju { get; set; }

        [Column("CenaZaNoc")]
        public decimal CenaZaNoc { get; set; }

        [Column("Status")]
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
        public Klient Klient { get; set; }

        [Column("IdPokoju")]
        public int IdPokoju { get; set; }
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
        public string Status { get; set; }

        [Column("Uwagi")]
        public string Uwagi { get; set; }
    }
}