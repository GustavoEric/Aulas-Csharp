namespace Navegacao
{
    public partial class Form1 : Form
    {
        // Declare the field with a valid type and name  
        public string nome;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            Form2 form2 = new Form2(nome);
            form2.Show();
            this.Hide();
        }
    }
}
