namespace jExWFA.Cheat
{
    partial class CheatPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RecoilLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RecoilSwitch = new Bunifu.Framework.UI.BunifuSwitch();
            this.GlowLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.GlowSwitch = new Bunifu.Framework.UI.BunifuSwitch();
            this.BhopLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BhopSwitch = new Bunifu.Framework.UI.BunifuSwitch();
            this.TriggerLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TriggerSwitch = new Bunifu.Framework.UI.BunifuSwitch();
            this.SwitchRounded = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BhopRounded = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.GlowRounded = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.RecoilRounded = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.GlowSetsBox = new System.Windows.Forms.GroupBox();
            this.BoostFPSCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.ThreadSleepLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BoostFPSSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.GlowSetsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecoilLabel
            // 
            this.RecoilLabel.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoilLabel.Location = new System.Drawing.Point(19, 247);
            this.RecoilLabel.Name = "RecoilLabel";
            this.RecoilLabel.Size = new System.Drawing.Size(106, 31);
            this.RecoilLabel.TabIndex = 21;
            this.RecoilLabel.Text = "Recoil Control";
            // 
            // RecoilSwitch
            // 
            this.RecoilSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.RecoilSwitch.BorderRadius = 0;
            this.RecoilSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecoilSwitch.Font = new System.Drawing.Font("Open Sans Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoilSwitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RecoilSwitch.Location = new System.Drawing.Point(143, 247);
            this.RecoilSwitch.Name = "RecoilSwitch";
            this.RecoilSwitch.Oncolor = System.Drawing.Color.SeaGreen;
            this.RecoilSwitch.Onoffcolor = System.Drawing.Color.Maroon;
            this.RecoilSwitch.Size = new System.Drawing.Size(51, 19);
            this.RecoilSwitch.TabIndex = 20;
            this.RecoilSwitch.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RecoilSwitch.Value = false;
            this.RecoilSwitch.Click += new System.EventHandler(this.RecoilSwitch_Click);
            // 
            // GlowLabel
            // 
            this.GlowLabel.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GlowLabel.Location = new System.Drawing.Point(19, 117);
            this.GlowLabel.Name = "GlowLabel";
            this.GlowLabel.Size = new System.Drawing.Size(81, 31);
            this.GlowLabel.TabIndex = 19;
            this.GlowLabel.Text = "Glow";
            // 
            // GlowSwitch
            // 
            this.GlowSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.GlowSwitch.BorderRadius = 0;
            this.GlowSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GlowSwitch.Font = new System.Drawing.Font("Open Sans Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GlowSwitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GlowSwitch.Location = new System.Drawing.Point(143, 119);
            this.GlowSwitch.Name = "GlowSwitch";
            this.GlowSwitch.Oncolor = System.Drawing.Color.SeaGreen;
            this.GlowSwitch.Onoffcolor = System.Drawing.Color.Maroon;
            this.GlowSwitch.Size = new System.Drawing.Size(51, 19);
            this.GlowSwitch.TabIndex = 18;
            this.GlowSwitch.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GlowSwitch.Value = false;
            this.GlowSwitch.Click += new System.EventHandler(this.GlowSwitch_Click);
            // 
            // BhopLabel
            // 
            this.BhopLabel.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BhopLabel.Location = new System.Drawing.Point(19, 68);
            this.BhopLabel.Name = "BhopLabel";
            this.BhopLabel.Size = new System.Drawing.Size(81, 31);
            this.BhopLabel.TabIndex = 17;
            this.BhopLabel.Text = "Bunnyhop";
            // 
            // BhopSwitch
            // 
            this.BhopSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.BhopSwitch.BorderRadius = 0;
            this.BhopSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BhopSwitch.Font = new System.Drawing.Font("Open Sans Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BhopSwitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BhopSwitch.Location = new System.Drawing.Point(143, 70);
            this.BhopSwitch.Name = "BhopSwitch";
            this.BhopSwitch.Oncolor = System.Drawing.Color.SeaGreen;
            this.BhopSwitch.Onoffcolor = System.Drawing.Color.Maroon;
            this.BhopSwitch.Size = new System.Drawing.Size(51, 19);
            this.BhopSwitch.TabIndex = 16;
            this.BhopSwitch.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BhopSwitch.Value = false;
            this.BhopSwitch.Click += new System.EventHandler(this.BhopSwitch_Click);
            // 
            // TriggerLabel
            // 
            this.TriggerLabel.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TriggerLabel.Location = new System.Drawing.Point(19, 19);
            this.TriggerLabel.Name = "TriggerLabel";
            this.TriggerLabel.Size = new System.Drawing.Size(81, 31);
            this.TriggerLabel.TabIndex = 15;
            this.TriggerLabel.Text = "Triggerbot";
            // 
            // TriggerSwitch
            // 
            this.TriggerSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TriggerSwitch.BorderRadius = 0;
            this.TriggerSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TriggerSwitch.Font = new System.Drawing.Font("Open Sans Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TriggerSwitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TriggerSwitch.Location = new System.Drawing.Point(143, 21);
            this.TriggerSwitch.Name = "TriggerSwitch";
            this.TriggerSwitch.Oncolor = System.Drawing.Color.SeaGreen;
            this.TriggerSwitch.Onoffcolor = System.Drawing.Color.Maroon;
            this.TriggerSwitch.Size = new System.Drawing.Size(51, 19);
            this.TriggerSwitch.TabIndex = 14;
            this.TriggerSwitch.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TriggerSwitch.Value = false;
            this.TriggerSwitch.Click += new System.EventHandler(this.TriggerSwitch_Click);
            // 
            // SwitchRounded
            // 
            this.SwitchRounded.ElipseRadius = 10;
            this.SwitchRounded.TargetControl = this.TriggerSwitch;
            // 
            // BhopRounded
            // 
            this.BhopRounded.ElipseRadius = 10;
            this.BhopRounded.TargetControl = this.BhopSwitch;
            // 
            // GlowRounded
            // 
            this.GlowRounded.ElipseRadius = 10;
            this.GlowRounded.TargetControl = this.GlowSwitch;
            // 
            // RecoilRounded
            // 
            this.RecoilRounded.ElipseRadius = 10;
            this.RecoilRounded.TargetControl = this.RecoilSwitch;
            // 
            // GlowSetsBox
            // 
            this.GlowSetsBox.Controls.Add(this.BoostFPSSlider);
            this.GlowSetsBox.Controls.Add(this.ThreadSleepLabel);
            this.GlowSetsBox.Controls.Add(this.BoostFPSCheck);
            this.GlowSetsBox.Location = new System.Drawing.Point(38, 144);
            this.GlowSetsBox.Name = "GlowSetsBox";
            this.GlowSetsBox.Size = new System.Drawing.Size(156, 85);
            this.GlowSetsBox.TabIndex = 22;
            this.GlowSetsBox.TabStop = false;
            // 
            // BoostFPSCheck
            // 
            this.BoostFPSCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BoostFPSCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BoostFPSCheck.Checked = true;
            this.BoostFPSCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BoostFPSCheck.ForeColor = System.Drawing.Color.White;
            this.BoostFPSCheck.Location = new System.Drawing.Point(126, 21);
            this.BoostFPSCheck.Name = "BoostFPSCheck";
            this.BoostFPSCheck.Size = new System.Drawing.Size(20, 20);
            this.BoostFPSCheck.TabIndex = 0;
            this.BoostFPSCheck.OnChange += new System.EventHandler(this.BoostFPSCheck_OnChange);
            // 
            // ThreadSleepLabel
            // 
            this.ThreadSleepLabel.AutoSize = true;
            this.ThreadSleepLabel.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreadSleepLabel.Location = new System.Drawing.Point(11, 22);
            this.ThreadSleepLabel.Name = "ThreadSleepLabel";
            this.ThreadSleepLabel.Size = new System.Drawing.Size(59, 15);
            this.ThreadSleepLabel.TabIndex = 1;
            this.ThreadSleepLabel.Text = "Boost FPS";
            // 
            // BoostFPSSlider
            // 
            this.BoostFPSSlider.BackColor = System.Drawing.Color.Transparent;
            this.BoostFPSSlider.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BoostFPSSlider.BorderRadius = 20;
            this.BoostFPSSlider.IndicatorColor = System.Drawing.Color.DarkCyan;
            this.BoostFPSSlider.Location = new System.Drawing.Point(23, 47);
            this.BoostFPSSlider.MaximumValue = 10;
            this.BoostFPSSlider.Name = "BoostFPSSlider";
            this.BoostFPSSlider.Size = new System.Drawing.Size(104, 30);
            this.BoostFPSSlider.TabIndex = 2;
            this.BoostFPSSlider.Value = 1;
            this.BoostFPSSlider.ValueChanged += new System.EventHandler(this.BoostFPSSlider_ValueChanged);
            // 
            // CheatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.GlowSetsBox);
            this.Controls.Add(this.RecoilLabel);
            this.Controls.Add(this.RecoilSwitch);
            this.Controls.Add(this.GlowLabel);
            this.Controls.Add(this.GlowSwitch);
            this.Controls.Add(this.BhopLabel);
            this.Controls.Add(this.BhopSwitch);
            this.Controls.Add(this.TriggerLabel);
            this.Controls.Add(this.TriggerSwitch);
            this.Name = "CheatPanel";
            this.Size = new System.Drawing.Size(333, 295);
            this.GlowSetsBox.ResumeLayout(false);
            this.GlowSetsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse SwitchRounded;
        private Bunifu.Framework.UI.BunifuElipse BhopRounded;
        private Bunifu.Framework.UI.BunifuElipse GlowRounded;
        private Bunifu.Framework.UI.BunifuElipse RecoilRounded;
        public Bunifu.Framework.UI.BunifuSwitch TriggerSwitch;
        public Bunifu.Framework.UI.BunifuSwitch BhopSwitch;
        public Bunifu.Framework.UI.BunifuSwitch GlowSwitch;
        public Bunifu.Framework.UI.BunifuSwitch RecoilSwitch;
        public Bunifu.Framework.UI.BunifuCustomLabel RecoilLabel;
        public Bunifu.Framework.UI.BunifuCustomLabel GlowLabel;
        public Bunifu.Framework.UI.BunifuCustomLabel BhopLabel;
        public Bunifu.Framework.UI.BunifuCustomLabel TriggerLabel;
        private System.Windows.Forms.GroupBox GlowSetsBox;
        private Bunifu.Framework.UI.BunifuCustomLabel ThreadSleepLabel;
        private Bunifu.Framework.UI.BunifuCheckbox BoostFPSCheck;
        private Bunifu.Framework.UI.BunifuSlider BoostFPSSlider;
    }
}
