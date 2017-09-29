using System;
using System.Threading;
using System.Drawing;
using Managers;
using static Managers.jMemory;
using Cheats;
using jExWFA.Cheat;
using System.Windows.Forms;

namespace jExWFA
{
    public partial class JUI : Form
    {
        // TODO: Page for category of hacks not just a "CHEATS" page
        CheatPanel PanelCh = new CheatPanel();

        public JUI()
        {
            InitializeComponent();
            InitialiseMemory();
            InitialiseThreads();
            Utility.Keys.SetHook();
        }

        // BUDGET as anything way of displaying new tabs.
        private void CheatControls(bool b)
        {
            PanelCheat.Visible = b;
        }

        private void ColorControls(bool c)
        {
            PanelColor.Visible = c;
        }

        // Memory Manager initialisation.
        private void InitialiseMemory()
        {
            Memory.Init("csgo");

            manuals.mClient = Memory.GetModuleAdress("client");
            manuals.mEngine = Memory.GetModuleAdress("engine");
        }

        // Thread initialisation.
        private void InitialiseThreads()
        {
            Thread Trigger = new Thread(Triggerbot.RunLoop);
            Trigger.Start();

            Thread GlowHack = new Thread(Glow.RunLoop);
            GlowHack.Start();

            Thread Recoil = new Thread(RCS.RunLoop);
            Recoil.Start();
        }


        /* GUI Controls and mess ;) */

        private void JUI_Load(object sender, EventArgs e)
        {
            CheatButton.selected = true;
        }

        private void CheatButton_Click(object sender, EventArgs e)
        {
            CheatControls(true);
            ColorControls(false);

            CheatButton.Normalcolor = Color.FromArgb(51, 51, 51);
            ColorButton.Normalcolor = Color.FromArgb(61, 61, 61);
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            CheatControls(false);
            ColorControls(true);

            CheatButton.Normalcolor = Color.FromArgb(61, 61, 61);
            ColorButton.Normalcolor = Color.FromArgb(51, 51, 51);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(404);
        }

        private void MinimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogoText_Click(object sender, EventArgs e)
        {

        }
    }
}