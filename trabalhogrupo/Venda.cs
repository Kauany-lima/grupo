﻿using System;
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
    public partial class Venda : Form
    {
        List<Vendaproduto> vendaList = new List<Vendaproduto>();
        public Venda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                Vendaproduto venda = new Vendaproduto();
              
                venda.Id = tx_id1.Text;
                venda.Descricao = tx_descricao2.Text;
                venda.Marca = tx_marca3.Text;
                venda.Tamanho = tx_tamanho4.Text;
                venda.Valor = Convert.ToDouble(tx_valor5.Text);
                venda.Desconto = Convert.ToDouble(tx_desconto6.Text);
                venda.Data = tx_data7.Text;
                double calculoquant = venda .Valor * Convert.ToDouble(textBox1.Text) ;
                venda.Quantidade = Convert.ToDouble(textBox1.Text);
                venda.Valorfinal = calculoquant - ((calculoquant * venda.Desconto) / (100));
                vendaList.Add(venda);
                               
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = vendaList;
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
    }
}
