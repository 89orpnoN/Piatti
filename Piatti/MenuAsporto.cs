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
            if (IstanzeDiPiatti.Spaghetti.Asportabile) PrimoPiattoBox.Items.Add(IstanzeDiPiatti.Spaghetti);
            if (IstanzeDiPiatti.SpaghettiCaldi.Asportabile) PrimoPiattoBox.Items.Add(IstanzeDiPiatti.SpaghettiCaldi);
            if (IstanzeDiPiatti.SpaghettiFreddi.Asportabile) PrimoPiattoBox.Items.Add(IstanzeDiPiatti.SpaghettiFreddi);

            if (IstanzeDiPiatti.Salsiccia.Asportabile) SecondoPiattoBox.Items.Add(IstanzeDiPiatti.Salsiccia);
            if (IstanzeDiPiatti.DueSalsiccie.Asportabile) SecondoPiattoBox.Items.Add(IstanzeDiPiatti.DueSalsiccie);
            if (IstanzeDiPiatti.TreSalsiccie.Asportabile) SecondoPiattoBox.Items.Add(IstanzeDiPiatti.TreSalsiccie);

            if (IstanzeDiPiatti.Zucchero.Asportabile) DessertBox.Items.Add(IstanzeDiPiatti.Zucchero);
            if (IstanzeDiPiatti.Pancakes.Asportabile) DessertBox.Items.Add(IstanzeDiPiatti.Pancakes);
            if (IstanzeDiPiatti.Cacioepep.Asportabile) DessertBox.Items.Add(IstanzeDiPiatti.Cacioepep);
        }

        private void DessertBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = (Piatto)((System.Windows.Forms.ComboBox)sender).SelectedItem;
            DessertPicture.ImageLocation = s.Immagine;
            DessertSacchettiText.Text =s.Sacchetti.ToString();
            DessertSalsaText.Text = Salsette.ToString(s.Salsetta);

        }
        private void PrimoPiattoBox_SelectedIndexChanged(Object sender, EventArgs e)
        {
            var s = (Piatto)((System.Windows.Forms.ComboBox)sender).SelectedItem;
            PrimoPiattoPicture.ImageLocation = s.Immagine;
            PrimoPiattoSacchettiText.Text = s.Sacchetti.ToString();
            PrimoPiattoSalsaText.Text = Salsette.ToString(s.Salsetta);
        }

        private void SecondoPiattoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = (Piatto)((System.Windows.Forms.ComboBox)sender).SelectedItem;
            SecondoPiattoPicture.ImageLocation = s.Immagine;
            SecondoPiattoSacchettiText.Text = s.Sacchetti.ToString();
            SecondoPiattoSalsaText.Text = Salsette.ToString(s.Salsetta);
        }

    }
}
