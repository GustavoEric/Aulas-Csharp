namespace LojaTintas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btCalcular = new Button();
            label1 = new Label();
            txtAltura = new TextBox();
            lvlResultados = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            txtComprimento = new TextBox();
            label2 = new Label();
            rbGalaoLata = new RadioButton();
            rbLata = new RadioButton();
            rbGalao = new RadioButton();
            SuspendLayout();
            // 
            // btCalcular
            // 
            btCalcular.Location = new Point(194, 217);
            btCalcular.Margin = new Padding(3, 4, 3, 4);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(230, 31);
            btCalcular.TabIndex = 0;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 85);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 1;
            label1.Text = "Digite a altura";
            label1.Click += label1_Click;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(64, 153);
            txtAltura.Margin = new Padding(3, 4, 3, 4);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(229, 27);
            txtAltura.TabIndex = 2;
            // 
            // lvlResultados
            // 
            lvlResultados.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvlResultados.FullRowSelect = true;
            lvlResultados.Location = new Point(64, 371);
            lvlResultados.Margin = new Padding(3, 4, 3, 4);
            lvlResultados.Name = "lvlResultados";
            lvlResultados.Size = new Size(791, 212);
            lvlResultados.TabIndex = 3;
            lvlResultados.UseCompatibleStateImageBehavior = false;
            lvlResultados.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Area";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Situação";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "quantidade";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Total";
            // 
            // txtComprimento
            // 
            txtComprimento.Location = new Point(315, 153);
            txtComprimento.Margin = new Padding(3, 4, 3, 4);
            txtComprimento.Name = "txtComprimento";
            txtComprimento.Size = new Size(229, 27);
            txtComprimento.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 85);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 5;
            label2.Text = "Digite o comprimento";
            // 
            // rbGalaoLata
            // 
            rbGalaoLata.AutoSize = true;
            rbGalaoLata.Location = new Point(56, 301);
            rbGalaoLata.Margin = new Padding(3, 4, 3, 4);
            rbGalaoLata.Name = "rbGalaoLata";
            rbGalaoLata.Size = new Size(113, 24);
            rbGalaoLata.TabIndex = 6;
            rbGalaoLata.TabStop = true;
            rbGalaoLata.Text = "Galão e Lata";
            rbGalaoLata.UseVisualStyleBackColor = true;
            rbGalaoLata.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbLata
            // 
            rbLata.AutoSize = true;
            rbLata.Location = new Point(224, 301);
            rbLata.Margin = new Padding(3, 4, 3, 4);
            rbLata.Name = "rbLata";
            rbLata.Size = new Size(111, 24);
            rbLata.TabIndex = 7;
            rbLata.TabStop = true;
            rbLata.Text = "Apenas Lata";
            rbLata.UseVisualStyleBackColor = true;
            rbLata.CheckedChanged += rbLata_CheckedChanged;
            // 
            // rbGalao
            // 
            rbGalao.AutoSize = true;
            rbGalao.Location = new Point(407, 301);
            rbGalao.Margin = new Padding(3, 4, 3, 4);
            rbGalao.Name = "rbGalao";
            rbGalao.Size = new Size(122, 24);
            rbGalao.TabIndex = 8;
            rbGalao.TabStop = true;
            rbGalao.Text = "Apenas Galão";
            rbGalao.UseVisualStyleBackColor = true;
            rbGalao.CheckedChanged += rbGalao_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(914, 600);
            Controls.Add(rbGalao);
            Controls.Add(rbLata);
            Controls.Add(rbGalaoLata);
            Controls.Add(label2);
            Controls.Add(txtComprimento);
            Controls.Add(lvlResultados);
            Controls.Add(txtAltura);
            Controls.Add(label1);
            Controls.Add(btCalcular);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCalcular;
        private Label label1;
        private TextBox txtAltura;
        private ListView lvlResultados;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txtComprimento;
        private Label label2;
        private RadioButton rbGalaoLata;
        private RadioButton rbLata;
        private RadioButton rbGalao;
    }
}
