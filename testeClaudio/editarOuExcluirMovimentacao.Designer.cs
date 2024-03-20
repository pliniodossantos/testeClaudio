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
            dataGridView1.Location = new Point(12, 298);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(643, 173);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idMovimentacao
            // 
            idMovimentacao.Location = new Point(214, 86);
            idMovimentacao.Name = "idMovimentacao";
            idMovimentacao.ReadOnly = true;
            idMovimentacao.Size = new Size(45, 23);
            idMovimentacao.TabIndex = 1;
            // 
            // idContainer
            // 
            idContainer.Location = new Point(214, 130);
            idContainer.Name = "idContainer";
            idContainer.ReadOnly = true;
            idContainer.Size = new Size(45, 23);
            idContainer.TabIndex = 2;
            // 
            // idCliente
            // 
            idCliente.Location = new Point(214, 174);
            idCliente.Name = "idCliente";
            idCliente.ReadOnly = true;
            idCliente.Size = new Size(45, 23);
            idCliente.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 68);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 4;
            label1.Text = "Id Movimentação";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 112);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 5;
            label2.Text = "Id Conteiner";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 156);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Id Cliente";
            // 
            // movimentacao
            // 
            movimentacao.DropDownStyle = ComboBoxStyle.DropDownList;
            movimentacao.FormattingEnabled = true;
            movimentacao.Items.AddRange(new object[] { "Embarque", "Descarga", "Gate In", "Gate Out", "Reposicionamento", "Pesagem", "Scanner" });
            movimentacao.Location = new Point(317, 86);
            movimentacao.Name = "movimentacao";
            movimentacao.Size = new Size(140, 23);
            movimentacao.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 68);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 8;
            label4.Text = "Movimentação";
            // 
            // dataInicio
            // 
            dataInicio.Location = new Point(317, 130);
            dataInicio.Name = "dataInicio";
            dataInicio.Size = new Size(140, 23);
            dataInicio.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 112);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 10;
            label5.Text = "Data Início";
            // 
            // dataFinal
            // 
            dataFinal.Location = new Point(317, 174);
            dataFinal.Name = "dataFinal";
            dataFinal.Size = new Size(140, 23);
            dataFinal.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(344, 156);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 12;
            label6.Text = "Data Fim";
            label6.Click += label6_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(214, 203);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(243, 23);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Confirmar Edição";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(214, 232);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(243, 23);
            btnExcluir.TabIndex = 14;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // editarOuExcluirMovimentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 520);
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
            Margin = new Padding(3, 2, 3, 2);
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