using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panele_Glowne
{
    public partial class Logowanie_do_bazy : Form
    {
        public Logowanie_do_bazy()
        {
            InitializeComponent();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            string podanyLogin = login.Text;
            string podaneHaslo = haslo.Text;

            if (string.IsNullOrWhiteSpace(podanyLogin) || string.IsNullOrWhiteSpace(podaneHaslo))
            {
                MessageBox.Show("Proszę podać login i hasło.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                TunelSSH.Polacz(podanyLogin, podaneHaslo);

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            catch (Renci.SshNet.Common.SshAuthenticationException)
            {
                MessageBox.Show("Błędny login lub hasło! Spróbuj ponownie.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się połączyć z serwerem uczelni:\n" + ex.Message, "Błąd połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}