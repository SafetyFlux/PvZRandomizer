
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
            this.components = new System.ComponentModel.Container();
            this.chkRndSun = new System.Windows.Forms.CheckBox();
            this.lblIntro = new System.Windows.Forms.Label();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.chkShfSun = new System.Windows.Forms.CheckBox();
            this.sunMin = new System.Windows.Forms.NumericUpDown();
            this.lblSunMin = new System.Windows.Forms.Label();
            this.lblSunMax = new System.Windows.Forms.Label();
            this.sunMax = new System.Windows.Forms.NumericUpDown();
            this.lblSunIncr = new System.Windows.Forms.Label();
            this.sunIncr = new System.Windows.Forms.NumericUpDown();
            this.tt_chkRndSun = new System.Windows.Forms.ToolTip(this.components);
            this.tt_chkShfSun = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sunMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunIncr)).BeginInit();
            this.SuspendLayout();
            // 
            // chkRndSun
            // 
            this.chkRndSun.AutoSize = true;
            this.chkRndSun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRndSun.Location = new System.Drawing.Point(38, 70);
            this.chkRndSun.Name = "chkRndSun";
            this.chkRndSun.Size = new System.Drawing.Size(159, 20);
            this.chkRndSun.TabIndex = 1;
            this.chkRndSun.Text = "Randomize Sun Costs";
            this.chkRndSun.UseVisualStyleBackColor = true;
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
            this.btnRandomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomize.Location = new System.Drawing.Point(360, 376);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(117, 38);
            this.btnRandomize.TabIndex = 3;
            this.btnRandomize.Text = "Randomize";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.BtnRandomize_Click);
            // 
            // chkShfSun
            // 
            this.chkShfSun.AutoCheck = false;
            this.chkShfSun.AutoSize = true;
            this.chkShfSun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShfSun.ForeColor = System.Drawing.Color.Red;
            this.chkShfSun.Location = new System.Drawing.Point(213, 70);
            this.chkShfSun.Name = "chkShfSun";
            this.chkShfSun.Size = new System.Drawing.Size(162, 20);
            this.chkShfSun.TabIndex = 4;
            this.chkShfSun.Text = "Shuffle Between Plants";
            this.chkShfSun.UseVisualStyleBackColor = true;
            // 
            // sunMin
            // 
            this.sunMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunMin.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.sunMin.Location = new System.Drawing.Point(431, 69);
            this.sunMin.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.sunMin.Name = "sunMin";
            this.sunMin.Size = new System.Drawing.Size(73, 22);
            this.sunMin.TabIndex = 5;
            // 
            // lblSunMin
            // 
            this.lblSunMin.AutoSize = true;
            this.lblSunMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunMin.Location = new System.Drawing.Point(396, 71);
            this.lblSunMin.Name = "lblSunMin";
            this.lblSunMin.Size = new System.Drawing.Size(29, 16);
            this.lblSunMin.TabIndex = 6;
            this.lblSunMin.Text = "Min";
            // 
            // lblSunMax
            // 
            this.lblSunMax.AutoSize = true;
            this.lblSunMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunMax.Location = new System.Drawing.Point(516, 71);
            this.lblSunMax.Name = "lblSunMax";
            this.lblSunMax.Size = new System.Drawing.Size(33, 16);
            this.lblSunMax.TabIndex = 8;
            this.lblSunMax.Text = "Max";
            // 
            // sunMax
            // 
            this.sunMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunMax.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.sunMax.Location = new System.Drawing.Point(555, 69);
            this.sunMax.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.sunMax.Name = "sunMax";
            this.sunMax.Size = new System.Drawing.Size(73, 22);
            this.sunMax.TabIndex = 7;
            this.sunMax.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // lblSunIncr
            // 
            this.lblSunIncr.AutoSize = true;
            this.lblSunIncr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunIncr.Location = new System.Drawing.Point(648, 70);
            this.lblSunIncr.Name = "lblSunIncr";
            this.lblSunIncr.Size = new System.Drawing.Size(29, 16);
            this.lblSunIncr.TabIndex = 10;
            this.lblSunIncr.Text = "Incr";
            // 
            // sunIncr
            // 
            this.sunIncr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunIncr.Location = new System.Drawing.Point(683, 68);
            this.sunIncr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sunIncr.Name = "sunIncr";
            this.sunIncr.Size = new System.Drawing.Size(73, 22);
            this.sunIncr.TabIndex = 9;
            this.sunIncr.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSunIncr);
            this.Controls.Add(this.sunIncr);
            this.Controls.Add(this.lblSunMax);
            this.Controls.Add(this.sunMax);
            this.Controls.Add(this.lblSunMin);
            this.Controls.Add(this.sunMin);
            this.Controls.Add(this.chkShfSun);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.chkRndSun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUI";
            this.Text = "Randomizer";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sunMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunIncr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkRndSun;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.CheckBox chkShfSun;
        private System.Windows.Forms.NumericUpDown sunMin;
        private System.Windows.Forms.Label lblSunMin;
        private System.Windows.Forms.Label lblSunMax;
        private System.Windows.Forms.NumericUpDown sunMax;
        private System.Windows.Forms.Label lblSunIncr;
        private System.Windows.Forms.NumericUpDown sunIncr;
        private System.Windows.Forms.ToolTip tt_chkRndSun;
        private System.Windows.Forms.ToolTip tt_chkShfSun;
    }
}

