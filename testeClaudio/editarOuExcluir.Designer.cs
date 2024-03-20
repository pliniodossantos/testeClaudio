namespace testeClaudio
{
    partial class editarOuExcluir
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
            label1 = new Label();
            txtId = new TextBox();
            txtCliente = new TextBox();
            txtCpf = new TextBox();
            txtUf = new TextBox();
            editar = new Button();
            Excluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(179, 283);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(505, 301);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 219);
            label1.Name = "label1";
            label1.Size = new Size(358, 54);
            label1.TabIndex = 1;
            label1.Text = "Selecionar Cliente";
            // 
            // txtId
            // 
            txtId.Location = new Point(168, 49);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.MaxLength = 4;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(61, 27);
            txtId.TabIndex = 2;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(237, 49);
            txtCliente.Margin = new Padding(3, 4, 3, 4);
            txtCliente.MaxLength = 100;
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(199, 27);
            txtCliente.TabIndex = 3;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(443, 49);
            txtCpf.Margin = new Padding(3, 4, 3, 4);
            txtCpf.MaxLength = 11;
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(199, 27);
            txtCpf.TabIndex = 4;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(650, 49);
            txtUf.Margin = new Padding(3, 4, 3, 4);
            txtUf.MaxLength = 2;
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(55, 27);
            txtUf.TabIndex = 5;
            // 
            // editar
            // 
            editar.Location = new Point(168, 100);
            editar.Margin = new Padding(3, 4, 3, 4);
            editar.Name = "editar";
            editar.Size = new Size(269, 31);
            editar.TabIndex = 6;
            editar.Text = "Confirmar Edição";
            editar.UseVisualStyleBackColor = true;
            editar.Click += editar_Click;
            // 
            // Excluir
            // 
            Excluir.Location = new Point(443, 100);
            Excluir.Margin = new Padding(3, 4, 3, 4);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(263, 31);
            Excluir.TabIndex = 7;
            Excluir.Text = "Excluir";
            Excluir.UseVisualStyleBackColor = true;
            Excluir.Click += button2_Click;
            // 
            // editarOuExcluir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Excluir);
            Controls.Add(editar);
            Controls.Add(txtUf);
            Controls.Add(txtCpf);
            Controls.Add(txtCliente);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "editarOuExcluir";
            Text = "editarOuExcluir";
            Load += editarOuExcluir_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtId;
        private TextBox txtCliente;
        private TextBox txtCpf;
        private TextBox txtUf;
        private Button editar;
        private Button Excluir;
    }
}