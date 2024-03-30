namespace testeClaudio
{
    partial class registrarConteiner
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
            idCliente = new ComboBox();
            letrasConteiner = new TextBox();
            numerosConteiner = new TextBox();
            nomeCliente = new TextBox();
            tipo = new ComboBox();
            status = new ComboBox();
            categoria = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            registrar = new Button();
            linkLabel1 = new LinkLabel();
            Home = new LinkLabel();
            SuspendLayout();
            // 
            // idCliente
            // 
            idCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            idCliente.FormattingEnabled = true;
            idCliente.Location = new Point(177, 129);
            idCliente.Name = "idCliente";
            idCliente.Size = new Size(52, 28);
            idCliente.TabIndex = 5;
            idCliente.DropDownClosed += idCliente_DropDownClosed;
            // 
            // letrasConteiner
            // 
            letrasConteiner.Location = new Point(439, 128);
            letrasConteiner.MaxLength = 4;
            letrasConteiner.Name = "letrasConteiner";
            letrasConteiner.Size = new Size(50, 27);
            letrasConteiner.TabIndex = 7;
            letrasConteiner.TextChanged += letrasConteiner_TextChanged;
            letrasConteiner.KeyPress += letrasConteiner_KeyPress;
            // 
            // numerosConteiner
            // 
            numerosConteiner.Location = new Point(495, 128);
            numerosConteiner.MaxLength = 7;
            numerosConteiner.Name = "numerosConteiner";
            numerosConteiner.Size = new Size(78, 27);
            numerosConteiner.TabIndex = 8;
            numerosConteiner.KeyPress += numerosConteiner_KeyPress;
            // 
            // nomeCliente
            // 
            nomeCliente.Location = new Point(235, 129);
            nomeCliente.Name = "nomeCliente";
            nomeCliente.ReadOnly = true;
            nomeCliente.Size = new Size(173, 27);
            nomeCliente.TabIndex = 6;
            // 
            // tipo
            // 
            tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            tipo.FormattingEnabled = true;
            tipo.Items.AddRange(new object[] { "20", "40" });
            tipo.Location = new Point(598, 127);
            tipo.Name = "tipo";
            tipo.Size = new Size(79, 28);
            tipo.TabIndex = 9;
            // 
            // status
            // 
            status.DropDownStyle = ComboBoxStyle.DropDownList;
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "Cheio", "Vazio" });
            status.Location = new Point(704, 128);
            status.Name = "status";
            status.Size = new Size(79, 28);
            status.TabIndex = 10;
            // 
            // categoria
            // 
            categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            categoria.FormattingEnabled = true;
            categoria.Items.AddRange(new object[] { "Importação", "Exportação" });
            categoria.Location = new Point(818, 128);
            categoria.Name = "categoria";
            categoria.Size = new Size(106, 28);
            categoria.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 105);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 0;
            label1.Text = "Selecione o Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 104);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 1;
            label2.Text = "Letras Números";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(616, 104);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(718, 104);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(835, 104);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 4;
            label5.Text = "Categoria";
            // 
            // registrar
            // 
            registrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registrar.Location = new Point(177, 172);
            registrar.Name = "registrar";
            registrar.Size = new Size(197, 40);
            registrar.TabIndex = 12;
            registrar.Text = "Registrar";
            registrar.UseVisualStyleBackColor = true;
            registrar.Click += registrar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(177, 231);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(209, 20);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Editar ou Excluir um Conteiner";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Home
            // 
            Home.AutoSize = true;
            Home.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline);
            Home.LinkColor = Color.Black;
            Home.Location = new Point(12, 9);
            Home.Name = "Home";
            Home.Size = new Size(152, 32);
            Home.TabIndex = 14;
            Home.TabStop = true;
            Home.Text = "Página Inicial";
            Home.LinkClicked += Home_LinkClicked;
            // 
            // registrarConteiner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 655);
            Controls.Add(Home);
            Controls.Add(linkLabel1);
            Controls.Add(registrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(categoria);
            Controls.Add(status);
            Controls.Add(tipo);
            Controls.Add(nomeCliente);
            Controls.Add(numerosConteiner);
            Controls.Add(letrasConteiner);
            Controls.Add(idCliente);
            MaximizeBox = false;
            Name = "registrarConteiner";
            Text = "registrarConteiner";
            Load += registrarConteiner_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox idCliente;
        private TextBox letrasConteiner;
        private TextBox numerosConteiner;
        private TextBox nomeCliente;
        private ComboBox tipo;
        private ComboBox status;
        private ComboBox categoria;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button registrar;
        private LinkLabel linkLabel1;
        private LinkLabel Home;
    }
}