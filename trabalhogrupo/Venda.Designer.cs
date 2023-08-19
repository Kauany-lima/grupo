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
            this.tx_desconto6 = new System.Windows.Forms.TextBox();
            this.tx_data7 = new System.Windows.Forms.MaskedTextBox();
            this.tx_valor5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_valorfinal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(70, 135);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 16);
            this.label.TabIndex = 1;
            this.label.Text = "Descrição";
            // 
            // tx_marca
            // 
            this.tx_marca.AutoSize = true;
            this.tx_marca.Location = new System.Drawing.Point(75, 172);
            this.tx_marca.Name = "tx_marca";
            this.tx_marca.Size = new System.Drawing.Size(45, 16);
            this.tx_marca.TabIndex = 2;
            this.tx_marca.Text = "Marca";
            // 
            // tx_valor
            // 
            this.tx_valor.AutoSize = true;
            this.tx_valor.Location = new System.Drawing.Point(489, 95);
            this.tx_valor.Name = "tx_valor";
            this.tx_valor.Size = new System.Drawing.Size(39, 16);
            this.tx_valor.TabIndex = 3;
            this.tx_valor.Text = "Valor";
            // 
            // tx_desconto
            // 
            this.tx_desconto.AutoSize = true;
            this.tx_desconto.Location = new System.Drawing.Point(489, 132);
            this.tx_desconto.Name = "tx_desconto";
            this.tx_desconto.Size = new System.Drawing.Size(65, 16);
            this.tx_desconto.TabIndex = 4;
            this.tx_desconto.Text = "Desconto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salvar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
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
            "XGG"});
            this.tx_tamanho4.Location = new System.Drawing.Point(73, 208);
            this.tx_tamanho4.Name = "tx_tamanho4";
            this.tx_tamanho4.Size = new System.Drawing.Size(121, 24);
            this.tx_tamanho4.TabIndex = 8;
            // 
            // tx_id1
            // 
            this.tx_id1.Location = new System.Drawing.Point(109, 88);
            this.tx_id1.Name = "tx_id1";
            this.tx_id1.Size = new System.Drawing.Size(100, 22);
            this.tx_id1.TabIndex = 9;
            // 
            // tx_descricao2
            // 
            this.tx_descricao2.Location = new System.Drawing.Point(151, 132);
            this.tx_descricao2.Name = "tx_descricao2";
            this.tx_descricao2.Size = new System.Drawing.Size(100, 22);
            this.tx_descricao2.TabIndex = 10;
            // 
            // tx_marca3
            // 
            this.tx_marca3.Location = new System.Drawing.Point(142, 172);
            this.tx_marca3.Name = "tx_marca3";
            this.tx_marca3.Size = new System.Drawing.Size(100, 22);
            this.tx_marca3.TabIndex = 11;
            // 
            // tx_desconto6
            // 
            this.tx_desconto6.Location = new System.Drawing.Point(561, 132);
            this.tx_desconto6.Name = "tx_desconto6";
            this.tx_desconto6.Size = new System.Drawing.Size(100, 22);
            this.tx_desconto6.TabIndex = 12;
            // 
            // tx_data7
            // 
            this.tx_data7.Location = new System.Drawing.Point(535, 187);
            this.tx_data7.Mask = "00/00/0000";
            this.tx_data7.Name = "tx_data7";
            this.tx_data7.Size = new System.Drawing.Size(100, 22);
            this.tx_data7.TabIndex = 13;
            // 
            // tx_valor5
            // 
            this.tx_valor5.Location = new System.Drawing.Point(535, 88);
            this.tx_valor5.Name = "tx_valor5";
            this.tx_valor5.Size = new System.Drawing.Size(126, 22);
            this.tx_valor5.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data";
            // 
            // tx_valorfinal
            // 
            this.tx_valorfinal.Location = new System.Drawing.Point(561, 250);
            this.tx_valorfinal.Name = "tx_valorfinal";
            this.tx_valorfinal.Size = new System.Drawing.Size(100, 22);
            this.tx_valorfinal.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 204);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 513);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tx_valorfinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_valor5);
            this.Controls.Add(this.tx_data7);
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
        private System.Windows.Forms.TextBox tx_desconto6;
        private System.Windows.Forms.MaskedTextBox tx_data7;
        private System.Windows.Forms.TextBox tx_valor5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_valorfinal;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}