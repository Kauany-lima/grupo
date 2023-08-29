using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
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
using System.IO;

namespace trabalhogrupo
{
    public partial class Venda : Form
    {
        //Lista de peça cadastrada
        List<Vendaproduto> vendaList = new List<Vendaproduto>();
        public Venda()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {


                //Instanciando a classe venda produto e passando seus valores de acordo com o form
                Vendaproduto venda = new Vendaproduto();
                venda.Id = tx_id1.Text;
                venda.Descricao = tx_descricao2.Text;
                venda.Marca = tx_marca3.Text;
                venda.Tamanho = tx_tamanho4.Text;
                venda.Valor = Convert.ToDouble(tx_valor5.Text);
                venda.Desconto = Convert.ToDouble(tx_desconto6.Text);
                venda.Data = data_atual.Text;
                venda.Quantidade = Convert.ToDouble(tx_quantidade.Text);

                //Calculando a quantidade de determinada peça
                double calculoquant = venda.Valor * Convert.ToDouble(tx_quantidade.Text);


                //Calculando o desconto
                venda.Valorfinal = calculoquant - ((calculoquant * venda.Desconto) / (100));


                //Passando para o datagridview o registro da peça de roupa
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = vendaList;
                vendaList.Add(venda);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha o campo corretamente " + ex.Message);
            }

           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // remove todos os textos das lacunas para registrar uma nova peça
            tx_id1.Clear();
            tx_marca3.Clear();
            tx_valor5.Clear();
            tx_descricao2.Clear();
            tx_desconto6.Clear();           
            tx_quantidade.Clear();  

        }

      
        private void button3_Click_1(object sender, EventArgs e)
        {
            //Voltando para area de login
            this.Close();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //botão para excluir a lista desejada 
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                vendaList.RemoveAt(index);
                dataGridView1.Refresh();
                dataGridView1.DataSource = vendaList;
            }
            catch
            {
                Console.WriteLine("Notamos Algum erro!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int colunas = dataGridView1.Columns.Count; //Definindo as colunas do dataggridview
            int linhas = dataGridView1.RowCount; //definindo as linhas do datagridgview

            string nome = "teste";

            string texto = "";

            for (int i = 0; i < linhas; i++)    //Percorre linhas
            {
                for (int j = 0; j < colunas; j++)   //percorre colunas
                {
                    var item = dataGridView1[j, i];

                    if (item.Value == null)
                    {
                        item.Value = "";
                    }

                    texto += item.Value.ToString();

                    if (j < colunas - 1)
                    {

                        texto += ";"; //as colunas é separadas por ;
                    }
                }

                texto += "\n";

            }


            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + nome + ".csv";
            //caminho

            try
            {
                File.WriteAllText(path, texto);

                MessageBox.Show("O arquivo foi salvo em: " + path);
            }
            catch (IOException error)
            {
                MessageBox.Show("Ocorreu um erro ao escrever arquivo: " + error.Message);

            }
        }
    }
}
