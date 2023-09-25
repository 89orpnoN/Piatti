namespace Piatti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            unaSalsiccia salsiccia = new unaSalsiccia();
            DueSalsiccie dueSalsiccie = new DueSalsiccie();
            TreSalsiccie treSalsiccie = new TreSalsiccie();
            this[salsiccia.ComboBox].Items.Add(salsiccia);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DessertBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}