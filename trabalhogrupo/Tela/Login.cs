using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhogrupo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void tx_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                bool retornooV = usuario.Validadigito(tx_cpf.Text, tx_nome.Text);
                if (retornooV == true)
                {                                     
                    Venda venda = new Venda();
                    venda.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos corretamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
            
        
        }

        private void tx_cadastrar_Click(object sender, EventArgs e)
        {
            tx_cpf.Clear();
            tx_nome.Clear();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }

      
    }
}
