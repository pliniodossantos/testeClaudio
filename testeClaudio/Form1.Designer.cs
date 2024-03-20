namespace testeClaudio
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clientes = new Button();
            conteiner = new Button();
            movimento = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // clientes
            // 
            clientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clientes.Location = new Point(78, 55);
            clientes.Margin = new Padding(3, 4, 3, 4);
            clientes.Name = "clientes";
            clientes.Size = new Size(702, 79);
            clientes.TabIndex = 0;
            clientes.Text = "Clientes";
            clientes.UseVisualStyleBackColor = true;
            clientes.Click += button1_Click;
            // 
            // conteiner
            // 
            conteiner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            conteiner.Location = new Point(78, 167);
            conteiner.Margin = new Padding(3, 4, 3, 4);
            conteiner.Name = "conteiner";
            conteiner.Size = new Size(702, 79);
            conteiner.TabIndex = 1;
            conteiner.Text = "Registar Contêiner";
            conteiner.UseVisualStyleBackColor = true;
            conteiner.Click += button1_Click_1;
            // 
            // movimento
            // 
            movimento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            movimento.Location = new Point(78, 284);
            movimento.Margin = new Padding(3, 4, 3, 4);
            movimento.Name = "movimento";
            movimento.Size = new Size(702, 79);
            movimento.TabIndex = 2;
            movimento.Text = "Movimentações";
            movimento.UseVisualStyleBackColor = true;
            movimento.Click += movimento_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(78, 392);
            button1.Name = "button1";
            button1.Size = new Size(702, 79);
            button1.TabIndex = 3;
            button1.Text = "Relatório";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 863);
            Controls.Add(button1);
            Controls.Add(movimento);
            Controls.Add(conteiner);
            Controls.Add(clientes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            Text = "Home";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button clientes;
        private Button conteiner;
        private Button movimento;
        private Button button1;
    }
}
