namespace testeClaudio
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form goToForm = new Clientes();
            goToForm.Closed += (s, args) => this.Close();
            goToForm.Show();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            this.Hide();
            Form goToForm = new registrarConteiner();
            goToForm.Closed += (s, args) => this.Close();
            goToForm.Show();

        }

        private void movimento_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form goToForm = new movimentacoes();
            goToForm.Closed += (s, args) => this.Close();
            goToForm.Show();


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form goToForm = new relatorio();
            goToForm.Closed += (s, args) => this.Close();
            goToForm.Show();



        }


    }
}
