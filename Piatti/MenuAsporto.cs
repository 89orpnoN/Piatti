using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piatti
{
    public partial class MenuAsporto : Form
    {
        public MenuAsporto()
        {
            InitializeComponent();
        }

        private void MenuAsporto_Load(object sender, EventArgs e)
        {

            SecondoPiattoBox.Items.Add(IstanzeDiPiatti.salsiccia);
            SecondoPiattoBox.Items.Add(IstanzeDiPiatti.dueSalsiccie);
            SecondoPiattoBox.Items.Add(IstanzeDiPiatti.treSalsiccie);



            PrimoPiattoBox.Items.Add(IstanzeDiPiatti.spaghetti);
            PrimoPiattoBox.Items.Add(IstanzeDiPiatti.spaghettiCaldi);
            PrimoPiattoBox.Items.Add(IstanzeDiPiatti.spaghettiFreddi);


            DessertBox.Items.Add(IstanzeDiPiatti.Cacioepep);
            DessertBox.Items.Add(IstanzeDiPiatti.zucchero);
            DessertBox.Items.Add(IstanzeDiPiatti.pancakes);
        }

        private void DessertBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = (Dessert)((System.Windows.Forms.ComboBox)sender).SelectedItem;
            DessertPicture.ImageLocation = s.immagine;
        }

        private void SecondoPiattoBox_TextChanged(object sender, EventArgs e)
        {

            var s = (SecondoPiatto)((System.Windows.Forms.ComboBox)sender).SelectedItem;
            SecondoPiattoPicture.ImageLocation = s.immagine;
        }

        private void PrimoPiattoBox_TextChanged(object sender, EventArgs e)
        {
            var s = (PrimoPiatto)((System.Windows.Forms.ComboBox)sender).SelectedItem;
            PrimoPiattoPicture.ImageLocation = s.immagine;
        }
    }
}
