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
            if (IstanzeDiPiatti.spaghetti.Asportabile()) PrimoPiattoBox.Items.Add(IstanzeDiPiatti.spaghetti);
            if (IstanzeDiPiatti.spaghettiCaldi.Asportabile()) PrimoPiattoBox.Items.Add(IstanzeDiPiatti.spaghettiCaldi);
            if (IstanzeDiPiatti.spaghettiFreddi.Asportabile()) PrimoPiattoBox.Items.Add(IstanzeDiPiatti.spaghettiFreddi);

            if (IstanzeDiPiatti.salsiccia.Asportabile()) SecondoPiattoBox.Items.Add(IstanzeDiPiatti.salsiccia);
            if (IstanzeDiPiatti.dueSalsiccie.Asportabile()) SecondoPiattoBox.Items.Add(IstanzeDiPiatti.dueSalsiccie);
            if (IstanzeDiPiatti.treSalsiccie.Asportabile()) SecondoPiattoBox.Items.Add(IstanzeDiPiatti.treSalsiccie);

            if (IstanzeDiPiatti.zucchero.Asportabile()) DessertBox.Items.Add(IstanzeDiPiatti.zucchero);
            if (IstanzeDiPiatti.pancakes.Asportabile()) DessertBox.Items.Add(IstanzeDiPiatti.pancakes);
            if (IstanzeDiPiatti.Cacioepep.Asportabile()) DessertBox.Items.Add(IstanzeDiPiatti.Cacioepep);
        }

        private void DessertBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = (Dessert)((System.Windows.Forms.ComboBox)sender).SelectedItem;
            DessertPicture.ImageLocation = s.immagine;
            DessertSacchettiText.Text = s.Sacchetti().ToString();
            DessertSalsaText.Text = Enum.GetName(typeof(Salsette), s.Salsetta());

        }
        private void PrimoPiattoBox_SelectedIndexChanged(Object sender, EventArgs e)
        {
            var s = (PrimoPiatto)((System.Windows.Forms.ComboBox)sender).SelectedItem;
            PrimoPiattoPicture.ImageLocation = s.immagine;
            PrimoPiattoSacchettiText.Text = s.Sacchetti().ToString();
            PrimoPiattoSalsaText.Text = Enum.GetName(typeof(Salsette), s.Salsetta());
        }

        private void SecondoPiattoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = (SecondoPiatto)((System.Windows.Forms.ComboBox)sender).SelectedItem;
            SecondoPiattoPicture.ImageLocation = s.immagine;
            SecondoPiattoSacchettiText.Text = s.Sacchetti().ToString();
            SecondoPiattoSalsaText.Text = Enum.GetName(typeof(Salsette), s.Salsetta());
        }

    }
}
