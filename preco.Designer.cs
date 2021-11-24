
namespace Salão
{
    partial class preco
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
            this.cb_masc = new System.Windows.Forms.CheckBox();
            this.cb_fem = new System.Windows.Forms.CheckBox();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Desconto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Parcela = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_04 = new System.Windows.Forms.CheckBox();
            this.cb_03 = new System.Windows.Forms.CheckBox();
            this.cb_05 = new System.Windows.Forms.CheckBox();
            this.cb_07 = new System.Windows.Forms.CheckBox();
            this.cb_08 = new System.Windows.Forms.CheckBox();
            this.cb_09 = new System.Windows.Forms.CheckBox();
            this.cb_06 = new System.Windows.Forms.CheckBox();
            this.cb_10 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_masc
            // 
            this.cb_masc.AutoSize = true;
            this.cb_masc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_masc.Location = new System.Drawing.Point(22, 98);
            this.cb_masc.Name = "cb_masc";
            this.cb_masc.Size = new System.Drawing.Size(126, 20);
            this.cb_masc.TabIndex = 0;
            this.cb_masc.Text = "Corte Masculino ";
            this.cb_masc.UseVisualStyleBackColor = true;
            this.cb_masc.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cb_fem
            // 
            this.cb_fem.AutoSize = true;
            this.cb_fem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_fem.Location = new System.Drawing.Point(22, 124);
            this.cb_fem.Name = "cb_fem";
            this.cb_fem.Size = new System.Drawing.Size(117, 20);
            this.cb_fem.TabIndex = 1;
            this.cb_fem.Text = "Corte Feminino";
            this.cb_fem.UseVisualStyleBackColor = true;
            this.cb_fem.CheckedChanged += new System.EventHandler(this.cb_fem_CheckedChanged);
            // 
            // tb_Total
            // 
            this.tb_Total.Location = new System.Drawing.Point(127, 263);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(100, 20);
            this.tb_Total.TabIndex = 2;
            this.tb_Total.TextChanged += new System.EventHandler(this.tb_Total_TextChanged);
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(193, 384);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 3;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // tb_Desconto
            // 
            this.tb_Desconto.Location = new System.Drawing.Point(127, 298);
            this.tb_Desconto.Name = "tb_Desconto";
            this.tb_Desconto.Size = new System.Drawing.Size(100, 20);
            this.tb_Desconto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "A Vista com Desconto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parcelar em 2X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total";
            // 
            // tb_Parcela
            // 
            this.tb_Parcela.Location = new System.Drawing.Point(127, 330);
            this.tb_Parcela.Name = "tb_Parcela";
            this.tb_Parcela.Size = new System.Drawing.Size(100, 20);
            this.tb_Parcela.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_04
            // 
            this.cb_04.AutoSize = true;
            this.cb_04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_04.Location = new System.Drawing.Point(22, 176);
            this.cb_04.Name = "cb_04";
            this.cb_04.Size = new System.Drawing.Size(181, 20);
            this.cb_04.TabIndex = 11;
            this.cb_04.Text = "Progressiva Cabelo Curto";
            this.cb_04.UseVisualStyleBackColor = true;
            this.cb_04.CheckedChanged += new System.EventHandler(this.cb_04_CheckedChanged);
            // 
            // cb_03
            // 
            this.cb_03.AutoSize = true;
            this.cb_03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_03.Location = new System.Drawing.Point(22, 150);
            this.cb_03.Name = "cb_03";
            this.cb_03.Size = new System.Drawing.Size(198, 20);
            this.cb_03.TabIndex = 12;
            this.cb_03.Text = "Corte Feminino com Escova ";
            this.cb_03.UseVisualStyleBackColor = true;
            this.cb_03.CheckedChanged += new System.EventHandler(this.cb_03_CheckedChanged);
            // 
            // cb_05
            // 
            this.cb_05.AutoSize = true;
            this.cb_05.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_05.Location = new System.Drawing.Point(22, 202);
            this.cb_05.Name = "cb_05";
            this.cb_05.Size = new System.Drawing.Size(240, 20);
            this.cb_05.TabIndex = 13;
            this.cb_05.Text = "Progressiva Cabelo Medio e Longo";
            this.cb_05.UseVisualStyleBackColor = true;
            this.cb_05.CheckedChanged += new System.EventHandler(this.cb_05_CheckedChanged);
            // 
            // cb_07
            // 
            this.cb_07.AutoSize = true;
            this.cb_07.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_07.Location = new System.Drawing.Point(382, 124);
            this.cb_07.Name = "cb_07";
            this.cb_07.Size = new System.Drawing.Size(75, 20);
            this.cb_07.TabIndex = 14;
            this.cb_07.Text = "Mechas";
            this.cb_07.UseVisualStyleBackColor = true;
            this.cb_07.CheckedChanged += new System.EventHandler(this.cb_07_CheckedChanged);
            // 
            // cb_08
            // 
            this.cb_08.AutoSize = true;
            this.cb_08.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_08.Location = new System.Drawing.Point(382, 150);
            this.cb_08.Name = "cb_08";
            this.cb_08.Size = new System.Drawing.Size(173, 20);
            this.cb_08.TabIndex = 15;
            this.cb_08.Text = "Sombrancelha Designer";
            this.cb_08.UseVisualStyleBackColor = true;
            this.cb_08.CheckedChanged += new System.EventHandler(this.cb_08_CheckedChanged);
            // 
            // cb_09
            // 
            this.cb_09.AutoSize = true;
            this.cb_09.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_09.Location = new System.Drawing.Point(382, 176);
            this.cb_09.Name = "cb_09";
            this.cb_09.Size = new System.Drawing.Size(144, 20);
            this.cb_09.TabIndex = 16;
            this.cb_09.Text = "Depilação em Cera";
            this.cb_09.UseVisualStyleBackColor = true;
            this.cb_09.CheckedChanged += new System.EventHandler(this.cb_09_CheckedChanged);
            // 
            // cb_06
            // 
            this.cb_06.AutoSize = true;
            this.cb_06.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_06.Location = new System.Drawing.Point(382, 98);
            this.cb_06.Name = "cb_06";
            this.cb_06.Size = new System.Drawing.Size(194, 20);
            this.cb_06.TabIndex = 17;
            this.cb_06.Text = "Botox Hidratação no cabelo";
            this.cb_06.UseVisualStyleBackColor = true;
            this.cb_06.CheckedChanged += new System.EventHandler(this.cb_06_CheckedChanged);
            // 
            // cb_10
            // 
            this.cb_10.AutoSize = true;
            this.cb_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_10.Location = new System.Drawing.Point(382, 202);
            this.cb_10.Name = "cb_10";
            this.cb_10.Size = new System.Drawing.Size(85, 20);
            this.cb_10.TabIndex = 18;
            this.cb_10.Text = "Pé e Mão";
            this.cb_10.UseVisualStyleBackColor = true;
            this.cb_10.CheckedChanged += new System.EventHandler(this.cb_10_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "R$ 25,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "R$ 30,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "R$ 45,00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(273, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "R$ 80,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(273, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "R$ 120,00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(583, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "R$   80,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(583, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "R$ 150,00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(583, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "R$   35,00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(583, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "R$   90,00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(583, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "R$   45,00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(201, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(266, 29);
            this.label15.TabIndex = 30;
            this.label15.Text = "TABELA DE PREÇOS";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // preco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 428);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cb_10);
            this.Controls.Add(this.cb_06);
            this.Controls.Add(this.cb_09);
            this.Controls.Add(this.cb_08);
            this.Controls.Add(this.cb_07);
            this.Controls.Add(this.cb_05);
            this.Controls.Add(this.cb_03);
            this.Controls.Add(this.cb_04);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Parcela);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Desconto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.tb_Total);
            this.Controls.Add(this.cb_fem);
            this.Controls.Add(this.cb_masc);
            this.Name = "preco";
            this.Text = "preco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_masc;
        private System.Windows.Forms.CheckBox cb_fem;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Desconto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Parcela;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cb_04;
        private System.Windows.Forms.CheckBox cb_03;
        private System.Windows.Forms.CheckBox cb_05;
        private System.Windows.Forms.CheckBox cb_07;
        private System.Windows.Forms.CheckBox cb_08;
        private System.Windows.Forms.CheckBox cb_09;
        private System.Windows.Forms.CheckBox cb_06;
        private System.Windows.Forms.CheckBox cb_10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}