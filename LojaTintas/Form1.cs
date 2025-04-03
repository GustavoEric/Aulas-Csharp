namespace LojaTintas
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvlResultados.View = View.Details;
            lvlResultados.FullRowSelect = true;
            lvlResultados.BackColor = Color.LightBlue;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            float area = float.Parse(txtAltura.Text) * float.Parse(txtComprimento.Text);
            ListViewItem apenasLatas = new ListViewItem(area.ToString());
            double litros = area / 6;
            litros = litros * 1.10;
            int apenas_latas = (int)Math.Ceiling(litros / 18);
            int apenas_gal = (int)Math.Ceiling(litros / 3.6);
            double preco_apenas_latas = apenas_latas * 80;
            double preco_apenas_gal = apenas_gal * 25;
            int latas_gal, latas;
            latas = (int)litros / 18;
            double sobra = litros % 18;
            latas_gal = (int)Math.Ceiling(sobra / 3.6);

            apenasLatas.SubItems.Add("Apenas Latas");
            apenasLatas.SubItems.Add("Latas de 18L: " + apenas_latas);
            apenasLatas.SubItems.Add("R$ "+preco_apenas_latas.ToString()+",00");
            apenasLatas.BackColor = Color.Red;
            lvlResultados.Items.Add(apenasLatas);
            //lvlResultados.Items.Add("Galões de 3.6L: " + apenas_gal);
            //lvlResultados.Items.Add("Preço Latas: " + preco_lata);
            //lvlResultados.Items.Add("Preço Galões: " + preco_gal);
            //lvlResultados.Items.Add("Latas de 18L: " + latas);
            //lvlResultados.Items.Add("Galões de 3.6L: " + latas_gal);


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
