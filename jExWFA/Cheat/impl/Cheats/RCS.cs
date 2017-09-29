using Managers;
using System.Threading;
using System;
using Utility;
using static Managers.jMemory;


namespace Cheats
{
    class RCS
    {
        // TODO: Antiuntrusted & Adjustable accuracy.

        public static float[] OldAimPunch = { 0, 0 };
        public static void RunLoop()
        {
            while (true)
            {
                int ShotsFired = Memory.Read<int>(CS.LocalPlayer + netvars.m_iShotsFired);

                if (Settings.RCS)
                {
                    if (ShotsFired > 1)
                    {
                        float[] AimPunch = { Memory.Read<float>(CS.LocalPlayer + netvars.m_aimPunchAngle) * 2.0f, Memory.Read<float>(CS.LocalPlayer + netvars.m_aimPunchAngle + 0x4) * 2.0f };
                        float[] CurrentViewAngles = { Memory.Read<float>(CS.ClientState + signatures.dwClientState_ViewAngles), Memory.Read<float>(CS.ClientState + signatures.dwClientState_ViewAngles + 0x4) };
                        float[] NewViewAngles = { ((CurrentViewAngles[0] + OldAimPunch[0]) - AimPunch[0]), ((CurrentViewAngles[1] + OldAimPunch[1]) - AimPunch[1]) };

                        OldAimPunch = AimPunch;

                        Memory.Write<float>(CS.ClientState + signatures.dwClientState_ViewAngles, NewViewAngles[0]);
                        Memory.Write<float>(CS.ClientState + signatures.dwClientState_ViewAngles + 0x4, NewViewAngles[1]);
                        Thread.Sleep(1);
                    }
                    else
                    {
                        OldAimPunch[0] = 0;
                        OldAimPunch[1] = 0;
                    }
                    Thread.Sleep(1);
                }
            }
        }
    }
}
