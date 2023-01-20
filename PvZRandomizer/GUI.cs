using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using PvZRandomizer.Utility;

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
            SetDefaultDropdownValues();
        }

        private void SetDefaultDropdownValues()
        {
            ddSunCost.Text = "Vanilla";
            ddRechargeRate.Text = "Vanilla";
            ddOtherRate.Text = "Vanilla";
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            // Select the game exe and make a backup of it
            string gameExe = "null";
            OpenFileDialog exeSelector = new OpenFileDialog();
            exeSelector.Title = "Select your Plants Vs. Zombies exe file";
            DialogResult result = exeSelector.ShowDialog();

            // Set game exe path
            if (result == DialogResult.OK)
            {
                gameExe = exeSelector.FileName;
                txtGamePath.Text = gameExe;
            }

            if (!File.Exists("config/gamePath.txt"))
                Directory.CreateDirectory("config");
            File.WriteAllText("config/gamePath.txt", gameExe);
        }

        private void BtnRandomize_Click(object sender, EventArgs e)
        {
            string gameExe = txtGamePath.Text;

            if (File.Exists(gameExe))
            {
                // Backup the game if it hasn't already been backed up
                if (!File.Exists("backup/PlantsVsZombies.exe"))
                {
                    Directory.CreateDirectory("backup");
                    File.Copy(gameExe, "backup/PlantsVsZombies.exe");
                }

                // Display confirmation dialog
                DialogResult confirm;
                confirm = MessageBox.Show("Randomization complete!", "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (confirm == DialogResult.OK)
                    Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid game path.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            string gameExe = txtGamePath.Text;

            if (File.Exists(gameExe))
            {
                // Delete the original file and copy the backup to the game directory
                if (File.Exists("backup/PlantsVsZombies.exe"))
                {
                    File.Delete(gameExe);
                    File.Copy("backup/PlantsVsZombies.exe", gameExe);
                }

                // Display confirmation dialog
                DialogResult confirm;
                confirm = MessageBox.Show("Restoration complete!", "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (confirm == DialogResult.OK)
                    Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid game path.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
