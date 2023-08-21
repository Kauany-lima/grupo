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
    public partial class Login : Form
    {
        List <Usuario> list = new List<Usuario>();
        public Login()
        {
            InitializeComponent();
        }

        private void tx_entrar_Click(object sender, EventArgs e)
        {
           
            Usuario usuario = new Usuario();
          
            list.Add(usuario);

            Venda venda = new Venda();  
            venda.ShowDialog();
            
           
            
        }

        private void tx_cadastrar_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            textBox1.Clear();
            
        }
    }
}
