using Managers;
using System.Threading;
using System;
using Utility;
using static Managers.jMemory;

namespace Cheats
{
    class Glow
    {
        public static void RunLoop()
        {
            while (true)
            {
                if (Settings.Glow)
                {
                    GS Terrorist = new GS()
                    {
                        r = Settings.TColorR,
                        g = Settings.TColorG,
                        b = Settings.TColorB,
                        a = 1,
                        m_bRenderWhenOccluded = true
                    };

                    GS CounterTerrorist = new GS()
                    {
                        r = Settings.CTColorR,
                        g = Settings.CTColorG,
                        b = Settings.CTColorB,
                        a = 1,
                        m_bRenderWhenOccluded = true
                    };

                    for (var i = 0; i < 64; i++)
                    {
                        int LoadedEntities = Memory.Read<int>(manuals.mClient + signatures.dwEntityList + ((i - 1) * manuals.dwEntityLoopDistance));
                        int EntitiesHealth = Memory.Read<int>(LoadedEntities + netvars.m_iHealth);
                        int EntitiesTeam = Memory.Read<int>(LoadedEntities + netvars.m_iTeamNum);
                        int GlowObject = Memory.Read<int>(manuals.mClient + manuals.GlowObjectOffset);
                        int GlowIndex = Memory.Read<int>(LoadedEntities + netvars.m_iGlowIndex);

                        if (LoadedEntities == CS.LocalPlayer)
                            continue;
                        if (EntitiesHealth < 1)
                            continue;
                        if (Memory.Read<bool>(LoadedEntities + manuals.m_bIsDormant))
                            continue;

                        if (EntitiesTeam == 2)
                        {
                            int calc = GlowIndex * 0x38 + 0x4;
                            int current = GlowObject + calc;
                            Memory.Write<float>(current, Terrorist.r);

                            calc = GlowIndex * 0x38 + 0x8;
                            current = GlowObject + calc;
                            Memory.Write<float>(current, Terrorist.g);

                            calc = GlowIndex * 0x38 + 0xC;
                            current = GlowObject + calc;
                            Memory.Write<float>(current, Terrorist.b);

                            calc = GlowIndex * 0x38 + 0x10;
                            current = GlowObject + calc;
                            Memory.Write<float>(current, Terrorist.a);

                            calc = GlowIndex * 0x38 + 0x24;
                            current = GlowObject + calc;
                            Memory.Write<bool>(current, Terrorist.m_bRenderWhenOccluded);
                        }
                        else if (EntitiesTeam == 3)
                        {
                            int calc = GlowIndex * 0x38 + 0x4;
                            int current = GlowObject + calc;
                            Memory.Write<float>(current, CounterTerrorist.r);

                            calc = GlowIndex * 0x38 + 0x8;
                            current = GlowObject + calc;
                            Memory.Write<float>(current, CounterTerrorist.g);

                            calc = GlowIndex * 0x38 + 0xC;
                            current = GlowObject + calc;
                            Memory.Write<float>(current, CounterTerrorist.b);

                            calc = GlowIndex * 0x38 + 0x10;
                            current = GlowObject + calc;
                            Memory.Write<float>(current, CounterTerrorist.a);

                            calc = GlowIndex * 0x38 + 0x24;
                            current = GlowObject + calc;
                            Memory.Write<bool>(current, CounterTerrorist.m_bRenderWhenOccluded);
                        }
                    }
                }
                if (Settings.GlowSleep)
                    Thread.Sleep(Settings.GlowSleepAmnt);
            }
        }

        public struct GS
        {
            public float r;
            public float g;
            public float b;
            public float a;
            public bool m_bRenderWhenOccluded;
        };
    }
}
