using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projetoCRUD.Models;
using projetoCRUD.BLL;

namespace projetoCRUD.UI
{
    public partial class EditarFilme : Form
    {
        private Filme _filme;
        private MostrarFilme _mostrarFilmeForm;

        public EditarFilme(MostrarFilme mostrarFilme,Filme filme)
        {
            InitializeComponent();
            _filme = filme;
            _mostrarFilmeForm = mostrarFilme;
        }

        private void EditarFilme_Load(object sender, EventArgs e)
        {
            txtNomeFilme.Text = _filme.nomeFilme;
            dateFilme.Value = DateTime.Parse(_filme.dataAssistido);
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            string nomeFilme = txtNomeFilme.Text;
            string dataAssistido = dateFilme.Value.Date.ToString("yyyy-MM-dd");
            _filme.nomeFilme = nomeFilme;
            _filme.dataAssistido = dataAssistido;
            try
            {
                FilmeService filmeService = new FilmeService();
                filmeService.EditarFilme(_filme);
                MessageBox.Show("Filme editado com sucesso!");
                _mostrarFilmeForm.Atualizar();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar o filme: {ex.Message}");
            }
        }
    }
}
