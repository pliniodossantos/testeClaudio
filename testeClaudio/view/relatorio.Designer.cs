namespace testeClaudio
{
    partial class relatorio
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
            cliente = new ComboBox();
            movimento = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnFiltrar = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            totalImportacao = new TextBox();
            totalExportacao = new TextBox();
            Home = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cliente
            // 
            cliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cliente.FormattingEnabled = true;
            cliente.Location = new Point(516, 129);
            cliente.Name = "cliente";
            cliente.Size = new Size(197, 28);
            cliente.TabIndex = 0;
            cliente.DropDownClosed += cliente_DropDownClosed;
            // 
            // movimento
            // 
            movimento.DropDownStyle = ComboBoxStyle.DropDownList;
            movimento.FormattingEnabled = true;
            movimento.Items.AddRange(new object[] { "Embarque", "Descarga", "Gate In", "Gate Out", "Reposicionamento", "Pesagem", "Scanner" });
            movimento.Location = new Point(516, 163);
            movimento.Name = "movimento";
            movimento.Size = new Size(197, 28);
            movimento.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(434, 129);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 3;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(366, 162);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 4;
            label2.Text = "Movimentação:";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.Location = new Point(516, 197);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(197, 29);
            btnFiltrar.TabIndex = 5;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(181, 252);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(795, 211);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 571);
            label3.Name = "label3";
            label3.Size = new Size(161, 25);
            label3.TabIndex = 8;
            label3.Text = "Total Exportação:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 536);
            label4.Name = "label4";
            label4.Size = new Size(163, 25);
            label4.TabIndex = 7;
            label4.Text = "Total Importação:";
            // 
            // totalImportacao
            // 
            totalImportacao.Location = new Point(181, 537);
            totalImportacao.Name = "totalImportacao";
            totalImportacao.ReadOnly = true;
            totalImportacao.Size = new Size(63, 27);
            totalImportacao.TabIndex = 9;
            // 
            // totalExportacao
            // 
            totalExportacao.Location = new Point(181, 572);
            totalExportacao.Name = "totalExportacao";
            totalExportacao.ReadOnly = true;
            totalExportacao.Size = new Size(63, 27);
            totalExportacao.TabIndex = 10;
            // 
            // Home
            // 
            Home.AutoSize = true;
            Home.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline);
            Home.Location = new Point(12, 9);
            Home.Name = "Home";
            Home.Size = new Size(152, 32);
            Home.TabIndex = 11;
            Home.Text = "Página Inicial";
            Home.Click += Home_Click;
            // 
            // relatorio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 655);
            Controls.Add(Home);
            Controls.Add(totalExportacao);
            Controls.Add(totalImportacao);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(btnFiltrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(movimento);
            Controls.Add(cliente);
            MaximizeBox = false;
            Name = "relatorio";
            Text = "relatorio";
            Load += relatorio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cliente;
        private ComboBox movimento;
        private Label label1;
        private Label label2;
        private Button btnFiltrar;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private TextBox totalImportacao;
        private TextBox totalExportacao;
        private Label Home;
    }
}