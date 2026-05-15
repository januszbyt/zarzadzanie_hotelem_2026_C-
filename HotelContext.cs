using Microsoft.EntityFrameworkCore;
using HotelManagement.Models; 

namespace HotelManagement.Data
{
    public class HotelContext : DbContext
    {
        
        public DbSet<Osoba> Osoby { get; set; }
        public DbSet<Uzytkownik> Uzytkownicy { get; set; }
        public DbSet<Klient> Klienci { get; set; }
        public DbSet<Pracownik> Pracownicy { get; set; }
        public DbSet<Pokoj> Pokoje { get; set; }
        public DbSet<Rezerwacja> Rezerwacje { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string server = "eduweb.pwste.edu.pl";
                string database = "HotelParadise";
                string user = "HotelP";
                string password = "PANS!@1234";

                // Konstrukcja ci¹gu po³¹czeniowego
                string connectionString = $"server={server};database={database};user={user};password={password};";

                // Inicjalizacja po³¹czenia
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }
    }
}