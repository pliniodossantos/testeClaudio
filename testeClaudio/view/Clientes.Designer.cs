namespace testeClaudio
{
    partial class Clientes
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
            addnovocliente = new Label();
            listadeclientes = new Label();
            dataGridListaClientes = new DataGridView();
            editarOuExcluir = new Label();
            Home = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridListaClientes).BeginInit();
            SuspendLayout();
            // 
            // addnovocliente
            // 
            addnovocliente.Anchor = AnchorStyles.Left;
            addnovocliente.AutoSize = true;
            addnovocliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            addnovocliente.Location = new Point(12, 66);
            addnovocliente.Name = "addnovocliente";
            addnovocliente.Size = new Size(253, 32);
            addnovocliente.TabIndex = 0;
            addnovocliente.Text = "Adicionar novo cliente";
            addnovocliente.Click += label1_Click;
            // 
            // listadeclientes
            // 
            listadeclientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listadeclientes.AutoSize = true;
            listadeclientes.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listadeclientes.Location = new Point(402, 187);
            listadeclientes.Name = "listadeclientes";
            listadeclientes.Size = new Size(354, 60);
            listadeclientes.TabIndex = 1;
            listadeclientes.Text = "Lista de clientes";
            listadeclientes.Click += listadeclientes_Click;
            // 
            // dataGridListaClientes
            // 
            dataGridListaClientes.AllowUserToAddRows = false;
            dataGridListaClientes.AllowUserToDeleteRows = false;
            dataGridListaClientes.AllowUserToResizeColumns = false;
            dataGridListaClientes.AllowUserToResizeRows = false;
            dataGridListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridListaClientes.Location = new Point(311, 263);
            dataGridListaClientes.Margin = new Padding(3, 4, 3, 4);
            dataGridListaClientes.Name = "dataGridListaClientes";
            dataGridListaClientes.ReadOnly = true;
            dataGridListaClientes.RowHeadersWidth = 51;
            dataGridListaClientes.Size = new Size(533, 283);
            dataGridListaClientes.TabIndex = 2;
            dataGridListaClientes.CellContentClick += dataGridListaClientes_CellContentClick;
            // 
            // editarOuExcluir
            // 
            editarOuExcluir.Anchor = AnchorStyles.Left;
            editarOuExcluir.AutoSize = true;
            editarOuExcluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            editarOuExcluir.Location = new Point(12, 107);
            editarOuExcluir.Name = "editarOuExcluir";
            editarOuExcluir.Size = new Size(266, 32);
            editarOuExcluir.TabIndex = 3;
            editarOuExcluir.Text = "Editar ou Excluir Cliente";
            editarOuExcluir.Click += label1_Click_1;
            // 
            // Home
            // 
            Home.Anchor = AnchorStyles.Left;
            Home.AutoSize = true;
            Home.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Home.Location = new Point(12, 25);
            Home.Name = "Home";
            Home.Size = new Size(152, 32);
            Home.TabIndex = 4;
            Home.Text = "Página inicial";
            Home.Click += Home_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 655);
            Controls.Add(Home);
            Controls.Add(editarOuExcluir);
            Controls.Add(dataGridListaClientes);
            Controls.Add(listadeclientes);
            Controls.Add(addnovocliente);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridListaClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addnovocliente;
        private Label listadeclientes;
        private DataGridView dataGridListaClientes;
        private Label editarOuExcluir;
        private Label Home;
    }
}