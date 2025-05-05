using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projetoCRUD.BLL;
using projetoCRUD.Models;

namespace projetoCRUD.UI
{
    public partial class ExcluirFilme : Form
    {
        private Filme _filme;
        private MostrarFilme _mostrarFilmeForm;
        public ExcluirFilme(MostrarFilme mostrarFilme, Filme filme)
        {
            InitializeComponent();
            _filme = filme;
            _mostrarFilmeForm = mostrarFilme;
        }

        private void ExcluirFilme_Load(object sender, EventArgs e)
        {
            txtNomeFilme.Text = _filme.nomeFilme;
            dateFilme.Value = DateTime.Parse(_filme.dataAssistido);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                FilmeService filmeService = new FilmeService();
                filmeService.ExcluirFilme(_filme.id);
                MessageBox.Show("Filme excluido com sucesso!");
                _mostrarFilmeForm.Atualizar();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir o filme: {ex.Message}");
            }
        }
    }
}
