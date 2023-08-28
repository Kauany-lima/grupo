using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhogrupo
{
    public partial class Cadastro : Form
    {
        List<Usuario> Pessoa = new List<Usuario>();
      
        public Cadastro()
        {
            InitializeComponent();
           
        }

        public void button1_Click(object sender, EventArgs e)
        {
           
           
            tabela tabela = new tabela();
            tabela.Refresh();
            tabela.dataGridView1.DataSource = Pessoa;
            tabela.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            tx_cpf.Clear();
            tx_rg.Clear();
            tx_bairro.Clear();
            tx_email.Clear();
            ms_telefone.Clear();
            tx_rua.Clear();
            tx_numero.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Name = tx_nome.Text;
            usuario.CPF = tx_cpf.Text;
            usuario.RG = tx_rg.Text;
            usuario.Email = tx_email.Text;
            usuario.Telefone = ms_telefone.Text;
            usuario.Rua = tx_rua.Text;
            usuario.Bairro = tx_bairro.Text;
            usuario.Numero = tx_numero.Text;
            Pessoa.Add(usuario);
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
