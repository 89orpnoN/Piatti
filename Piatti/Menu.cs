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




            secondoPiattoBox.Items.Add(IstanzeDiPiatti.Salsiccia);
            secondoPiattoBox.Items.Add(IstanzeDiPiatti.DueSalsiccie);
            secondoPiattoBox.Items.Add(IstanzeDiPiatti.TreSalsiccie);



            primoPiattoBox.Items.Add(IstanzeDiPiatti.Spaghetti);
            primoPiattoBox.Items.Add(IstanzeDiPiatti.SpaghettiCaldi);
            primoPiattoBox.Items.Add(IstanzeDiPiatti.SpaghettiFreddi);


            dessertBox.Items.Add(IstanzeDiPiatti.Cacioepep);
            dessertBox.Items.Add(IstanzeDiPiatti.Zucchero);
            dessertBox.Items.Add(IstanzeDiPiatti.Pancakes);



        }



        private void DessertBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = (Piatto)((System.Windows.Forms.ComboBox)sender).SelectedItem;
            dessertPicture.ImageLocation = s.Immagine;
        }

        private void SecondoPiattoBox_TextChanged(object sender, EventArgs e)
        {
            var s = (Piatto)((System.Windows.Forms.ComboBox)sender).SelectedItem;
            secondoPiattoPicture.ImageLocation = s.Immagine;
        }

        private void PrimoPiattoBox_TextChanged(object sender, EventArgs e)
        {
            var s = (Piatto)((System.Windows.Forms.ComboBox)sender).SelectedItem;
            primoPiattoPicture.ImageLocation = s.Immagine;
        }

    }
}