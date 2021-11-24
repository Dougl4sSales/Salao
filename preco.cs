using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salão
{
    public partial class preco : Form
    {
        public preco()
        {
            InitializeComponent();
        }
        double valor = 0;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_masc.Checked)
            {
                valor = valor + 25.00;
            }
        }

        private void cb_fem_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_fem.Checked)
            {
                valor = valor + 30.00;
            }
        }

        private void tb_Total_TextChanged(object sender, EventArgs e)
        {
                        
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            tb_Total.Text = Convert.ToString(valor)+" R$";       
            
            if (valor>100 & valor<=120)     //SE VALOR SUPERIOR A 100 R$ CONCEDER DESCONTO DE 10%
            {
                label1.Text="CONCEDER 10% DE DESCONTO";
                tb_Desconto.Text = Convert.ToString(valor-((valor*10)/100))+" R$";
                
            }
            else if (valor>120)             //SE VALOR SUPERIOR A 120 DA ESCOLHA AO CLIENTE
            {
                label1.Text = "CONCEDER 10% DE DESCONTO(A VISTA) OU PARCELAR EM 2X SEM JUROS";
                tb_Desconto.Text = Convert.ToString(valor - ((valor * 10) / 100)) + " R$";
                tb_Parcela.Text = Convert.ToString(valor/2)+" R$";
            }
            else
            {
                label1.Text="";
                tb_Desconto.Text = "0";
                tb_Parcela.Text = "0";
            }
            
        }

        private void button1_Click(object sender, EventArgs e) //BOTÃO LIMPA PREÇOS
        {
            cb_masc.Checked=false;
            cb_fem.Checked=false;
            cb_03.Checked=false;
            cb_04.Checked = false;
            cb_05.Checked = false;
            cb_06.Checked = false;
            cb_07.Checked = false;
            cb_08.Checked = false;
            cb_09.Checked = false;
            cb_10.Checked = false;
            label1.Text = "";
            tb_Total.Text = "";
            tb_Desconto.Text = "";
            tb_Parcela.Text = "";
            valor = 0;
        }

        private void cb_03_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_03.Checked)
            {
                valor = valor + 45.00;
            }
        }

        private void cb_04_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_04.Checked)
            {
                valor = valor + 80.00;
            }
        }

        private void cb_05_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_05.Checked)
            {
                valor = valor + 120.00;
            }
        }

        private void cb_06_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_06.Checked)
            {
                valor = valor + 80.00;
            }
        }

        private void cb_07_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_07.Checked)
            {
                valor = valor + 150.00;
            }
        }

        private void cb_08_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_08.Checked)
            {
                valor = valor + 35.00;
            }
        }

        private void cb_09_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_09.Checked)
            {
                valor = valor + 90.00;
            }
        }

        private void cb_10_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_10.Checked)
            {
                valor = valor + 45.00;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();
            this.Visible = false;
        }
    }
}
