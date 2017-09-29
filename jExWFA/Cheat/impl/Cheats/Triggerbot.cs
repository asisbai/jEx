using Managers;
using System.Threading;
using System;
using Utility;
using static Managers.jMemory;

namespace Cheats
{
    class Triggerbot
    {
        // TODO: MS Delay for legit (adjustable)
        public static void RunLoop()
        {
            while (true)
            {
                if (Settings.Trigger)
                {
                    int InCrosshair = Memory.Read<int>(CS.LocalPlayer + netvars.m_iCrosshairId);

                    int EnemyPlayer = Memory.Read<int>(manuals.mClient + signatures.dwEntityList + ((InCrosshair - 1) * manuals.dwEntityLoopDistance));
                    int EnemyHealth = Memory.Read<int>(EnemyPlayer + netvars.m_iHealth);
                    int EnemyTeam = Memory.Read<int>(EnemyPlayer + netvars.m_iTeamNum);

                    if (Keys.KEY_ALT_STATE)
                    {
                        if (EnemyHealth > 0 && EnemyTeam != CS.CurrentTeam)
                        {
                            Keys.mouse_event(Keys.MouseLeftDown, 0, 0, 0, new UIntPtr());
                            Keys.mouse_event(Keys.MouseLeftUp, 0, 0, 0, new UIntPtr());
                            Thread.Sleep(25);
                        }
                    }
                }
                Thread.Sleep(1);
            }
        }
    }
}