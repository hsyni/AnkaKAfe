using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAankaKafe.UI
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem==tsmiUrunler)
            {
                new UrunlerForm().ShowDialog();
            }
            else if (e.ClickedItem==tsmiGecmisUrunler)
            {
                new GecmisSiparisler().ShowDialog();
            }
        }
    }
}
