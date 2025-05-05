using projetoCRUD.BLL;
using projetoCRUD.Models;
namespace projetoCRUD.UI
{
    public partial class AdicionarFilme : Form
    {
        private MostrarFilme _mostrarFilmeForm; // Instância de MostrarFilme
        public AdicionarFilme(MostrarFilme mostrarFilme)
        {
            InitializeComponent();
            _mostrarFilmeForm = mostrarFilme; // Usa a instância que foi passada
        }

        private void AdicionarFilme_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filme _filme = new Filme();
            string nomeFilme = txtNomeFilme.Text;
            string dataAssistido = dateFilme.Value.Date.ToString("yyyy-MM-dd");

            _filme.nomeFilme = nomeFilme;
            _filme.dataAssistido = dataAssistido;

            try
            {
                FilmeService filmeService = new FilmeService();
                filmeService.AdicionarFilme(_filme);
                MessageBox.Show("Filme adicionado com sucesso!");
                _mostrarFilmeForm.Atualizar();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar o filme: {ex.Message}");
            }


        }
    }
}
