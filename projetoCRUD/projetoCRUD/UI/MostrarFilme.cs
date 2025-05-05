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
    public partial class MostrarFilme : Form
    {
        public MostrarFilme()
        {
            InitializeComponent();
        }
        public void Atualizar()
        {
            FilmeService filmeService = new FilmeService();
            List<Filme> lista = filmeService.MostrarFilmes();
            // Limpa a fonte de dados para forçar a atualização
            dgvFilmes.DataSource = null; // Limpar o DataGridView
            dgvFilmes.DataSource = lista; // Atribui a nova lista de filmes

            // Força o DataGridView a se atualizar
            dgvFilmes.Refresh();
        }

        private void MostrarFilme_Load(object sender, EventArgs e)
        {
            FilmeService filmeService = new FilmeService();
            List<Filme> lista = filmeService.MostrarFilmes();
            dgvFilmes.DataSource = lista;
            // 2) Remove colunas de botão existentes (caso recarregue várias vezes)
            foreach (DataGridViewColumn col in dgvFilmes.Columns.Cast<DataGridViewColumn>()
                     .Where(c => c.Name == "btnEdit" || c.Name == "btnDelete").ToList())
            {
                dgvFilmes.Columns.Remove(col);
            }

            // 3) Cria coluna “Editar”
            var btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "Editar";
            btnEdit.Text = "Editar";
            btnEdit.UseColumnTextForButtonValue = true;
            dgvFilmes.Columns.Add(btnEdit);

            // 4) Cria coluna “Excluir”
            var btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "Excluir";
            btnDelete.Text = "Excluir";
            btnDelete.UseColumnTextForButtonValue = true;
            dgvFilmes.Columns.Add(btnDelete);

            // 5) Ajustes visuais
            dgvFilmes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFilmes.AllowUserToAddRows = false;

            // 6) Assina o evento (só uma vez)
            dgvFilmes.CellContentClick -= dgvFilmes_CellContentClick;
            dgvFilmes.CellContentClick += dgvFilmes_CellContentClick;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarFilme adicionarFilme = new(this);
            adicionarFilme.Show();
        }

        private void dgvFilmes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Pega o objeto Filme da linha clicada
            Filme filme = (Filme)dgvFilmes.Rows[e.RowIndex].DataBoundItem;

            if (dgvFilmes.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                MessageBox.Show($"Editar filme: {filme.id}");
                Form editarFilme = new EditarFilme(this,filme);
                editarFilme.Show();
            }
            else if (dgvFilmes.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                Form excluirFilme = new ExcluirFilme(this, filme);
                excluirFilme.Show();
            }
        }
    }
}
