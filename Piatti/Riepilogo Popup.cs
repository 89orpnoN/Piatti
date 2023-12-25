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
    public partial class Riepilogo_Popup : Form
    {
        public int Sacchetti;
        public List<string> PacchettiList;
        public Riepilogo_Popup()
        {
            InitializeComponent();
        }

        private void Riepilogo_Popup_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < PacchettiList.Count; i++)
            {
                string s = PacchettiList[i];
                var c = 1;
                for (int j = i+1; j < PacchettiList.Count; j++)
                {
                    if (s == PacchettiList[j]) 
                    { 
                        PacchettiList.RemoveAt(j); 
                        c++; 
                    }

                }
                PacchettiList[i] += (c != 1 ) ? $" X{c}" : "";
                SalseList.Items.Add(PacchettiList[i]);
            }
            PacchettiValue.Text = Sacchetti.ToString();
        }


    }
}
