using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_POO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // instanciar a classe
            Pessoa PessoaLinda = new Pessoa();
            // passar o conteudo que vai ser digitado para as variaveis 
            PessoaLinda.setNome(textBox1.Text);
            try
            {
                PessoaLinda.setIdade(int.Parse(textBox2.Text));
                // obter o nome e da idade ↓
                string xnome = PessoaLinda.getNome();
                int xidade = PessoaLinda.getIdade();
                string strsaida = " Nome da Pessoa : " + xnome.ToUpper() + "\n\n" + "Idade :" + xidade.ToString();
                MessageBox.Show(strsaida, " ****Resultado****",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message+"\n\nTente Novamente ;(" , "****** ERRO DE ENTRADA ***",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string texto = "Deseja Sair da Aplicação?";
            string titulo = "*** FINALIZANDO APLICAÇÃO";
            if (MessageBox.Show(texto, titulo,
                MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        
    }
}
