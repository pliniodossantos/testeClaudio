namespace testeClaudio
{
    partial class movimentacoes
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
            idConteiner = new ComboBox();
            codConteiner = new TextBox();
            idCliente = new TextBox();
            cliente = new TextBox();
            movimentacao = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            horaInit = new MaskedTextBox();
            horaEnd = new MaskedTextBox();
            label6 = new Label();
            label7 = new Label();
            btnRegistrar = new Button();
            linkLabel1 = new LinkLabel();
            dateTimePicker1 = new DateTimePicker();
            dateTimePickerFim = new DateTimePicker();
            Home = new LinkLabel();
            SuspendLayout();
            // 
            // idConteiner
            // 
            idConteiner.DropDownStyle = ComboBoxStyle.DropDownList;
            idConteiner.FormattingEnabled = true;
            idConteiner.Location = new Point(223, 149);
            idConteiner.Margin = new Padding(3, 4, 3, 4);
            idConteiner.Name = "idConteiner";
            idConteiner.Size = new Size(81, 28);
            idConteiner.TabIndex = 7;
            idConteiner.DropDownClosed += idConteiner_DropDownClosed;
            // 
            // codConteiner
            // 
            codConteiner.Location = new Point(311, 149);
            codConteiner.Margin = new Padding(3, 4, 3, 4);
            codConteiner.Name = "codConteiner";
            codConteiner.ReadOnly = true;
            codConteiner.Size = new Size(114, 27);
            codConteiner.TabIndex = 8;
            // 
            // idCliente
            // 
            idCliente.Location = new Point(432, 149);
            idCliente.Margin = new Padding(3, 4, 3, 4);
            idCliente.Name = "idCliente";
            idCliente.ReadOnly = true;
            idCliente.Size = new Size(81, 27);
            idCliente.TabIndex = 9;
            // 
            // cliente
            // 
            cliente.Location = new Point(520, 149);
            cliente.Margin = new Padding(3, 4, 3, 4);
            cliente.Name = "cliente";
            cliente.ReadOnly = true;
            cliente.Size = new Size(147, 27);
            cliente.TabIndex = 10;
            // 
            // movimentacao
            // 
            movimentacao.DropDownStyle = ComboBoxStyle.DropDownList;
            movimentacao.FormattingEnabled = true;
            movimentacao.Items.AddRange(new object[] { "Embarque", "Descarga", "Gate In", "Gate Out", "Reposicionamento", "Pesagem", "Scanner" });
            movimentacao.Location = new Point(223, 224);
            movimentacao.Margin = new Padding(3, 4, 3, 4);
            movimentacao.Name = "movimentacao";
            movimentacao.Size = new Size(169, 28);
            movimentacao.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 125);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Id Conteiner";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 125);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 1;
            label2.Text = "Código Conteiner";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 125);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Id Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(520, 125);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(223, 200);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 4;
            label5.Text = "Movimentação";
            // 
            // horaInit
            // 
            horaInit.Location = new Point(552, 224);
            horaInit.Margin = new Padding(3, 4, 3, 4);
            horaInit.Mask = "90:00:00";
            horaInit.Name = "horaInit";
            horaInit.Size = new Size(65, 27);
            horaInit.TabIndex = 15;
            horaInit.ValidatingType = typeof(DateTime);
            horaInit.MaskInputRejected += dateInit_MaskInputRejected;
            // 
            // horaEnd
            // 
            horaEnd.Location = new Point(799, 224);
            horaEnd.Margin = new Padding(3, 4, 3, 4);
            horaEnd.Mask = "90:00:00";
            horaEnd.Name = "horaEnd";
            horaEnd.Size = new Size(65, 27);
            horaEnd.TabIndex = 19;
            horaEnd.ValidatingType = typeof(DateTime);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(416, 201);
            label6.Name = "label6";
            label6.Size = new Size(240, 20);
            label6.TabIndex = 5;
            label6.Text = "Data Início: dd/mm/aaaa hh:mm:ss";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(663, 201);
            label7.Name = "label7";
            label7.Size = new Size(228, 20);
            label7.TabIndex = 6;
            label7.Text = "Data Fim: dd/mm/aaaa hh:mm:ss";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(223, 272);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(290, 43);
            btnRegistrar.TabIndex = 20;
            btnRegistrar.Text = "Registrar Movimentação";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(223, 333);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(219, 20);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Editar ou Excluir Movimentação";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(416, 225);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(130, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePickerFim
            // 
            dateTimePickerFim.CustomFormat = "dd/MM/yyyy";
            dateTimePickerFim.Format = DateTimePickerFormat.Custom;
            dateTimePickerFim.Location = new Point(663, 224);
            dateTimePickerFim.Name = "dateTimePickerFim";
            dateTimePickerFim.Size = new Size(130, 27);
            dateTimePickerFim.TabIndex = 16;
            // 
            // Home
            // 
            Home.AutoSize = true;
            Home.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline);
            Home.LinkColor = Color.Black;
            Home.Location = new Point(12, 9);
            Home.Name = "Home";
            Home.Size = new Size(152, 32);
            Home.TabIndex = 22;
            Home.TabStop = true;
            Home.Text = "Página Inicial";
            Home.LinkClicked += Home_LinkClicked;
            // 
            // movimentacoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 655);
            Controls.Add(Home);
            Controls.Add(dateTimePickerFim);
            Controls.Add(dateTimePicker1);
            Controls.Add(linkLabel1);
            Controls.Add(btnRegistrar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(horaEnd);
            Controls.Add(horaInit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(movimentacao);
            Controls.Add(cliente);
            Controls.Add(idCliente);
            Controls.Add(codConteiner);
            Controls.Add(idConteiner);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "movimentacoes";
            Text = "movimentacoes";
            Load += movimentacoes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox idConteiner;
        private TextBox codConteiner;
        private TextBox idCliente;
        private TextBox cliente;
        private ComboBox movimentacao;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox horaInit;
        private MaskedTextBox horaEnd;
        private Label label6;
        private Label label7;
        private Button btnRegistrar;
        private LinkLabel linkLabel1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePickerFim;
        private LinkLabel Home;
    }
}