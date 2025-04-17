using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegacao
{
    public partial class Form2 : Form
    {
        private string nomeUsuario;

        public Form2(string nome)
        {
            InitializeComponent();
            nomeUsuario = nome;
            lblBemVindo.Text = "Bem Vindo " + nomeUsuario;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
