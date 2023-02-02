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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using PvZRandomizer.Utility;
using PvZRandomizer.Data;

namespace PvZRandomizer
{
    public partial class GUI : Form
    {
        // Define variables
        private JObject config;
        private List<Plant> plants = new List<Plant>();

        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            LoadConfiguration();
            InitializeData();
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
            // Set JObject values
            config["game_path"] = txtGamePath.Text;
            config["randomization"]["sun_cost"] = ddSunCost.Text;
            config["randomization"]["recharge_rate"] = ddRechargeRate.Text;
            config["randomization"]["other_rates"] = ddOtherRates.Text;

            // Overwrite config.json with new data
            var configStr = config.ToString();
            File.WriteAllText("Resources/config.json", configStr);
        }

        private void InitializeData()
        {
            // Load plants.json as string and convert it into a list of Plants
            var plantsJson = File.ReadAllText("Resources/plants.json");
            plants = JsonConvert.DeserializeObject<List<Plant>>(plantsJson);
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
                // Conditionals to randomize
                if (ddSunCost.Text != "Vanilla")
                    Randomize.RandomizeSun(plants, gameExe, ddSunCost.Text);
                if (ddRechargeRate.Text != "Vanilla")
                    Randomize.RandomizeRecharge(plants, gameExe, ddRechargeRate.Text);

                // Serialize new JSON
                var plantsJson = JsonConvert.SerializeObject(plants, Formatting.Indented);
                File.WriteAllText("Resources/plants.json", plantsJson);

                // Display confirmation dialog
                MessageBox.Show("Randomization complete!", "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                // Restore game with Restore class
                Restore.RestoreGame(plants, gameExe);

                // Serialize new JSON
                var plantsJson = JsonConvert.SerializeObject(plants, Formatting.Indented);
                File.WriteAllText("Resources/plants.json", plantsJson);

                // Display confirmation dialog
                MessageBox.Show("Restoration complete!", "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid game path.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
