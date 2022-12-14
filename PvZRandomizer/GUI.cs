using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PvZRandomizer.utility;

namespace PvZRandomizer
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            //InitializeTooltips();
        }

        private void InitializeTooltips()
        {
            tt_chkRndSun.SetToolTip(chkRndSun, "Sets the sun cost of each plant to a random value");
            tt_chkShfSun.SetToolTip(chkShfSun, "Shuffles the sun costs between plants");
        }

        private void BtnRandomize_Click(object sender, EventArgs e)
        {
            // Run methods based on selected settings
            if (chkRndSun.Checked)
            {
                Randomize.RandomizeSun((int)sunMin.Value, (int)sunMax.Value, (int)sunIncr.Value);
            }
        }
    }
}
