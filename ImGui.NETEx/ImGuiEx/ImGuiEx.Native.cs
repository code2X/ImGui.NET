using System;
using System.Runtime.InteropServices;
using ImGuiNET;

namespace ImGuiEx
{
    public static unsafe partial class ImGuiExNative
    {
        public delegate void Callback();

        [DllImport(ImportConfig.DLL_PATH, EntryPoint = "AddRenderCallback")]
        public static extern void AddRenderCallback(Callback callback);
    }
}
