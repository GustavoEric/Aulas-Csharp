namespace projetoCRUD.UI
{
    partial class AdicionarFilme
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
            txtNomeFilme = new TextBox();
            label1 = new Label();
            dateFilme = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtNomeFilme
            // 
            txtNomeFilme.Location = new Point(113, 99);
            txtNomeFilme.Name = "txtNomeFilme";
            txtNomeFilme.Size = new Size(272, 27);
            txtNomeFilme.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 45);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome do filme";
            // 
            // dateFilme
            // 
            dateFilme.Location = new Point(113, 151);
            dateFilme.Name = "dateFilme";
            dateFilme.Size = new Size(272, 27);
            dateFilme.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(112, 208);
            button1.Name = "button1";
            button1.Size = new Size(273, 29);
            button1.TabIndex = 3;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdicionarFilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dateFilme);
            Controls.Add(label1);
            Controls.Add(txtNomeFilme);
            Name = "AdicionarFilme";
            Text = "AdicionarFilme";
            Load += AdicionarFilme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeFilme;
        private Label label1;
        private DateTimePicker dateFilme;
        private Button button1;
    }
}