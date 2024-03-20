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
            SuspendLayout();
            // 
            // idCliente
            // 
            idCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            idCliente.FormattingEnabled = true;
            idCliente.Location = new Point(75, 88);
            idCliente.Margin = new Padding(3, 2, 3, 2);
            idCliente.Name = "idCliente";
            idCliente.Size = new Size(46, 23);
            idCliente.TabIndex = 1;
            idCliente.DropDownClosed += idCliente_DropDownClosed;
            // 
            // letrasConteiner
            // 
            letrasConteiner.Location = new Point(272, 88);
            letrasConteiner.Margin = new Padding(3, 2, 3, 2);
            letrasConteiner.MaxLength = 4;
            letrasConteiner.Name = "letrasConteiner";
            letrasConteiner.Size = new Size(44, 23);
            letrasConteiner.TabIndex = 2;
            letrasConteiner.TextChanged += letrasConteiner_TextChanged;
            letrasConteiner.KeyPress += letrasConteiner_KeyPress;
            // 
            // numerosConteiner
            // 
            numerosConteiner.Location = new Point(321, 88);
            numerosConteiner.Margin = new Padding(3, 2, 3, 2);
            numerosConteiner.MaxLength = 7;
            numerosConteiner.Name = "numerosConteiner";
            numerosConteiner.Size = new Size(69, 23);
            numerosConteiner.TabIndex = 3;
            numerosConteiner.KeyPress += numerosConteiner_KeyPress;
            // 
            // nomeCliente
            // 
            nomeCliente.Location = new Point(126, 88);
            nomeCliente.Margin = new Padding(3, 2, 3, 2);
            nomeCliente.Name = "nomeCliente";
            nomeCliente.ReadOnly = true;
            nomeCliente.Size = new Size(122, 23);
            nomeCliente.TabIndex = 4;
            // 
            // tipo
            // 
            tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            tipo.FormattingEnabled = true;
            tipo.Items.AddRange(new object[] { "20", "40" });
            tipo.Location = new Point(411, 87);
            tipo.Margin = new Padding(3, 2, 3, 2);
            tipo.Name = "tipo";
            tipo.Size = new Size(70, 23);
            tipo.TabIndex = 5;
            // 
            // status
            // 
            status.DropDownStyle = ComboBoxStyle.DropDownList;
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "Cheio", "Vazio" });
            status.Location = new Point(504, 88);
            status.Margin = new Padding(3, 2, 3, 2);
            status.Name = "status";
            status.Size = new Size(70, 23);
            status.TabIndex = 6;
            // 
            // categoria
            // 
            categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            categoria.FormattingEnabled = true;
            categoria.Items.AddRange(new object[] { "Importação", "Exportação" });
            categoria.Location = new Point(604, 88);
            categoria.Margin = new Padding(3, 2, 3, 2);
            categoria.Name = "categoria";
            categoria.Size = new Size(93, 23);
            categoria.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 70);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 8;
            label1.Text = "Selecione o Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 70);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 9;
            label2.Text = "Letras Números";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 70);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 10;
            label3.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(516, 70);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 11;
            label4.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(619, 70);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 12;
            label5.Text = "Categoria";
            // 
            // registrar
            // 
            registrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registrar.Location = new Point(75, 120);
            registrar.Margin = new Padding(3, 2, 3, 2);
            registrar.Name = "registrar";
            registrar.Size = new Size(172, 30);
            registrar.TabIndex = 13;
            registrar.Text = "Registrar";
            registrar.UseVisualStyleBackColor = true;
            registrar.Click += registrar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(75, 164);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(168, 15);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Editar ou Excluir um Conteiner";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // registrarConteiner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 493);
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
            Margin = new Padding(3, 2, 3, 2);
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
    }
}