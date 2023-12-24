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
    public partial class Principale : Form
    {
        public Form RunForm { get; private set; }
        public Principale()
        {
            InitializeComponent();
        }

        private void MenuSummon_Click(object sender, EventArgs e)
        {
            RunForm = (Form)new Menu();
            Close();
        }

        private void MenuAsportoSummon_Click(object sender, EventArgs e)
        {
            RunForm = (Form)new MenuAsporto();
            Close();
        }
    }


}
