﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            // Select the game exe and make a backup of it
            string gameExe = "";
            OpenFileDialog exeSelector = new OpenFileDialog();
            exeSelector.Title = "Select your Plants Vs. Zombies exe file";
            DialogResult result = exeSelector.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Set game exe path
                gameExe = exeSelector.FileName;

                // Backup the game if it hasn't already been backed up
                if (!File.Exists("backup/PlantsVsZombies.exe"))
                {
                    Directory.CreateDirectory("backup");
                    File.Copy(gameExe, "backup/PlantsVsZombies.exe");
                }
            }

            // Run methods based on selected settings
            if (chkRndSun.Checked)
            {
                Randomize.RandomizeSun(gameExe, (int)sunMin.Value, (int)sunMax.Value, (int)sunIncr.Value);
            }

            
        }
    }
}
