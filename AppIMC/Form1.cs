namespace AppIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            float imc;
            imc = float.Parse(txbPeso.Text) / (float.Parse(txbAltura.Text) * float.Parse(txbAltura.Text));
            lbIMC.Visible = true;
            lbIMC.Text = imc.ToString();
        }

        private void btMostrarTabela_Click(object sender, EventArgs e)
        {
            if (btMostrarTabela.Text == "Fechar tabela")
            {
                btMostrarTabela.Text = "Mostrar tabela";
                pictureBox2.Visible = false;
            }
            else { 
                btMostrarTabela.Text = "Fechar tabela";
                pictureBox2.Visible = true;
            }
        }
    }
}
