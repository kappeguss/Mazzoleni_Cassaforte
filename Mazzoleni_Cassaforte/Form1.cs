namespace Mazzoleni_Cassaforte
{
    public partial class Form1 : Form
    {
        private Cassaforte cassaforte;
        public Form1()
        {
            cassaforte = new Cassaforte(3200, "Masnada", "XM500", "345123498500");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(cassaforte);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cassaforte.Imposta(Convert.ToString(label2.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cassaforte.Chiudi();
        }
    }
}