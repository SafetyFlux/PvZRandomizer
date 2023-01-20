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
using Newtonsoft.Json.Linq;

using PvZRandomizer.Utility;

namespace PvZRandomizer
{
    public partial class GUI : Form
    {
        private JObject config;

        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            LoadConfiguration();
        }

        private void GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save your settings?",
                "Save Changes?", MessageBoxButtons.YesNoCancel);

            // Ask the user if they want to save the selected options
            if (result == DialogResult.Yes)
            {
                SaveConfiguration();
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        // Load settings
        private void LoadConfiguration()
        {
            // Load config.json as string and parse it into JObject type
            var configStr = File.ReadAllText("Resources/config.json");
            config = JObject.Parse(configStr);

            // Set values
            txtGamePath.Text = config["game_path"].ToString();
            ddSunCost.Text = config["randomization"]["sun_cost"].ToString();
            ddRechargeRate.Text = config["randomization"]["recharge_rate"].ToString();
            ddOtherRates.Text = config["randomization"]["other_rates"].ToString();
        }

        // Save settings
        private void SaveConfiguration()
        {
            config["game_path"] = txtGamePath.Text;
            config["randomization"]["sun_cost"] = ddSunCost.Text;
            config["randomization"]["recharge_rate"] = ddRechargeRate.Text;
            config["randomization"]["other_rates"] = ddOtherRates.Text;

            var configStr = config.ToString();
            File.WriteAllText("Resources/config.json", configStr);
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            // Select the game exe and make a backup of it
            string gameExe;
            OpenFileDialog exeSelector = new OpenFileDialog();
            exeSelector.Title = "Select your Plants Vs. Zombies exe file";
            DialogResult result = exeSelector.ShowDialog();

            // Set game exe path
            if (result == DialogResult.OK)
            {
                gameExe = exeSelector.FileName;
                txtGamePath.Text = gameExe;
            }
        }

        private void BtnRandomize_Click(object sender, EventArgs e)
        {
            string gameExe = txtGamePath.Text;

            if (File.Exists(gameExe))
            {
                

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
