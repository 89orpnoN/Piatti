using System.ComponentModel;
using System.IO;

namespace Piatti
{
    public partial class Menu : Form
    {

        ComboBox primoPiattoBox;
        ComboBox secondoPiattoBox;
        ComboBox dessertBox;

        PictureBox dessertPicture;
        PictureBox primoPiattoPicture;
        PictureBox secondoPiattoPicture;


        public Menu()
        {
            InitializeComponent();


            primoPiattoBox = this.PrimoPiattoBox;
            secondoPiattoBox = this.SecondoPiattoBox;
            dessertBox = this.DessertBox;


            dessertPicture = this.DessertPicture;
            primoPiattoPicture = this.PrimoPiattoPicture;
            secondoPiattoPicture = this.SecondoPiattoPicture;

        }

        private void Form1_Load(object sender, EventArgs e)
        {




            secondoPiattoBox.Items.Add(IstanzeDiPiatti.salsiccia);
            secondoPiattoBox.Items.Add(IstanzeDiPiatti.dueSalsiccie);
            secondoPiattoBox.Items.Add(IstanzeDiPiatti.treSalsiccie);



            primoPiattoBox.Items.Add(IstanzeDiPiatti.spaghetti);
            primoPiattoBox.Items.Add(IstanzeDiPiatti.spaghettiCaldi);
            primoPiattoBox.Items.Add(IstanzeDiPiatti.spaghettiFreddi);


            dessertBox.Items.Add(IstanzeDiPiatti.Cacioepep);
            dessertBox.Items.Add(IstanzeDiPiatti.zucchero);
            dessertBox.Items.Add(IstanzeDiPiatti.pancakes);



        }



        private void DessertBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = (Dessert)((System.Windows.Forms.ComboBox)sender).SelectedItem;
            dessertPicture.ImageLocation = s.immagine;
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
    }
}