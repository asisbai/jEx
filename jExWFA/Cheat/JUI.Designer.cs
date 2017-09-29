namespace jExWFA
{
    partial class JUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JUI));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.ColorButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CheatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Logo = new System.Windows.Forms.Panel();
            this.LogoText = new System.Windows.Forms.Label();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.MinimiseButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CloseButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Dragging = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Rounded = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SwitchRounded = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BhopRounded = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.GlowRounded = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.RecoilRounded = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelColor = new jExWFA.Cheat.User_Controls.ColorPanel();
            this.PanelCheat = new jExWFA.Cheat.CheatPanel();
            this.LeftPanel.SuspendLayout();
            this.Logo.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.LeftPanel.Controls.Add(this.ColorButton);
            this.LeftPanel.Controls.Add(this.CheatButton);
            this.LeftPanel.Controls.Add(this.Logo);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 405);
            this.LeftPanel.TabIndex = 0;
            // 
            // ColorButton
            // 
            this.ColorButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ColorButton.BorderRadius = 0;
            this.ColorButton.ButtonText = "Colors";
            this.ColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorButton.DisabledColor = System.Drawing.Color.Gray;
            this.ColorButton.ForeColor = System.Drawing.Color.White;
            this.ColorButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ColorButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("ColorButton.Iconimage")));
            this.ColorButton.Iconimage_right = null;
            this.ColorButton.Iconimage_right_Selected = null;
            this.ColorButton.Iconimage_Selected = null;
            this.ColorButton.IconMarginLeft = 0;
            this.ColorButton.IconMarginRight = 0;
            this.ColorButton.IconRightVisible = true;
            this.ColorButton.IconRightZoom = 0D;
            this.ColorButton.IconVisible = true;
            this.ColorButton.IconZoom = 65D;
            this.ColorButton.IsTab = false;
            this.ColorButton.Location = new System.Drawing.Point(0, 98);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ColorButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ColorButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ColorButton.selected = false;
            this.ColorButton.Size = new System.Drawing.Size(200, 48);
            this.ColorButton.TabIndex = 2;
            this.ColorButton.Text = "Colors";
            this.ColorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ColorButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ColorButton.TextFont = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // CheatButton
            // 
            this.CheatButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CheatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.CheatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CheatButton.BorderRadius = 0;
            this.CheatButton.ButtonText = "Cheats";
            this.CheatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheatButton.DisabledColor = System.Drawing.Color.Gray;
            this.CheatButton.ForeColor = System.Drawing.Color.White;
            this.CheatButton.Iconcolor = System.Drawing.Color.Transparent;
            this.CheatButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("CheatButton.Iconimage")));
            this.CheatButton.Iconimage_right = null;
            this.CheatButton.Iconimage_right_Selected = null;
            this.CheatButton.Iconimage_Selected = null;
            this.CheatButton.IconMarginLeft = 0;
            this.CheatButton.IconMarginRight = 0;
            this.CheatButton.IconRightVisible = true;
            this.CheatButton.IconRightZoom = 0D;
            this.CheatButton.IconVisible = true;
            this.CheatButton.IconZoom = 70D;
            this.CheatButton.IsTab = false;
            this.CheatButton.Location = new System.Drawing.Point(0, 51);
            this.CheatButton.Name = "CheatButton";
            this.CheatButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.CheatButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CheatButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CheatButton.selected = false;
            this.CheatButton.Size = new System.Drawing.Size(200, 48);
            this.CheatButton.TabIndex = 1;
            this.CheatButton.Text = "Cheats";
            this.CheatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheatButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CheatButton.TextFont = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheatButton.Click += new System.EventHandler(this.CheatButton_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Logo.Controls.Add(this.LogoText);
            this.Logo.Cursor = System.Windows.Forms.Cursors.Default;
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(200, 51);
            this.Logo.TabIndex = 0;
            // 
            // LogoText
            // 
            this.LogoText.AutoSize = true;
            this.LogoText.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.LogoText.Location = new System.Drawing.Point(4, 8);
            this.LogoText.Name = "LogoText";
            this.LogoText.Size = new System.Drawing.Size(160, 26);
            this.LogoText.TabIndex = 0;
            this.LogoText.Text = "Faygo\'s External";
            this.LogoText.Click += new System.EventHandler(this.LogoText_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.PanelTop.Controls.Add(this.MinimiseButton);
            this.PanelTop.Controls.Add(this.CloseButton);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(200, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(563, 51);
            this.PanelTop.TabIndex = 1;
            // 
            // MinimiseButton
            // 
            this.MinimiseButton.Activecolor = System.Drawing.Color.Transparent;
            this.MinimiseButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimiseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimiseButton.BorderRadius = 0;
            this.MinimiseButton.ButtonText = "-";
            this.MinimiseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimiseButton.DisabledColor = System.Drawing.Color.DimGray;
            this.MinimiseButton.Font = new System.Drawing.Font("Open Sans Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimiseButton.Iconcolor = System.Drawing.Color.Transparent;
            this.MinimiseButton.Iconimage = null;
            this.MinimiseButton.Iconimage_right = null;
            this.MinimiseButton.Iconimage_right_Selected = null;
            this.MinimiseButton.Iconimage_Selected = null;
            this.MinimiseButton.IconMarginLeft = 0;
            this.MinimiseButton.IconMarginRight = 0;
            this.MinimiseButton.IconRightVisible = true;
            this.MinimiseButton.IconRightZoom = 0D;
            this.MinimiseButton.IconVisible = true;
            this.MinimiseButton.IconZoom = 90D;
            this.MinimiseButton.IsTab = false;
            this.MinimiseButton.Location = new System.Drawing.Point(502, 9);
            this.MinimiseButton.Margin = new System.Windows.Forms.Padding(6);
            this.MinimiseButton.Name = "MinimiseButton";
            this.MinimiseButton.Normalcolor = System.Drawing.Color.Transparent;
            this.MinimiseButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.MinimiseButton.OnHoverTextColor = System.Drawing.Color.DarkCyan;
            this.MinimiseButton.selected = false;
            this.MinimiseButton.Size = new System.Drawing.Size(26, 30);
            this.MinimiseButton.TabIndex = 1;
            this.MinimiseButton.Text = "-";
            this.MinimiseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinimiseButton.Textcolor = System.Drawing.Color.DimGray;
            this.MinimiseButton.TextFont = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimiseButton.Click += new System.EventHandler(this.MinimiseButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Activecolor = System.Drawing.Color.Transparent;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.BorderRadius = 0;
            this.CloseButton.ButtonText = "X";
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.DisabledColor = System.Drawing.Color.DimGray;
            this.CloseButton.Font = new System.Drawing.Font("Open Sans Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Iconcolor = System.Drawing.Color.Transparent;
            this.CloseButton.Iconimage = null;
            this.CloseButton.Iconimage_right = null;
            this.CloseButton.Iconimage_right_Selected = null;
            this.CloseButton.Iconimage_Selected = null;
            this.CloseButton.IconMarginLeft = 0;
            this.CloseButton.IconMarginRight = 0;
            this.CloseButton.IconRightVisible = true;
            this.CloseButton.IconRightZoom = 0D;
            this.CloseButton.IconVisible = true;
            this.CloseButton.IconZoom = 90D;
            this.CloseButton.IsTab = false;
            this.CloseButton.Location = new System.Drawing.Point(531, 9);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Normalcolor = System.Drawing.Color.Transparent;
            this.CloseButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.CloseButton.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.CloseButton.selected = false;
            this.CloseButton.Size = new System.Drawing.Size(26, 30);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Textcolor = System.Drawing.Color.DimGray;
            this.CloseButton.TextFont = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Dragging
            // 
            this.Dragging.Fixed = false;
            this.Dragging.Horizontal = true;
            this.Dragging.TargetControl = this;
            this.Dragging.Vertical = true;
            // 
            // Rounded
            // 
            this.Rounded.ElipseRadius = 20;
            this.Rounded.TargetControl = this;
            // 
            // SwitchRounded
            // 
            this.SwitchRounded.ElipseRadius = 10;
            this.SwitchRounded.TargetControl = this;
            // 
            // BhopRounded
            // 
            this.BhopRounded.ElipseRadius = 10;
            this.BhopRounded.TargetControl = this;
            // 
            // GlowRounded
            // 
            this.GlowRounded.ElipseRadius = 10;
            this.GlowRounded.TargetControl = this;
            // 
            // RecoilRounded
            // 
            this.RecoilRounded.ElipseRadius = 10;
            this.RecoilRounded.TargetControl = this;
            // 
            // PanelColor
            // 
            this.PanelColor.BackColor = System.Drawing.Color.Transparent;
            this.PanelColor.Location = new System.Drawing.Point(200, -13);
            this.PanelColor.Name = "PanelColor";
            this.PanelColor.Size = new System.Drawing.Size(310, 305);
            this.PanelColor.TabIndex = 3;
            this.PanelColor.Visible = false;
            // 
            // PanelCheat
            // 
            this.PanelCheat.BackColor = System.Drawing.Color.Transparent;
            this.PanelCheat.Location = new System.Drawing.Point(200, 51);
            this.PanelCheat.Name = "PanelCheat";
            this.PanelCheat.Size = new System.Drawing.Size(333, 295);
            this.PanelCheat.TabIndex = 4;
            // 
            // JUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(763, 405);
            this.Controls.Add(this.PanelCheat);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.PanelColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JUI";
            this.Text = "jEx";
            this.Load += new System.EventHandler(this.JUI_Load);
            this.LeftPanel.ResumeLayout(false);
            this.Logo.ResumeLayout(false);
            this.Logo.PerformLayout();
            this.PanelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.Panel PanelTop;
        private Bunifu.Framework.UI.BunifuFlatButton CheatButton;
        private Bunifu.Framework.UI.BunifuDragControl Dragging;
        private Bunifu.Framework.UI.BunifuElipse Rounded;
        private Bunifu.Framework.UI.BunifuFlatButton ColorButton;
        private Bunifu.Framework.UI.BunifuFlatButton CloseButton;
        private Bunifu.Framework.UI.BunifuFlatButton MinimiseButton;
        private Bunifu.Framework.UI.BunifuElipse SwitchRounded;
        private Bunifu.Framework.UI.BunifuElipse BhopRounded;
        private Bunifu.Framework.UI.BunifuElipse GlowRounded;
        private Bunifu.Framework.UI.BunifuElipse RecoilRounded;
        private Cheat.User_Controls.ColorPanel PanelColor;
        private Cheat.CheatPanel PanelCheat;
    }
}

