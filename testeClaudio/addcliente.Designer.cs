namespace testeClaudio
{
    partial class addcliente
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            label1.Location = new Point(206, 20);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(403, 47);
            label1.TabIndex = 0;
            label1.Text = "Adicionar Novo Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 109);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(234, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(234, 193);
            button1.Name = "button1";
            button1.Size = new Size(332, 23);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(234, 135);
            textBox2.MaxLength = 11;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(332, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 138);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 4;
            label3.Text = "Cpf:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(234, 164);
            textBox3.MaxLength = 2;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(61, 23);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 167);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 6;
            label4.Text = "Uf:";
            // 
            // addcliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "addcliente";
            Text = "addcliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
    }
}