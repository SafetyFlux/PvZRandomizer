
namespace PvZRandomizer
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIntro = new System.Windows.Forms.Label();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.txtGamePath = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.ddSunCost = new System.Windows.Forms.ComboBox();
            this.lblSunCost = new System.Windows.Forms.Label();
            this.groupPlants = new System.Windows.Forms.GroupBox();
            this.lblOtherRates = new System.Windows.Forms.Label();
            this.ddOtherRates = new System.Windows.Forms.ComboBox();
            this.lblRechargeRate = new System.Windows.Forms.Label();
            this.ddRechargeRate = new System.Windows.Forms.ComboBox();
            this.groupPlants.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIntro
            // 
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(75, 9);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(655, 46);
            this.lblIntro.TabIndex = 2;
            this.lblIntro.Text = "Welcome to the Plants vs. Zombies randomizer! Please select your settings and cli" +
    "ck \'Randomize\' when finished! Settings in RED are not implemented yet.";
            this.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRandomize
            // 
            this.btnRandomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomize.Location = new System.Drawing.Point(38, 472);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(150, 26);
            this.btnRandomize.TabIndex = 3;
            this.btnRandomize.Text = "Randomize";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.BtnRandomize_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(203, 472);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(150, 26);
            this.btnRestore.TabIndex = 11;
            this.btnRestore.Text = "Restore Game File";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // txtGamePath
            // 
            this.txtGamePath.BackColor = System.Drawing.Color.White;
            this.txtGamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGamePath.Location = new System.Drawing.Point(116, 441);
            this.txtGamePath.Name = "txtGamePath";
            this.txtGamePath.ReadOnly = true;
            this.txtGamePath.Size = new System.Drawing.Size(651, 22);
            this.txtGamePath.TabIndex = 12;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(572, 472);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(195, 26);
            this.btnSelect.TabIndex = 13;
            this.btnSelect.Text = "Select Game FIle";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(35, 444);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(75, 16);
            this.lblPath.TabIndex = 14;
            this.lblPath.Text = "Game Path";
            // 
            // ddSunCost
            // 
            this.ddSunCost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddSunCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddSunCost.FormattingEnabled = true;
            this.ddSunCost.Items.AddRange(new object[] {
            "Vanilla",
            "Shuffled",
            "Random",
            "Chaos"});
            this.ddSunCost.Location = new System.Drawing.Point(84, 20);
            this.ddSunCost.Name = "ddSunCost";
            this.ddSunCost.Size = new System.Drawing.Size(121, 24);
            this.ddSunCost.TabIndex = 15;
            // 
            // lblSunCost
            // 
            this.lblSunCost.AutoSize = true;
            this.lblSunCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunCost.ForeColor = System.Drawing.Color.Black;
            this.lblSunCost.Location = new System.Drawing.Point(17, 22);
            this.lblSunCost.Name = "lblSunCost";
            this.lblSunCost.Size = new System.Drawing.Size(61, 16);
            this.lblSunCost.TabIndex = 16;
            this.lblSunCost.Text = "Sun Cost";
            // 
            // groupPlants
            // 
            this.groupPlants.Controls.Add(this.lblOtherRates);
            this.groupPlants.Controls.Add(this.ddOtherRates);
            this.groupPlants.Controls.Add(this.lblRechargeRate);
            this.groupPlants.Controls.Add(this.ddRechargeRate);
            this.groupPlants.Controls.Add(this.lblSunCost);
            this.groupPlants.Controls.Add(this.ddSunCost);
            this.groupPlants.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupPlants.Location = new System.Drawing.Point(12, 68);
            this.groupPlants.Name = "groupPlants";
            this.groupPlants.Size = new System.Drawing.Size(776, 55);
            this.groupPlants.TabIndex = 17;
            this.groupPlants.TabStop = false;
            this.groupPlants.Text = "Plants";
            // 
            // lblOtherRates
            // 
            this.lblOtherRates.AutoSize = true;
            this.lblOtherRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherRates.ForeColor = System.Drawing.Color.Red;
            this.lblOtherRates.Location = new System.Drawing.Point(549, 23);
            this.lblOtherRates.Name = "lblOtherRates";
            this.lblOtherRates.Size = new System.Drawing.Size(79, 16);
            this.lblOtherRates.TabIndex = 20;
            this.lblOtherRates.Text = "Other Rates";
            // 
            // ddOtherRates
            // 
            this.ddOtherRates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddOtherRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddOtherRates.FormattingEnabled = true;
            this.ddOtherRates.Items.AddRange(new object[] {
            "Vanilla",
            "Firing",
            "Production",
            "Both"});
            this.ddOtherRates.Location = new System.Drawing.Point(634, 20);
            this.ddOtherRates.Name = "ddOtherRates";
            this.ddOtherRates.Size = new System.Drawing.Size(121, 24);
            this.ddOtherRates.TabIndex = 19;
            // 
            // lblRechargeRate
            // 
            this.lblRechargeRate.AutoSize = true;
            this.lblRechargeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechargeRate.ForeColor = System.Drawing.Color.Black;
            this.lblRechargeRate.Location = new System.Drawing.Point(266, 22);
            this.lblRechargeRate.Name = "lblRechargeRate";
            this.lblRechargeRate.Size = new System.Drawing.Size(100, 16);
            this.lblRechargeRate.TabIndex = 18;
            this.lblRechargeRate.Text = "Recharge Rate";
            // 
            // ddRechargeRate
            // 
            this.ddRechargeRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddRechargeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddRechargeRate.FormattingEnabled = true;
            this.ddRechargeRate.Items.AddRange(new object[] {
            "Vanilla",
            "Shuffled",
            "Random",
            "Chaos"});
            this.ddRechargeRate.Location = new System.Drawing.Point(372, 20);
            this.ddRechargeRate.Name = "ddRechargeRate";
            this.ddRechargeRate.Size = new System.Drawing.Size(121, 24);
            this.ddRechargeRate.TabIndex = 17;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.groupPlants);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtGamePath);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.lblIntro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUI";
            this.Text = "Randomizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_FormClosing);
            this.Load += new System.EventHandler(this.GUI_Load);
            this.groupPlants.ResumeLayout(false);
            this.groupPlants.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txtGamePath;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.ComboBox ddSunCost;
        private System.Windows.Forms.Label lblSunCost;
        private System.Windows.Forms.GroupBox groupPlants;
        private System.Windows.Forms.Label lblRechargeRate;
        private System.Windows.Forms.ComboBox ddRechargeRate;
        private System.Windows.Forms.Label lblOtherRates;
        private System.Windows.Forms.ComboBox ddOtherRates;
    }
}

