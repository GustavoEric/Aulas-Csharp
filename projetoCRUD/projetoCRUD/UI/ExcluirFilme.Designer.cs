namespace projetoCRUD.UI
{
    partial class ExcluirFilme
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
            btExcluir = new Button();
            dateFilme = new DateTimePicker();
            label1 = new Label();
            txtNomeFilme = new TextBox();
            SuspendLayout();
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(55, 242);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(273, 29);
            btExcluir.TabIndex = 11;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // dateFilme
            // 
            dateFilme.Location = new Point(56, 185);
            dateFilme.Name = "dateFilme";
            dateFilme.Size = new Size(272, 27);
            dateFilme.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 79);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 9;
            label1.Text = "Nome do filme";
            // 
            // txtNomeFilme
            // 
            txtNomeFilme.Location = new Point(56, 133);
            txtNomeFilme.Name = "txtNomeFilme";
            txtNomeFilme.Size = new Size(272, 27);
            txtNomeFilme.TabIndex = 8;
            // 
            // ExcluirFilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btExcluir);
            Controls.Add(dateFilme);
            Controls.Add(label1);
            Controls.Add(txtNomeFilme);
            Name = "ExcluirFilme";
            Text = "ExcluirFilme";
            Load += ExcluirFilme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btExcluir;
        private DateTimePicker dateFilme;
        private Label label1;
        private TextBox txtNomeFilme;
    }
}