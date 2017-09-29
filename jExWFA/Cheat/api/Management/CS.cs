using static Managers.jMemory;

namespace Managers
{
    class CS
    {
        public static int LocalPlayer = Memory.Read<int>(manuals.mClient + signatures.dwLocalPlayer);
        public static int ClientState = Memory.Read<int>(manuals.mEngine + manuals.dwClientState);

        public static int CurrentTeam = Memory.Read<int>(LocalPlayer + netvars.m_iTeamNum);
    }
}
