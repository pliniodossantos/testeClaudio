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
            var goToForm = new Clientes();
            goToForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var goToForm = new registrarConteiner();
            goToForm.Show();
        }

        private void movimento_Click(object sender, EventArgs e)
        {
            var goToForm = new movimentacoes();
            goToForm.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var goToForm = new relatorio();
            goToForm.Show();
        }
    }
}
