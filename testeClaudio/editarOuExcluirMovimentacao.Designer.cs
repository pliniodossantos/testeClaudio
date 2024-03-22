namespace testeClaudio
{
    partial class editarOuExcluirMovimentacao
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
            idMovimentacao = new TextBox();
            idContainer = new TextBox();
            idCliente = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            movimentacao = new ComboBox();
            label4 = new Label();
            dataInicio = new TextBox();
            label5 = new Label();
            dataFinal = new TextBox();
            label6 = new Label();
            btnEdit = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 397);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(735, 231);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idMovimentacao
            // 
            idMovimentacao.Location = new Point(245, 115);
            idMovimentacao.Margin = new Padding(3, 4, 3, 4);
            idMovimentacao.Name = "idMovimentacao";
            idMovimentacao.ReadOnly = true;
            idMovimentacao.Size = new Size(51, 27);
            idMovimentacao.TabIndex = 12;
            // 
            // idContainer
            // 
            idContainer.Location = new Point(245, 173);
            idContainer.Margin = new Padding(3, 4, 3, 4);
            idContainer.Name = "idContainer";
            idContainer.ReadOnly = true;
            idContainer.Size = new Size(51, 27);
            idContainer.TabIndex = 13;
            // 
            // idCliente
            // 
            idCliente.Location = new Point(245, 232);
            idCliente.Margin = new Padding(3, 4, 3, 4);
            idCliente.Name = "idCliente";
            idCliente.ReadOnly = true;
            idCliente.Size = new Size(51, 27);
            idCliente.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 91);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Id Movimentação";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 149);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "Id Conteiner";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 208);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Id Cliente";
            // 
            // movimentacao
            // 
            movimentacao.DropDownStyle = ComboBoxStyle.DropDownList;
            movimentacao.FormattingEnabled = true;
            movimentacao.Items.AddRange(new object[] { "Embarque", "Descarga", "Gate In", "Gate Out", "Reposicionamento", "Pesagem", "Scanner" });
            movimentacao.Location = new Point(362, 115);
            movimentacao.Margin = new Padding(3, 4, 3, 4);
            movimentacao.Name = "movimentacao";
            movimentacao.Size = new Size(159, 28);
            movimentacao.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 91);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 3;
            label4.Text = "Movimentação";
            // 
            // dataInicio
            // 
            dataInicio.Location = new Point(362, 173);
            dataInicio.Margin = new Padding(3, 4, 3, 4);
            dataInicio.Name = "dataInicio";
            dataInicio.Size = new Size(159, 27);
            dataInicio.TabIndex = 7;
            dataInicio.TextChanged += dataInicio_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(393, 149);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 4;
            label5.Text = "Data Início";
            // 
            // dataFinal
            // 
            dataFinal.Location = new Point(362, 232);
            dataFinal.Margin = new Padding(3, 4, 3, 4);
            dataFinal.Name = "dataFinal";
            dataFinal.Size = new Size(159, 27);
            dataFinal.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(393, 208);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 5;
            label6.Text = "Data Fim";
            label6.Click += label6_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(245, 271);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(278, 31);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Confirmar Edição";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(245, 309);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(278, 31);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // editarOuExcluirMovimentacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 693);
            Controls.Add(btnExcluir);
            Controls.Add(btnEdit);
            Controls.Add(label6);
            Controls.Add(dataFinal);
            Controls.Add(label5);
            Controls.Add(dataInicio);
            Controls.Add(label4);
            Controls.Add(movimentacao);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(idCliente);
            Controls.Add(idContainer);
            Controls.Add(idMovimentacao);
            Controls.Add(dataGridView1);
            Name = "editarOuExcluirMovimentacao";
            Text = "editarOuExcluirMovimentacao";
            Load += editarOuExcluirMovimentacao_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox idMovimentacao;
        private TextBox idContainer;
        private TextBox idCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox movimentacao;
        private Label label4;
        private TextBox dataInicio;
        private Label label5;
        private TextBox dataFinal;
        private Label label6;
        private Button btnEdit;
        private Button btnExcluir;
    }
}