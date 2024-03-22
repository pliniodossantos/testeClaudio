namespace testeClaudio
{
    partial class editarOuExcluirConteiner
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
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            categoria = new ComboBox();
            status = new ComboBox();
            tipo = new ComboBox();
            letrasConteiner = new TextBox();
            idcliente = new TextBox();
            idConteiner = new TextBox();
            label6 = new Label();
            btnEdit = new Button();
            btnExc = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(81, 329);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(727, 200);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(678, 67);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 5;
            label5.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(579, 67);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 4;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 67);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 3;
            label3.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 67);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 2;
            label2.Text = "Código Conteiner";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 67);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Id Cliente";
            // 
            // categoria
            // 
            categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            categoria.FormattingEnabled = true;
            categoria.Items.AddRange(new object[] { "Importação", "Exportação" });
            categoria.Location = new Point(665, 91);
            categoria.Name = "categoria";
            categoria.Size = new Size(106, 28);
            categoria.TabIndex = 11;
            // 
            // status
            // 
            status.DropDownStyle = ComboBoxStyle.DropDownList;
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "Cheio", "Vazio" });
            status.Location = new Point(562, 91);
            status.Name = "status";
            status.Size = new Size(79, 28);
            status.TabIndex = 10;
            // 
            // tipo
            // 
            tipo.AutoCompleteCustomSource.AddRange(new string[] { "20", "40" });
            tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            tipo.FormattingEnabled = true;
            tipo.Items.AddRange(new object[] { "20", "40" });
            tipo.Location = new Point(457, 89);
            tipo.Name = "tipo";
            tipo.Size = new Size(79, 28);
            tipo.TabIndex = 9;
            // 
            // letrasConteiner
            // 
            letrasConteiner.Location = new Point(307, 89);
            letrasConteiner.MaxLength = 11;
            letrasConteiner.Name = "letrasConteiner";
            letrasConteiner.Size = new Size(132, 27);
            letrasConteiner.TabIndex = 8;
            // 
            // idcliente
            // 
            idcliente.Location = new Point(206, 91);
            idcliente.Margin = new Padding(3, 4, 3, 4);
            idcliente.Name = "idcliente";
            idcliente.ReadOnly = true;
            idcliente.Size = new Size(79, 27);
            idcliente.TabIndex = 7;
            // 
            // idConteiner
            // 
            idConteiner.Location = new Point(103, 91);
            idConteiner.Margin = new Padding(3, 4, 3, 4);
            idConteiner.Name = "idConteiner";
            idConteiner.ReadOnly = true;
            idConteiner.Size = new Size(81, 27);
            idConteiner.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(103, 67);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 0;
            label6.Text = "Id Conteiner";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(103, 143);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(183, 31);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Confirmar Edição";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button1_Click;
            // 
            // btnExc
            // 
            btnExc.Location = new Point(293, 143);
            btnExc.Margin = new Padding(3, 4, 3, 4);
            btnExc.Name = "btnExc";
            btnExc.Size = new Size(183, 31);
            btnExc.TabIndex = 13;
            btnExc.Text = "Excluir";
            btnExc.UseVisualStyleBackColor = true;
            btnExc.Click += btnExc_Click;
            // 
            // editarOuExcluirConteiner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnExc);
            Controls.Add(btnEdit);
            Controls.Add(label6);
            Controls.Add(idConteiner);
            Controls.Add(idcliente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(categoria);
            Controls.Add(status);
            Controls.Add(tipo);
            Controls.Add(letrasConteiner);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "editarOuExcluirConteiner";
            Text = "editarOuExcluirConteiner";
            Load += editarOuExcluirConteiner_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox categoria;
        private ComboBox status;
        private ComboBox tipo;
        private TextBox letrasConteiner;
        private TextBox idcliente;
        private TextBox idConteiner;
        private Label label6;
        private Button btnEdit;
        private Button btnExc;
    }
}