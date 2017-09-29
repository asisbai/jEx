using System;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Managers
{
    class jMemory
    {
        public class Memory
        {
            public static Process m_pProc;
            public static IntPtr m_pProcHandle;

            public static int m_iNumberOfBytesRead = 0;
            public static int m_iNumberOfBytesWritten = 0;

            public static void Init(string ProcString)
            {
                if (Process.GetProcessesByName(ProcString).Length > 0)
                    m_pProc = Process.GetProcessesByName(ProcString)[0];
                else
                {
                    MessageBox.Show("Failed to discover " + ProcString + "! Please ensure the program is running.", "Process not discovered!", MessageBoxButtons.OK);
                    Environment.Exit(404);
                }

                m_pProcHandle = OpenProcess(PROCESS_VM_OPERATION | PROCESS_VM_READ | PROCESS_VM_WRITE, false, m_pProc.Id);
            }

            public static int GetModuleAdress(string ModuleName)
            {
                try
                {
                    foreach (ProcessModule ProcMod in m_pProc.Modules)
                    {
                        if (!ModuleName.Contains(".dll"))
                            ModuleName = ModuleName.Insert(ModuleName.Length, ".dll");

                        if (ModuleName == ProcMod.ModuleName)
                        {
                            return (int)ProcMod.BaseAddress;
                        }
                    }
                }
                catch { }
                return -1;
            }

            public static T Read<T>(int Address) where T : struct
            {
                int ByteSize = Marshal.SizeOf(typeof(T));
                byte[] buffer = new byte[ByteSize];
                ReadProcessMemory((int)m_pProcHandle, Address, buffer, buffer.Length, ref m_iNumberOfBytesRead);

                return ByteArrayToStructure<T>(buffer);
            }

            public static float[] ReadMatrix<T>(int Address, int MatrixSize) where T : struct
            {
                int ByteSize = Marshal.SizeOf(typeof(T));
                byte[] buffer = new byte[ByteSize * MatrixSize];
                ReadProcessMemory((int)m_pProcHandle, Address, buffer, buffer.Length, ref m_iNumberOfBytesRead);

                return ConvertToFloatArray(buffer);
            }

            public static void Write<T>(int Address, object Value)
            {
                byte[] buffer = StructureToByteArray(Value);

                WriteProcessMemory((int)m_pProcHandle, Address, buffer, buffer.Length, out m_iNumberOfBytesWritten);
            }

            public static void Write<T>(int Address, char[] Value)
            {
                byte[] buffer = Encoding.UTF8.GetBytes(Value);

                WriteProcessMemory((int)m_pProcHandle, Address, buffer, buffer.Length, out m_iNumberOfBytesWritten);
            }

            #region Transform

            public static float[] ConvertToFloatArray(byte[] bytes)
            {
                if (bytes.Length % 4 != 0)
                    throw new ArgumentException();

                float[] floats = new float[bytes.Length / 4];

                for (int i = 0; i < floats.Length; i++)
                    floats[i] = BitConverter.ToSingle(bytes, i * 4);

                return floats;
            }

            private static T ByteArrayToStructure<T>(byte[] bytes) where T : struct
            {
                var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
                try
                {
                    return (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
                }
                finally
                {
                    handle.Free();
                }
            }

            private static byte[] StructureToByteArray(object objec)
            {
                int length = Marshal.SizeOf(objec);

                byte[] array = new byte[length];

                IntPtr ptr = Marshal.AllocHGlobal(length);

                Marshal.StructureToPtr(objec, ptr, true);
                Marshal.Copy(ptr, array, 0, length);
                Marshal.FreeHGlobal(ptr);

                return array;
            }

            #endregion

            #region DllImports

            [DllImport("kernel32")]
            private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

            [DllImport("kernel32")]
            private static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, ref int lpNumberOfBytesRead);

            [DllImport("kernel32")]
            private static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, out int lpNumberOfBytesWritten);

            #endregion

            #region Constants

            const int PROCESS_VM_OPERATION = 0x0008;
            const int PROCESS_VM_READ = 0x0010;
            const int PROCESS_VM_WRITE = 0x0020;

            #endregion
        }
    }
}
