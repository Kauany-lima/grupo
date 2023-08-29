namespace trabalhogrupo
{
    partial class Venda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.tx_marca = new System.Windows.Forms.Label();
            this.tx_valor = new System.Windows.Forms.Label();
            this.tx_desconto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tx_tamanho4 = new System.Windows.Forms.ComboBox();
            this.tx_id1 = new System.Windows.Forms.TextBox();
            this.tx_descricao2 = new System.Windows.Forms.TextBox();
            this.tx_marca3 = new System.Windows.Forms.TextBox();
            this.tx_valor5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_valorfinal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_quantidade = new System.Windows.Forms.TextBox();
            this.tx_desconto6 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.data_atual = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(58, 112);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(91, 21);
            this.label.TabIndex = 1;
            this.label.Text = "Descrição";
            // 
            // tx_marca
            // 
            this.tx_marca.AutoSize = true;
            this.tx_marca.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_marca.Location = new System.Drawing.Point(58, 161);
            this.tx_marca.Name = "tx_marca";
            this.tx_marca.Size = new System.Drawing.Size(62, 21);
            this.tx_marca.TabIndex = 2;
            this.tx_marca.Text = "Marca";
            // 
            // tx_valor
            // 
            this.tx_valor.AutoSize = true;
            this.tx_valor.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_valor.Location = new System.Drawing.Point(458, 66);
            this.tx_valor.Name = "tx_valor";
            this.tx_valor.Size = new System.Drawing.Size(149, 21);
            this.tx_valor.TabIndex = 3;
            this.tx_valor.Text = "Valor da unidade";
            // 
            // tx_desconto
            // 
            this.tx_desconto.AutoSize = true;
            this.tx_desconto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_desconto.Location = new System.Drawing.Point(458, 112);
            this.tx_desconto.Name = "tx_desconto";
            this.tx_desconto.Size = new System.Drawing.Size(86, 21);
            this.tx_desconto.TabIndex = 4;
            this.tx_desconto.Text = "Desconto";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(903, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salvar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(903, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Novo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tx_tamanho4
            // 
            this.tx_tamanho4.FormattingEnabled = true;
            this.tx_tamanho4.Items.AddRange(new object[] {
            "PP",
            "P",
            "M",
            "G",
            "GG",
            "XXG",
            "XXXG"});
            this.tx_tamanho4.Location = new System.Drawing.Point(151, 200);
            this.tx_tamanho4.Name = "tx_tamanho4";
            this.tx_tamanho4.Size = new System.Drawing.Size(116, 24);
            this.tx_tamanho4.TabIndex = 8;
            // 
            // tx_id1
            // 
            this.tx_id1.Location = new System.Drawing.Point(91, 69);
            this.tx_id1.Name = "tx_id1";
            this.tx_id1.Size = new System.Drawing.Size(122, 22);
            this.tx_id1.TabIndex = 9;
            // 
            // tx_descricao2
            // 
            this.tx_descricao2.Location = new System.Drawing.Point(155, 113);
            this.tx_descricao2.Name = "tx_descricao2";
            this.tx_descricao2.Size = new System.Drawing.Size(186, 22);
            this.tx_descricao2.TabIndex = 10;
            // 
            // tx_marca3
            // 
            this.tx_marca3.Location = new System.Drawing.Point(139, 162);
            this.tx_marca3.Name = "tx_marca3";
            this.tx_marca3.Size = new System.Drawing.Size(202, 22);
            this.tx_marca3.TabIndex = 11;
            // 
            // tx_valor5
            // 
            this.tx_valor5.Location = new System.Drawing.Point(613, 65);
            this.tx_valor5.Name = "tx_valor5";
            this.tx_valor5.Size = new System.Drawing.Size(135, 22);
            this.tx_valor5.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data";
            // 
            // tx_valorfinal
            // 
            this.tx_valorfinal.Enabled = false;
            this.tx_valorfinal.Location = new System.Drawing.Point(568, 234);
            this.tx_valorfinal.MaxLength = 100;
            this.tx_valorfinal.Name = "tx_valorfinal";
            this.tx_valorfinal.Size = new System.Drawing.Size(120, 22);
            this.tx_valorfinal.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(994, 237);
            this.dataGridView1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tamanho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Valor Total";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(903, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 32);
            this.button3.TabIndex = 21;
            this.button3.Text = "Fechar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Quantidade";
            // 
            // tx_quantidade
            // 
            this.tx_quantidade.Location = new System.Drawing.Point(151, 240);
            this.tx_quantidade.Name = "tx_quantidade";
            this.tx_quantidade.Size = new System.Drawing.Size(33, 22);
            this.tx_quantidade.TabIndex = 23;
            // 
            // tx_desconto6
            // 
            this.tx_desconto6.Location = new System.Drawing.Point(561, 113);
            this.tx_desconto6.Name = "tx_desconto6";
            this.tx_desconto6.Size = new System.Drawing.Size(144, 22);
            this.tx_desconto6.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(903, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 32);
            this.button4.TabIndex = 24;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // data_atual
            // 
            this.data_atual.Location = new System.Drawing.Point(513, 161);
            this.data_atual.Name = "data_atual";
            this.data_atual.Size = new System.Drawing.Size(273, 22);
            this.data_atual.TabIndex = 25;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(903, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 32);
            this.button5.TabIndex = 26;
            this.button5.Text = "Exportar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1046, 572);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.data_atual);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tx_quantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tx_valorfinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_valor5);
            this.Controls.Add(this.tx_desconto6);
            this.Controls.Add(this.tx_marca3);
            this.Controls.Add(this.tx_descricao2);
            this.Controls.Add(this.tx_id1);
            this.Controls.Add(this.tx_tamanho4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_desconto);
            this.Controls.Add(this.tx_valor);
            this.Controls.Add(this.tx_marca);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Name = "Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label tx_marca;
        private System.Windows.Forms.Label tx_valor;
        private System.Windows.Forms.Label tx_desconto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox tx_tamanho4;
        private System.Windows.Forms.TextBox tx_id1;
        private System.Windows.Forms.TextBox tx_descricao2;
        private System.Windows.Forms.TextBox tx_marca3;
        private System.Windows.Forms.TextBox tx_valor5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_valorfinal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_quantidade;
        private System.Windows.Forms.TextBox tx_desconto6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker data_atual;
        private System.Windows.Forms.Button button5;
    }
}