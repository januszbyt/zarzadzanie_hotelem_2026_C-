namespace Panele_Glowne;


public partial class EkranLogowania : Form
{
    public EkranLogowania()
    {
        InitializeComponent();
    }
    private void button3_Click(object sender, EventArgs e)
    {
        EkranRejestracji przejscieDoRejestracji = new EkranRejestracji();
        przejscieDoRejestracji.Show();

        this.Hide();
    }
    private void button2_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

}

