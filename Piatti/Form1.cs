using System.ComponentModel;
using System.IO;

namespace Piatti
{
    public partial class Form1 : Form
    {

        ComboBox primoPiattoBox;
        ComboBox secondoPiattoBox;
        ComboBox dessertBox;

        PictureBox dessertPicture;
        PictureBox primoPiattoPicture;
        PictureBox secondoPiattoPicture;

        unaSalsiccia salsiccia;
        DueSalsiccie dueSalsiccie;
        TreSalsiccie treSalsiccie;

        SpaghettiC spaghettiCaldi;
        SpaghettiF spaghettiFreddi;
        Spaghetti spaghetti;

        Pancakes pancakes;
        Cacioepepe Cacioepep;
        Zucchero zucchero;

        public Form1()
        {
            InitializeComponent();

            Directory.SetCurrentDirectory(@"..\..\..");

            primoPiattoBox = this.PrimoPiattoBox;
            secondoPiattoBox = this.SecondoPiattoBox;
            dessertBox = this.DessertBox;


            dessertPicture = this.DessertPicture;
            primoPiattoPicture = this.PrimoPiattoPicture;
            secondoPiattoPicture = this.SecondoPiattoPicture;

        }

        private void Form1_Load(object sender, EventArgs e)
        {



            salsiccia = new unaSalsiccia();
            dueSalsiccie = new DueSalsiccie();
            treSalsiccie = new TreSalsiccie();
            secondoPiattoBox.Items.Add(salsiccia);
            secondoPiattoBox.Items.Add(dueSalsiccie);
            secondoPiattoBox.Items.Add(treSalsiccie);


            spaghettiCaldi = new SpaghettiC();
            spaghettiFreddi = new SpaghettiF();
            spaghetti = new Spaghetti();
            primoPiattoBox.Items.Add(spaghetti);
            primoPiattoBox.Items.Add(spaghettiCaldi);
            primoPiattoBox.Items.Add(spaghettiFreddi);

            Cacioepep = new Cacioepepe();
            zucchero = new Zucchero();
            pancakes = new Pancakes();
            dessertBox.Items.Add(Cacioepep);
            dessertBox.Items.Add(zucchero);
            dessertBox.Items.Add(pancakes);



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DessertBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = (Dessert)((System.Windows.Forms.ComboBox)sender).SelectedItem;
            dessertPicture.ImageLocation = s.immagine;
        }

        private void SecondoPiattoPicture_Click(object sender, EventArgs e)
        {

        }

        private void SecondoPiattoBox_TextChanged(object sender, EventArgs e)
        {

            var s = (SecondoPiatto)((System.Windows.Forms.ComboBox)sender).SelectedItem;
            secondoPiattoPicture.ImageLocation = s.immagine;
        }

        private void PrimoPiattoBox_TextChanged(object sender, EventArgs e)
        {
            var s = (PrimoPiatto)((System.Windows.Forms.ComboBox)sender).SelectedItem;
            primoPiattoPicture.ImageLocation = s.immagine;
        }

        private void DessertBox_TextUpdate(object sender, EventArgs e)
        {

        }
    }
}