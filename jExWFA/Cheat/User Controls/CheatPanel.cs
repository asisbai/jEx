using System;
using System.Drawing;
using Managers;
using System.Windows.Forms;

namespace jExWFA.Cheat
{
    public partial class CheatPanel : UserControl
    {
        public CheatPanel()
        {
            InitializeComponent();
        }

        private void TriggerSwitch_Click(object sender, EventArgs e)
        {
            Settings.Trigger = TriggerSwitch.Value;
        }

        private void BhopSwitch_Click(object sender, EventArgs e)
        {
            Settings.Bhop = BhopSwitch.Value;
        }

        private void GlowSwitch_Click(object sender, EventArgs e)
        {
            Settings.Glow = GlowSwitch.Value;
        }

        private void RecoilSwitch_Click(object sender, EventArgs e)
        {
            Settings.RCS = RecoilSwitch.Value;
        }

        private void BoostFPSCheck_OnChange(object sender, EventArgs e)
        {
            Settings.GlowSleep = BoostFPSCheck.Checked;
        }

        private void BoostFPSSlider_ValueChanged(object sender, EventArgs e)
        {
            Settings.GlowSleepAmnt = BoostFPSSlider.Value;
        }
    }
}
