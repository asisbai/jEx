namespace jExWFA.Cheat.User_Controls
{
    partial class ColorPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPanel));
            this.TGlowC = new System.Windows.Forms.ColorDialog();
            this.CTGlowC = new System.Windows.Forms.ColorDialog();
            this.TButtonC = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TButtonCRounded = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CTButtonCRounded = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CTButtonC = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // TButtonC
            // 
            this.TButtonC.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(38)))));
            this.TButtonC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(107)))), ((int)(((byte)(28)))));
            this.TButtonC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TButtonC.BorderRadius = 0;
            this.TButtonC.ButtonText = "Terrorist Color";
            this.TButtonC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TButtonC.DisabledColor = System.Drawing.Color.Gray;
            this.TButtonC.Iconcolor = System.Drawing.Color.Transparent;
            this.TButtonC.Iconimage = ((System.Drawing.Image)(resources.GetObject("TButtonC.Iconimage")));
            this.TButtonC.Iconimage_right = null;
            this.TButtonC.Iconimage_right_Selected = null;
            this.TButtonC.Iconimage_Selected = null;
            this.TButtonC.IconMarginLeft = 0;
            this.TButtonC.IconMarginRight = 0;
            this.TButtonC.IconRightVisible = true;
            this.TButtonC.IconRightZoom = 0D;
            this.TButtonC.IconVisible = true;
            this.TButtonC.IconZoom = 60D;
            this.TButtonC.IsTab = false;
            this.TButtonC.Location = new System.Drawing.Point(24, 77);
            this.TButtonC.Name = "TButtonC";
            this.TButtonC.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(107)))), ((int)(((byte)(28)))));
            this.TButtonC.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(97)))), ((int)(((byte)(18)))));
            this.TButtonC.OnHoverTextColor = System.Drawing.Color.White;
            this.TButtonC.selected = false;
            this.TButtonC.Size = new System.Drawing.Size(241, 48);
            this.TButtonC.TabIndex = 0;
            this.TButtonC.Text = "Terrorist Color";
            this.TButtonC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonC.Textcolor = System.Drawing.Color.Black;
            this.TButtonC.TextFont = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TButtonC.Click += new System.EventHandler(this.TButtonC_Click);
            // 
            // TButtonCRounded
            // 
            this.TButtonCRounded.ElipseRadius = 10;
            this.TButtonCRounded.TargetControl = this.TButtonC;
            // 
            // CTButtonCRounded
            // 
            this.CTButtonCRounded.ElipseRadius = 10;
            this.CTButtonCRounded.TargetControl = this.CTButtonC;
            // 
            // CTButtonC
            // 
            this.CTButtonC.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.CTButtonC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.CTButtonC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CTButtonC.BorderRadius = 0;
            this.CTButtonC.ButtonText = "Counter-Terrorist Color";
            this.CTButtonC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonC.DisabledColor = System.Drawing.Color.Gray;
            this.CTButtonC.Iconcolor = System.Drawing.Color.Transparent;
            this.CTButtonC.Iconimage = ((System.Drawing.Image)(resources.GetObject("CTButtonC.Iconimage")));
            this.CTButtonC.Iconimage_right = null;
            this.CTButtonC.Iconimage_right_Selected = null;
            this.CTButtonC.Iconimage_Selected = null;
            this.CTButtonC.IconMarginLeft = 0;
            this.CTButtonC.IconMarginRight = 0;
            this.CTButtonC.IconRightVisible = true;
            this.CTButtonC.IconRightZoom = 0D;
            this.CTButtonC.IconVisible = true;
            this.CTButtonC.IconZoom = 60D;
            this.CTButtonC.IsTab = false;
            this.CTButtonC.Location = new System.Drawing.Point(24, 163);
            this.CTButtonC.Name = "CTButtonC";
            this.CTButtonC.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.CTButtonC.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.CTButtonC.OnHoverTextColor = System.Drawing.Color.White;
            this.CTButtonC.selected = false;
            this.CTButtonC.Size = new System.Drawing.Size(241, 48);
            this.CTButtonC.TabIndex = 1;
            this.CTButtonC.Text = "Counter-Terrorist Color";
            this.CTButtonC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CTButtonC.Textcolor = System.Drawing.Color.Black;
            this.CTButtonC.TextFont = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonC.Click += new System.EventHandler(this.CTButtonC_Click);
            // 
            // ColorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.CTButtonC);
            this.Controls.Add(this.TButtonC);
            this.Name = "ColorPanel";
            this.Size = new System.Drawing.Size(310, 305);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog TGlowC;
        private System.Windows.Forms.ColorDialog CTGlowC;
        private Bunifu.Framework.UI.BunifuFlatButton TButtonC;
        private Bunifu.Framework.UI.BunifuElipse TButtonCRounded;
        private Bunifu.Framework.UI.BunifuElipse CTButtonCRounded;
        private Bunifu.Framework.UI.BunifuFlatButton CTButtonC;
    }
}
