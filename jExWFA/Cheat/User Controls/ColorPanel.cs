using System;
using Managers;
using System.Windows.Forms;

namespace jExWFA.Cheat.User_Controls
{
    public partial class ColorPanel : UserControl
    {
        public ColorPanel()
        {
            InitializeComponent();
        }

        private void TButtonC_Click(object sender, EventArgs e)
        {
            if (TGlowC.ShowDialog() == DialogResult.OK)
            {
                Settings.TColorR = TGlowC.Color.R / 255.0f;
                Settings.TColorG = TGlowC.Color.G / 255.0f;
                Settings.TColorB = TGlowC.Color.B / 255.0f;
            }
        }

        private void CTButtonC_Click(object sender, EventArgs e)
        {
            if (CTGlowC.ShowDialog() == DialogResult.OK)
            {
                Settings.CTColorR = CTGlowC.Color.R / 255.0f;
                Settings.CTColorG = CTGlowC.Color.G / 255.0f;
                Settings.CTColorB = CTGlowC.Color.B / 255.0f;
            }
        }
    }
}
