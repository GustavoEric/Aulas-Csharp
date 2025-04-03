namespace AppIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txbPeso = new TextBox();
            txbAltura = new TextBox();
            btCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btMostrarTabela = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            lbIMC = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txbPeso
            // 
            txbPeso.Location = new Point(110, 127);
            txbPeso.Margin = new Padding(3, 4, 3, 4);
            txbPeso.Name = "txbPeso";
            txbPeso.Size = new Size(185, 27);
            txbPeso.TabIndex = 0;
            // 
            // txbAltura
            // 
            txbAltura.Location = new Point(110, 33);
            txbAltura.Margin = new Padding(3, 4, 3, 4);
            txbAltura.Name = "txbAltura";
            txbAltura.Size = new Size(185, 27);
            txbAltura.TabIndex = 1;
            // 
            // btCalcular
            // 
            btCalcular.Location = new Point(110, 181);
            btCalcular.Margin = new Padding(3, 4, 3, 4);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(86, 31);
            btCalcular.TabIndex = 2;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 83);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 3;
            label1.Text = "Peso (Kg)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 9);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "Altura (m)";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(751, 9);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btMostrarTabela
            // 
            btMostrarTabela.Location = new Point(325, 201);
            btMostrarTabela.Margin = new Padding(3, 4, 3, 4);
            btMostrarTabela.Name = "btMostrarTabela";
            btMostrarTabela.Size = new Size(176, 31);
            btMostrarTabela.TabIndex = 6;
            btMostrarTabela.Text = "Mostrar Tabela";
            btMostrarTabela.UseVisualStyleBackColor = true;
            btMostrarTabela.Click += btMostrarTabela_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(178, 240);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(486, 362);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F);
            label3.Location = new Point(512, 33);
            label3.Name = "label3";
            label3.Size = new Size(78, 45);
            label3.TabIndex = 8;
            label3.Text = "IMC";
            // 
            // lbIMC
            // 
            lbIMC.AutoSize = true;
            lbIMC.Font = new Font("Segoe UI", 12F);
            lbIMC.ForeColor = Color.Red;
            lbIMC.Location = new Point(525, 89);
            lbIMC.Name = "lbIMC";
            lbIMC.Size = new Size(47, 28);
            lbIMC.TabIndex = 9;
            lbIMC.Text = "IMC";
            lbIMC.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(862, 644);
            Controls.Add(lbIMC);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(btMostrarTabela);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btCalcular);
            Controls.Add(txbAltura);
            Controls.Add(txbPeso);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbPeso;
        private TextBox txbAltura;
        private Button btCalcular;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btMostrarTabela;
        private PictureBox pictureBox2;
        private Label label3;
        private Label lbIMC;
    }
}
