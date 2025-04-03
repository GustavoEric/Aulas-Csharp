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
        string escolha = "";
        private void btCalcular_Click(object sender, EventArgs e)
        {
            float area = float.Parse(txtAltura.Text) * float.Parse(txtComprimento.Text);

            double litros = area / 6;
            litros = litros * 1.10;

            int apenas_latas = (int)Math.Ceiling(litros / 18);
            int apenas_gal = (int)Math.Ceiling(litros / 3.6);

            double preco_apenas_latas = apenas_latas * 80;
            double preco_apenas_gal = apenas_gal * 25;
            int galoes, latas;
            latas = (int)litros / 18;
            double sobra = litros % 18;
            galoes = (int)Math.Ceiling(sobra / 3.6);
            if (escolha == "Galão e Lata")
            {
                ListViewItem galLata = new ListViewItem(area.ToString());
                galLata.SubItems.Add("Galão e Lata");
                galLata.SubItems.Add("Latas de 18L: " + latas+ " e Galões de 3.6L: "+galoes);
                galLata.SubItems.Add("R$ " + (latas * 80 + galoes * 25).ToString() + ",00");
                galLata.BackColor = Color.Green;
                lvlResultados.Items.Add(galLata);
            }
            else if (escolha == "Apenas Galão")
            {
                ListViewItem apenasGalao = new ListViewItem(area.ToString());
                apenasGalao.SubItems.Add("Apenas Galão");
                apenasGalao.SubItems.Add("Galões de 3.6L: " + apenas_gal);
                apenasGalao.SubItems.Add("R$ " + preco_apenas_gal.ToString() + ",00");
                apenasGalao.BackColor = Color.Yellow;
                lvlResultados.Items.Add(apenasGalao);
            }
            else if(escolha == "Apenas Lata")
            { 
                ListViewItem apenasLatas = new ListViewItem(area.ToString());
            apenasLatas.SubItems.Add("Apenas Latas");
            apenasLatas.SubItems.Add("Latas de 18L: " + apenas_latas);
            apenasLatas.SubItems.Add("R$ " + preco_apenas_latas.ToString() + ",00");
            apenasLatas.BackColor = Color.Red;
            lvlResultados.Items.Add(apenasLatas);
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            escolha = "Galão e Lata";
        }

        private void rbLata_CheckedChanged(object sender, EventArgs e)
        {
            escolha = "Apenas Lata";
        }

        private void rbGalao_CheckedChanged(object sender, EventArgs e)
        {
            escolha = "Apenas Galão";   
        }
    }
}
