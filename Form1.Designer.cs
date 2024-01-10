namespace SORTEIOS
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            textItemLinha = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textMaisSorteado = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            btnArquivo = new Button();
            label2 = new Label();
            label1 = new Label();
            textValorMaximo = new TextBox();
            textValorMinimo = new TextBox();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            lblNumSorteados = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textItemLinha);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textMaisSorteado);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnArquivo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textValorMaximo);
            groupBox1.Controls.Add(textValorMinimo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(870, 119);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(341, 65);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 12;
            label6.Text = "Max 14";
            // 
            // textItemLinha
            // 
            textItemLinha.Location = new Point(293, 61);
            textItemLinha.Name = "textItemLinha";
            textItemLinha.Size = new Size(40, 23);
            textItemLinha.TabIndex = 4;
            textItemLinha.KeyDown += pressionaEnter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 64);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 11;
            label5.Text = "Item Linha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 90);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 10;
            label4.Text = "Nº mais sorteados:";
            // 
            // textMaisSorteado
            // 
            textMaisSorteado.Location = new Point(123, 87);
            textMaisSorteado.Name = "textMaisSorteado";
            textMaisSorteado.Size = new Size(75, 23);
            textMaisSorteado.TabIndex = 5;
            textMaisSorteado.Text = "10";
            textMaisSorteado.KeyDown += pressionaEnter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "LOTO MANIA", "MEGA SENA", "LOTO FACIL" });
            comboBox1.Location = new Point(98, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 3;
            comboBox1.KeyDown += pressionaEnter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 61);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 7;
            label3.Text = "Tipo de Aposta:";
            // 
            // btnArquivo
            // 
            btnArquivo.Location = new Point(437, 22);
            btnArquivo.Name = "btnArquivo";
            btnArquivo.Size = new Size(131, 83);
            btnArquivo.TabIndex = 6;
            btnArquivo.Text = "Carregar Arquivo";
            btnArquivo.UseVisualStyleBackColor = true;
            btnArquivo.Click += btnArquivo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 30);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 3;
            label2.Text = "até";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 2;
            label1.Text = "Concurso de:";
            // 
            // textValorMaximo
            // 
            textValorMaximo.Location = new Point(233, 27);
            textValorMaximo.Name = "textValorMaximo";
            textValorMaximo.Size = new Size(100, 23);
            textValorMaximo.TabIndex = 1;
            textValorMaximo.Text = "2";
            textValorMaximo.KeyDown += pressionaEnter;
            // 
            // textValorMinimo
            // 
            textValorMinimo.Location = new Point(98, 27);
            textValorMinimo.Name = "textValorMinimo";
            textValorMinimo.Size = new Size(100, 23);
            textValorMinimo.TabIndex = 0;
            textValorMinimo.Text = "1";
            textValorMinimo.KeyDown += pressionaEnter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel1);
            groupBox2.Location = new Point(12, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(870, 356);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nº Sorteados";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(lblNumSorteados);
            panel1.Location = new Point(11, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(853, 328);
            panel1.TabIndex = 1;
            // 
            // lblNumSorteados
            // 
            lblNumSorteados.AutoSize = true;
            lblNumSorteados.Font = new Font("Segoe UI", 15F);
            lblNumSorteados.ForeColor = Color.Red;
            lblNumSorteados.Location = new Point(13, 13);
            lblNumSorteados.Name = "lblNumSorteados";
            lblNumSorteados.Size = new Size(54, 28);
            lblNumSorteados.TabIndex = 0;
            lblNumSorteados.Text = "label";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 542);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Números Sorteados";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtFim;
        private TextBox txtInicio;
        private Label label2;
        private Label label3;
        private Button btnArquivo;
        private GroupBox groupBox2;
        private Label lblNumSorteados;
        private ComboBox comboBox1;
        private TextBox textValorMinimo;
        private TextBox textValorMaximo;
        private Label label4;
        private TextBox textMaisSorteado;
        private TextBox textItemLinha;
        private Label label5;
        private Label label6;
        private Panel panel1;
    }
}
