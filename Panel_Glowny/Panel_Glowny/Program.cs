using Panele_Glowne;
using System;
using System.Windows.Forms;

namespace Panel_Glowny
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            HotelContext dbContext = new HotelContext();

            if (dbContext.CzyJestPolaczenie())
            {
                Application.Run(new Ekran_Logowania_Klienta());
            }
            else
            {
                Logowanie_do_bazy oknoPolaczenia = new Logowanie_do_bazy();

                if (oknoPolaczenia.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Ekran_Logowania_Klienta());
                }
            }
        }
    }
}