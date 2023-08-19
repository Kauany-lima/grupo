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
    public partial class Cadastrar : Form
    {
        List<Usuario> CadastroUsu = new List<Usuario>();
        public Cadastrar()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Usuario usuario = new Usuario();
            usuario.Name = tx_nome.Text;
            usuario.CPF = tx_cpf.Text ;
            usuario.RG = tx_rg.Text ;
            usuario.Telefone = tx_telefone.Text ;
           usuario.Cidade =  tx_cidade.Text ;
            usuario.Endereco = tx_endereco.Text;
            usuario.CEP = tx_cep.Text;
            CadastroUsu.Add(usuario);
            Venda venda = new Venda();
            venda.ShowDialog();
        }
    }
}
