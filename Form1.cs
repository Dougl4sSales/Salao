using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using static System.IO.FileStream;

namespace Salão
{   
    public partial class Form1 : Form
    {
        
        List<Clientes> ListaClientes = new List<Clientes>();

        public object encoder { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Salvar() // Função que salva os dados
        {
            FileStream stream = new FileStream("clients.dat", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();
            encoder.Serialize(stream, ListaClientes);
            stream.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e) // Botão Salvar
        {
            Clientes umCliente = new Clientes();
            umCliente.nome = textBoxNome.Text;
            umCliente.telefone = Convert.ToInt32(textBoxTelefone.Text);
            umCliente.email = textBoxEmail.Text;
            ListaClientes.Add(umCliente);
            //Salvar();
            
            limpaCampo();
        }
        private void limpaCampo() // Função que limpa as caixas de mensagem e ricktextbox
        {
            textBoxNome.Clear();
            textBoxTelefone.Clear();
            textBoxEmail.Clear();
            textBoxValor.Clear();
            richTextBoxResultado.Clear();
        }

        private void buttonMostrar_Click(object sender, EventArgs e) //mostra os dados que foram salvos na ricktexbox
        {
            limpaCampo();
            if (ListaClientes.Count >= 0)
            {
                int i = 0;

                foreach (Clientes umCliente in ListaClientes)
                {
                    richTextBoxResultado.AppendText($"ID: {i}\t Nome: {umCliente.nome}\t Telefone: {umCliente.telefone}\t Email: {umCliente.email}\n");
                    i++;
                }
            }
            /*else 
            {
                richTextBoxResultado.AppendText("Nenhum Cliente Cadastrado");
            }
            carregar();*/
        }
        private void buttonLimpar_Click(object sender, EventArgs e) // botão que limpa os dados
        {
            limpaCampo();
        }
           

        private void buttonExcluir_Click(object sender, EventArgs e) //Ao digitar uma ID exclui os dados da mesma
        {
            int id = int.Parse(textBoxExcluir.Text);
            if (id >= 0 && id < ListaClientes.Count)
                ListaClientes.RemoveAt(id);
                textBoxExcluir.Clear();
                limpaCampo();
                //Salvar();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e) //fecha programa
        {
            Close();
        }

        private void carregar() 
        {
            FileStream stream = new FileStream("clients.dat", FileMode.OpenOrCreate); // função carregar
        }

        private void Voltar_Click(object sender, EventArgs e) // volta para tela incicial
        {
            Menu novo = new Menu();
            novo.Show();
            this.Visible = false;
        }

        private void valores_Click(object sender, EventArgs e) //Vai para tela onde sera exibido os preços
        {
            preco novo = new preco();
            novo.Show();
            this.Visible = false;
        }
    }
        
}
