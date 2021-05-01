using System;
using System.Collections.Generic;
using ImGuiNET;

namespace ImGuiEx
{
    public interface ImGuiExView
    {
        /// <summary>
        /// General Render Gui Interface
        /// </summary>
        void OnGui();
    }

    /*
    public class AImGuiExTest
    {
        public static int s_int = 4;
        public static float s_float = 1.0f;
        public static double s_double = 1.0;
        public static string s_string = "saeae";

        public static AImGuiExTest instance = new AImGuiExTest();
        public static AImGuiExTest Instance => instance;

        public static void TestPrint() => Console.WriteLine("aseease");

        public static int TestProperty => 1;
        public static int TestProperty1 {get;set;} = 2;

        public int m_int = 4;
        public float m_float = 1.0f;
        public double m_double = 1.0;
        public string m_string = "saeae";

        public static int Add(int a,float b,double c)
        {
            int res = a + (int)b + (int)c;
            Console.WriteLine(res);
            return res;
        }

        public int Substartc(int a, float b, double c)
        {
            int res = a + (int)b + (int)c;
            Console.WriteLine(res);
            return res;
        }

        public static AImGuiExTest GetADDInstance(int a, int b, int c)
        {

            int res = a + (int)b + (int)c;
            if(res == 15)
            {
                return instance;
            }
            return null;
        }
    }*/

    /// <summary>
    /// Manage imgui global label id
    /// </summary>
    class LabelManager
    {
        static HashSet<string> s_LabelSet = new HashSet<string>();

        /// <summary>
        /// Get imgui new global label id
        /// </summary>
        public static string GetNewID()
        {
            int index = 0;
            string labelID = NewIDPrefix + index;
            while (s_LabelSet.Contains(labelID))
            {
                ++index;
                labelID = NewIDPrefix + index;
            }

            return labelID;
        }

        static string NewIDPrefix = "##ImGuiExView";
    }

    /// <summary>
    ///  Encapsulation ImGui Begin
    /// </summary>
    public abstract class Window : ImGuiExView
    {
        bool m_Ishow = true;

        public virtual void OnGui()
        {
            if (!m_Ishow) return;

            ImGui.Begin(WindowName, ref m_Ishow, WindowFlags);
            DrawWindowContent();
            ImGui.End();
        }

        public virtual void ShowWindow() => m_Ishow = true;
        public virtual void CloseWindow() => m_Ishow = false;

        public virtual ImGuiWindowFlags WindowFlags => ImGuiWindowFlags.None;
        public abstract string WindowName { get; }

        protected abstract void DrawWindowContent();
    }

    public abstract class IDView : ImGuiExView
    {
        string m_ID = LabelManager.GetNewID();
        public string ViewID
        {
            get => m_ID;
        }

        public abstract void OnGui();
    }

    /// <summary>
    ///  Encapsulation ImGui BeginTable
    /// </summary>
    public abstract class Table : IDView
    {
        public virtual ImGuiTableFlags TableFlags
        {
            get => ImGuiTableFlags.None;
        }

        public abstract string[] TableTitles
        {
            get;
        }
        protected virtual void NextRow() => ImGui.TableNextRow();
        protected virtual void NextColumn() => ImGui.TableNextColumn();

        protected virtual void TableSetupHeaders(params string[] strs)
        {
            ImGui.TableSetupScrollFreeze(0, 1); // Make top row always visible
            foreach (string str in strs)
            {
                ImGui.TableSetupColumn(str);
            }
        }

        public override void OnGui()
        {
            if (ImGui.BeginTable(ViewID, TableTitles.Length, TableFlags))
            {
                TableSetupHeaders(TableTitles);

                DrawContent();
                ImGui.EndTable();
            }
        }

        protected abstract void DrawContent();
    }

    /// <summary>
    /// Encapsulation ImGui BeginTabBar
    /// </summary>
    public abstract class TabBar : IDView
    {
        public virtual ImGuiTabBarFlags TabBarFlags => ImGuiTabBarFlags.None;

        #region TabItem
        protected void TabItemView(string label, ImGuiExNative.Callback action)
        {
            if (ImGui.BeginTabItem(label))
            {
                action();
                ImGui.EndTabItem();
            };
        }

        protected void TabItemView(string label, ImGuiExNative.Callback action, ref bool p_open)
        {
            if (ImGui.BeginTabItem(label, ref p_open))
            {
                action();
                ImGui.EndTabItem();
            };
        }

        protected void TabItemView(string label, ImGuiExNative.Callback action, ref bool p_open, ImGuiTabItemFlags flags)
        {
            if (ImGui.BeginTabItem(label, ref p_open, flags))
            {
                action();
                ImGui.EndTabItem();
            };
        }
        #endregion

        public override void OnGui()
        {
            if (ImGui.BeginTabBar(ViewID, TabBarFlags))
            {
                DrawContent();
                ImGui.EndTabBar();
            }
        }

        public abstract void DrawContent();
    }

    /// <summary>
    /// ImGui Popup Context Encapsulation
    /// </summary>
    public abstract class PopupMenu : IDView
    {
        public override void OnGui()
        {
            if (ImGui.BeginPopupContextItem(ViewID, PopupFlags))
            {
                DrawContent();
                ImGui.EndPopup();
            }
        }
        public virtual bool IsOpen() => ImGui.IsPopupOpen(ViewID);
        public virtual void OpenPopupOnItemClick() => ImGui.OpenPopupOnItemClick(ViewID, PopupFlags);
        public virtual void OpenPopup() => ImGui.OpenPopup(ViewID, PopupFlags);
        public virtual ImGuiPopupFlags PopupFlags => ImGuiPopupFlags.None;

        protected abstract void DrawContent();
    }

}
