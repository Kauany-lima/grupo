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


                // Instanciando a class venda produto e passando seus valores de acordo com o form
                Vendaproduto venda = new Vendaproduto();
                venda.Id = tx_id1.Text;
                venda.Descricao = tx_descricao2.Text;
                venda.Marca = tx_marca3.Text;
                venda.Tamanho = tx_tamanho4.Text;
                venda.Valor = Convert.ToDouble(tx_valor5.Text);
                venda.Desconto = Convert.ToDouble(tx_desconto6.Text);
                venda.Data = tx_data7.Text;
                venda.Quantidade = Convert.ToDouble(tx_quantidade.Text);

                //Calculando a quantidade de determinada peça
                double calculoquant = venda.Valor * Convert.ToDouble(tx_quantidade.Text);


                //Calculando o desconto
                venda.Valorfinal = calculoquant - ((calculoquant * venda.Desconto) / (100));
                vendaList.Add(venda);

                //Passando para o datagridview o registro da peça de roupa
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = vendaList;
              
                



                //comando para conectar datagridview com excel
                if (dataGridView1.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                    Excel.Workbook xlWorkbook = xcelApp.Workbooks.Open("C:\\Users\\claud\\source\\repos\\trabalhogrupo\\01.xlsx");
                    xcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            xcelApp.Cells[i + 2, j - 1] = dataGridView1.Rows[1].Cells[j].Value.ToString();

                        }
                    }
                    xcelApp.Columns.AutoFit();
                    xcelApp.Visible = true;
               
                }
               
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
            tx_data7.Clear();
            tx_quantidade.Clear();  

        }

      
        private void button3_Click_1(object sender, EventArgs e)
        {
            //Voltando para area de login
            Login login = new Login();
            login.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //botão para excluir a lista desejada 
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                vendaList.RemoveAt(index);

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = vendaList;
            }
            catch
            {
                Console.WriteLine("Notamos Algum erro!");
            }
        }
    }
}
