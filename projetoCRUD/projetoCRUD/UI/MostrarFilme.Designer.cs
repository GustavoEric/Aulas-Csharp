namespace projetoCRUD.UI
{
    partial class MostrarFilme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvFilmes = new DataGridView();
            btAdicionar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).BeginInit();
            SuspendLayout();
            // 
            // dgvFilmes
            // 
            dgvFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmes.Location = new Point(77, 181);
            dgvFilmes.Name = "dgvFilmes";
            dgvFilmes.RowHeadersWidth = 51;
            dgvFilmes.Size = new Size(574, 210);
            dgvFilmes.TabIndex = 1;
            dgvFilmes.CellContentClick += dgvFilmes_CellContentClick;
            // 
            // btAdicionar
            // 
            btAdicionar.Location = new Point(597, 84);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(94, 29);
            btAdicionar.TabIndex = 2;
            btAdicionar.Text = "Adicionar";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // MostrarFilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btAdicionar);
            Controls.Add(dgvFilmes);
            Name = "MostrarFilme";
            Text = "MostrarFilme";
            Load += MostrarFilme_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFilmes;
        private Button btAdicionar;
        private System.Windows.Forms.Timer timer1;
    }
}