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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            SuspendLayout();
            // 
            // btCalcular
            // 
            btCalcular.Location = new Point(170, 163);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(201, 23);
            btCalcular.TabIndex = 0;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 64);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Digite a altura";
            label1.Click += label1_Click;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(56, 115);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(201, 23);
            txtAltura.TabIndex = 2;
            // 
            // lvlResultados
            // 
            lvlResultados.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvlResultados.Location = new Point(56, 278);
            lvlResultados.Name = "lvlResultados";
            lvlResultados.Size = new Size(421, 160);
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
            txtComprimento.Location = new Point(276, 115);
            txtComprimento.Name = "txtComprimento";
            txtComprimento.Size = new Size(201, 23);
            txtComprimento.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 64);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 5;
            label2.Text = "Digite o comprimento";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(49, 226);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(89, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Galão e Lata";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(196, 226);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(89, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Apenas Lata";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(356, 226);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(97, 19);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "Apenas Galão";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(txtComprimento);
            Controls.Add(lvlResultados);
            Controls.Add(txtAltura);
            Controls.Add(label1);
            Controls.Add(btCalcular);
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
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}
