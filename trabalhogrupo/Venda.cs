using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhogrupo
{
    public partial class Venda : Form
    {
        List<Vendaproduto> vendaList = new List<Vendaproduto>();
        public Venda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           

                Login login = new Login();
                Vendaproduto venda = new Vendaproduto();
                Usuario usuario = new Usuario();
               // login.Tag = venda.CPF;
                venda.Id = tx_id1.Text;
                venda.Descricao = tx_descricao2.Text;
                venda.Marca = tx_marca3.Text;
                venda.Tamanho = tx_tamanho4.Text;
                venda.Valor = Convert.ToDouble(tx_valor5.Text);
                venda.Desconto = Convert.ToDouble(tx_desconto6.Text);
                venda.Data = tx_data7.Text;
                double calculoquant = venda.Valor * Convert.ToDouble(textBox1.Text);
                venda.Quantidade = Convert.ToDouble(textBox1.Text);
                venda.Valorfinal = calculoquant - ((calculoquant * venda.Desconto) / (100));
                vendaList.Add(venda);

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = vendaList;

                if(dataGridView1.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                    xcelApp.Application.Workbooks.Add(Type.Missing);
                    for(int i = 1; i < dataGridView1.Columns.Count + 1; i++) 
                    {
                        xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }
                    for(int i = 0; i  < dataGridView1.Rows.Count; i++)
                    {
                        for(int j = 0; i < dataGridView1.Columns.Count; j++)
                        {
                            xcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    xcelApp.Columns.AutoFit();
                    xcelApp.Visible = true;
                }
                //var app = new Microsoft.Office.Interop.Excel.Application();
                //Workbooks wbs = app.Workbooks;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            tx_id1.Clear();
            tx_marca3.Clear();
            tx_valor5.Clear();
            tx_descricao2.Clear();
            tx_desconto6.Clear();
            tx_data7.Clear();
        }

      
        private void button3_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }

        private void tx_valorfinal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
