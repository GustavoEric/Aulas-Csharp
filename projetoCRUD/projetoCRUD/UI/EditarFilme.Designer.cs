namespace projetoCRUD.UI
{
    partial class EditarFilme
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
            btEditar = new Button();
            dateFilme = new DateTimePicker();
            label1 = new Label();
            txtNomeFilme = new TextBox();
            SuspendLayout();
            // 
            // btEditar
            // 
            btEditar.Location = new Point(89, 234);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(273, 29);
            btEditar.TabIndex = 7;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // dateFilme
            // 
            dateFilme.Location = new Point(90, 177);
            dateFilme.Name = "dateFilme";
            dateFilme.Size = new Size(272, 27);
            dateFilme.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 71);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 5;
            label1.Text = "Nome do filme";
            // 
            // txtNomeFilme
            // 
            txtNomeFilme.Location = new Point(90, 125);
            txtNomeFilme.Name = "txtNomeFilme";
            txtNomeFilme.Size = new Size(272, 27);
            txtNomeFilme.TabIndex = 4;
            // 
            // EditarFilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btEditar);
            Controls.Add(dateFilme);
            Controls.Add(label1);
            Controls.Add(txtNomeFilme);
            Name = "EditarFilme";
            Text = "EditarFilme";
            Load += EditarFilme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEditar;
        private DateTimePicker dateFilme;
        private Label label1;
        private TextBox txtNomeFilme;
    }
}