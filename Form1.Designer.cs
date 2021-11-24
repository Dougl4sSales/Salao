
namespace Salão
{
    partial class Form1
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.richTextBoxResultado = new System.Windows.Forms.RichTextBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.textBoxExcluir = new System.Windows.Forms.TextBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.valores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(100, 122);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 0;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(32, 240);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 24);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(32, 279);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(75, 23);
            this.buttonMostrar.TabIndex = 2;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // richTextBoxResultado
            // 
            this.richTextBoxResultado.Location = new System.Drawing.Point(137, 231);
            this.richTextBoxResultado.Name = "richTextBoxResultado";
            this.richTextBoxResultado.Size = new System.Drawing.Size(618, 207);
            this.richTextBoxResultado.TabIndex = 3;
            this.richTextBoxResultado.Text = "";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(32, 321);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 4;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "SALÃO DE BELEZA";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(100, 165);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefone.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(301, 125);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 11;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(300, 165);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor.TabIndex = 12;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(505, 125);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 14;
            this.buttonExcluir.Text = "Excluir\\ID";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // textBoxExcluir
            // 
            this.textBoxExcluir.Location = new System.Drawing.Point(600, 128);
            this.textBoxExcluir.Name = "textBoxExcluir";
            this.textBoxExcluir.Size = new System.Drawing.Size(100, 20);
            this.textBoxExcluir.TabIndex = 15;
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(32, 405);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 16;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(32, 364);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 23);
            this.Voltar.TabIndex = 17;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // valores
            // 
            this.valores.Location = new System.Drawing.Point(505, 167);
            this.valores.Name = "valores";
            this.valores.Size = new System.Drawing.Size(75, 23);
            this.valores.TabIndex = 18;
            this.valores.Text = "Preços";
            this.valores.UseVisualStyleBackColor = true;
            this.valores.Click += new System.EventHandler(this.valores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valores);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.textBoxExcluir);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.richTextBoxResultado);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxNome);
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.RichTextBox richTextBoxResultado;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.TextBox textBoxExcluir;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button valores;
    }
}

