using System;

namespace ImGuiEx
{
    public abstract class Application
    {
        static bool isRuntime = false;
        static ImGuiExNative.Callback m_Action = null;

        /// <summary>
        /// Check application whether running
        /// </summary>
        public static bool IsRunning => isRuntime;

        /// <summary>
        /// Run application 
        /// </summary>
        public bool Run()
        {
            m_Action = new ImGuiExNative.Callback(OnGui);

            if (IsRunning == false)
            {
                try
                {
                    ImGuiExNative.AddRenderCallback(m_Action);
                    isRuntime = true;
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }

        protected abstract void OnGui();
    }
}
