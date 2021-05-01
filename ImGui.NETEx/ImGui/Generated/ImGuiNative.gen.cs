using System;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    public static unsafe partial class ImGuiNative
    {
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* igAcceptDragDropPayload(byte* type, ImGuiDragDropFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igAlignTextToFramePadding();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igArrowButton(byte* str_id, ImGuiDir dir);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBegin(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginChildStr(byte* str_id, Vector2 size, byte border, ImGuiWindowFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginChildID(uint id, Vector2 size, byte border, ImGuiWindowFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginChildFrame(uint id, Vector2 size, ImGuiWindowFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginCombo(byte* label, byte* preview_value, ImGuiComboFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginDragDropSource(ImGuiDragDropFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginDragDropTarget();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginGroup();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginListBox(byte* label, Vector2 size);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginMainMenuBar();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginMenu(byte* label, byte enabled);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginMenuBar();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopup(byte* str_id, ImGuiWindowFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupContextItem(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupContextVoid(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupContextWindow(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupModal(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTabBar(byte* str_id, ImGuiTabBarFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTabItem(byte* label, byte* p_open, ImGuiTabItemFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTable(byte* str_id, int column, ImGuiTableFlags flags, Vector2 outer_size, float inner_width);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginTooltip();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBullet();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBulletText(byte* fmt);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igButton(byte* label, Vector2 size);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float igCalcItemWidth();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCalcListClipping(int items_count, float items_height, int* out_items_display_start, int* out_items_display_end);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCalcTextSize(Vector2* pOut, byte* text, byte* text_end, byte hide_text_after_double_hash, float wrap_width);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCaptureKeyboardFromApp(byte want_capture_keyboard_value);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCaptureMouseFromApp(byte want_capture_mouse_value);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckbox(byte* label, byte* v);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckboxFlagsIntPtr(byte* label, int* flags, int flags_value);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckboxFlagsUintPtr(byte* label, uint* flags, uint flags_value);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCloseCurrentPopup();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCollapsingHeaderTreeNodeFlags(byte* label, ImGuiTreeNodeFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCollapsingHeaderBoolPtr(byte* label, byte* p_visible, ImGuiTreeNodeFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorButton(byte* desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igColorConvertFloat4ToU32(Vector4 @in);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorConvertU32ToFloat4(Vector4* pOut, uint @in);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorEdit3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorEdit4(byte* label, Vector4* col, ImGuiColorEditFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorPicker3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorPicker4(byte* label, Vector4* col, ImGuiColorEditFlags flags, float* ref_col);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColumns(int count, byte* id, byte border);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igComboStr_arr(byte* label, int* current_item, byte** items, int items_count, int popup_max_height_in_items);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igComboStr(byte* label, int* current_item, byte* items_separated_by_zeros, int popup_max_height_in_items);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igCreateContext(ImFontAtlas* shared_font_atlas);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDebugCheckVersionAndDataLayout(byte* version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDestroyContext(IntPtr ctx);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDestroyPlatformWindows();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockSpace(uint id, Vector2 size, ImGuiDockNodeFlags flags, ImGuiWindowClass* window_class);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igDockSpaceOverViewport(ImGuiViewport* viewport, ImGuiDockNodeFlags flags, ImGuiWindowClass* window_class);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat2(byte* label, Vector2* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat3(byte* label, Vector3* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat4(byte* label, Vector4* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloatRange2(byte* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt2(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt3(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt4(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragIntRange2(byte* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragScalar(byte* label, ImGuiDataType data_type, void* p_data, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDummy(Vector2 size);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEnd();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndChild();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndChildFrame();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndCombo();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndDragDropSource();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndDragDropTarget();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndFrame();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndGroup();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndListBox();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndMainMenuBar();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndMenu();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndMenuBar();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndPopup();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndTabBar();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndTabItem();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndTable();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndTooltip();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* igFindViewportByID(uint id);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* igFindViewportByPlatformHandle(void* platform_handle);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetAllocatorFunctions(IntPtr* p_alloc_func, IntPtr* p_free_func, void** p_user_data);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetBackgroundDrawListNil();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetBackgroundDrawListViewportPtr(ImGuiViewport* viewport);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igGetClipboardText();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColorU32Col(ImGuiCol idx, float alpha_mul);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColorU32Vec4(Vector4 col);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColorU32U32(uint col);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetColumnIndex();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnOffset(int column_index);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetColumnsCount();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnWidth(int column_index);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetContentRegionAvail(Vector2* pOut);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetContentRegionMax(Vector2* pOut);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igGetCurrentContext();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetCursorPos(Vector2* pOut);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetCursorPosX();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetCursorPosY();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetCursorScreenPos(Vector2* pOut);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetCursorStartPos(Vector2* pOut);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* igGetDragDropPayload();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawData* igGetDrawData();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igGetDrawListSharedData();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* igGetFont();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetFontSize();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetFontTexUvWhitePixel(Vector2* pOut);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetForegroundDrawListNil();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetForegroundDrawListViewportPtr(ImGuiViewport* viewport);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetFrameCount();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetFrameHeight();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetFrameHeightWithSpacing();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetIDStr(byte* str_id);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetIDStrStr(byte* str_id_begin, byte* str_id_end);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetIDPtr(void* ptr_id);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiIO* igGetIO();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetItemRectMax(Vector2* pOut);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetItemRectMin(Vector2* pOut);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetItemRectSize(Vector2* pOut);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetKeyIndex(ImGuiKey imgui_key);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetKeyPressedAmount(int key_index, float repeat_delay, float rate);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* igGetMainViewport();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiMouseCursor igGetMouseCursor();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetMouseDragDelta(Vector2* pOut, ImGuiMouseButton button, float lock_threshold);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetMousePos(Vector2* pOut);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetMousePosOnOpeningCurrentPopup(Vector2* pOut);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPlatformIO* igGetPlatformIO();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollMaxX();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollMaxY();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollX();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollY();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStorage* igGetStateStorage();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyle* igGetStyle();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igGetStyleColorName(ImGuiCol idx);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* igGetStyleColorVec4(ImGuiCol idx);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetTextLineHeight();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetTextLineHeightWithSpacing();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern double igGetTime();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetTreeNodeToLabelSpacing();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igGetVersion();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowContentRegionMax(Vector2* pOut);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowContentRegionMin(Vector2* pOut);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetWindowContentRegionWidth();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetWindowDockID();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetWindowDpiScale();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetWindowDrawList();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetWindowHeight();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowPos(Vector2* pOut);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowSize(Vector2* pOut);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* igGetWindowViewport();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetWindowWidth();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImage(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 tint_col, Vector4 border_col);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImageButton(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, int frame_padding, Vector4 bg_col, Vector4 tint_col);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igIndent(float indent_w);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputDouble(byte* label, double* v, double step, double step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat(byte* label, float* v, float step, float step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat2(byte* label, Vector2* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat3(byte* label, Vector3* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat4(byte* label, Vector4* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt(byte* label, int* v, int step, int step_fast, ImGuiInputTextFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt2(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt3(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt4(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputText(byte* label, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputTextMultiline(byte* label, byte* buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputTextWithHint(byte* label, byte* hint, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInvisibleButton(byte* str_id, Vector2 size, ImGuiButtonFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyItemActive();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyItemFocused();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyItemHovered();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyMouseDown();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemActivated();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemActive();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemClicked(ImGuiMouseButton mouse_button);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemDeactivated();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemDeactivatedAfterEdit();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemEdited();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemFocused();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemHovered(ImGuiHoveredFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemToggledOpen();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemVisible();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyDown(int user_key_index);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyPressed(int user_key_index, byte repeat);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyReleased(int user_key_index);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseClicked(ImGuiMouseButton button, byte repeat);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDoubleClicked(ImGuiMouseButton button);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDown(ImGuiMouseButton button);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDragging(ImGuiMouseButton button, float lock_threshold);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseHoveringRect(Vector2 r_min, Vector2 r_max, byte clip);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMousePosValid(Vector2* mouse_pos);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseReleased(ImGuiMouseButton button);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsPopupOpenStr(byte* str_id, ImGuiPopupFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsRectVisibleNil(Vector2 size);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsRectVisibleVec2(Vector2 rect_min, Vector2 rect_max);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowAppearing();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowCollapsed();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowDocked();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowFocused(ImGuiFocusedFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowHovered(ImGuiHoveredFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLabelText(byte* label, byte* fmt);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igListBoxStr_arr(byte* label, int* current_item, byte** items, int items_count, int height_in_items);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLoadIniSettingsFromDisk(byte* ini_filename);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLoadIniSettingsFromMemory(byte* ini_data, uint ini_size);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogButtons();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogFinish();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogText(byte* fmt);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToClipboard(int auto_open_depth);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToFile(int auto_open_depth, byte* filename);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToTTY(int auto_open_depth);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* igMemAlloc(uint size);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMemFree(void* ptr);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igMenuItemBool(byte* label, byte* shortcut, byte selected, byte enabled);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igMenuItemBoolPtr(byte* label, byte* shortcut, byte* p_selected, byte enabled);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNewFrame();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNewLine();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNextColumn();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igOpenPopup(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igOpenPopupOnItemClick(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPlotHistogramFloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPlotLinesFloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopAllowKeyboardFocus();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopButtonRepeat();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopClipRect();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopFont();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopID();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopItemWidth();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopStyleColor(int count);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopStyleVar(int count);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopTextWrapPos();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igProgressBar(float fraction, Vector2 size_arg, byte* overlay);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushAllowKeyboardFocus(byte allow_keyboard_focus);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushButtonRepeat(byte repeat);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushFont(ImFont* font);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushIDStr(byte* str_id);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushIDStrStr(byte* str_id_begin, byte* str_id_end);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushIDPtr(void* ptr_id);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushIDInt(int int_id);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushItemWidth(float item_width);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleColorU32(ImGuiCol idx, uint col);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleColorVec4(ImGuiCol idx, Vector4 col);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleVarFloat(ImGuiStyleVar idx, float val);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleVarVec2(ImGuiStyleVar idx, Vector2 val);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushTextWrapPos(float wrap_local_pos_x);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igRadioButtonBool(byte* label, byte active);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igRadioButtonIntPtr(byte* label, int* v, int v_button);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRender();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderPlatformWindowsDefault(void* platform_render_arg, void* renderer_render_arg);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igResetMouseDragDelta(ImGuiMouseButton button);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSameLine(float offset_from_start_x, float spacing);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSaveIniSettingsToDisk(byte* ini_filename);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igSaveIniSettingsToMemory(uint* out_ini_size);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSelectableBool(byte* label, byte selected, ImGuiSelectableFlags flags, Vector2 size);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSelectableBoolPtr(byte* label, byte* p_selected, ImGuiSelectableFlags flags, Vector2 size);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSeparator();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetAllocatorFunctions(IntPtr alloc_func, IntPtr free_func, void* user_data);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetClipboardText(byte* text);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetColorEditOptions(ImGuiColorEditFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetColumnOffset(int column_index, float offset_x);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetColumnWidth(int column_index, float width);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCurrentContext(IntPtr ctx);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorPos(Vector2 local_pos);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorPosX(float local_x);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorPosY(float local_y);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorScreenPos(Vector2 pos);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSetDragDropPayload(byte* type, void* data, uint sz, ImGuiCond cond);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetItemAllowOverlap();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetItemDefaultFocus();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetKeyboardFocusHere(int offset);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetMouseCursor(ImGuiMouseCursor cursor_type);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextItemOpen(byte is_open, ImGuiCond cond);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextItemWidth(float item_width);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowBgAlpha(float alpha);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowClass(ImGuiWindowClass* window_class);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowCollapsed(byte collapsed, ImGuiCond cond);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowContentSize(Vector2 size);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowDockID(uint dock_id, ImGuiCond cond);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowFocus();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowSize(Vector2 size, ImGuiCond cond);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback, void* custom_callback_data);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowViewport(uint viewport_id);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosXFloat(float local_x, float center_x_ratio);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosYFloat(float local_y, float center_y_ratio);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollHereX(float center_x_ratio);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollHereY(float center_y_ratio);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollXFloat(float scroll_x);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollYFloat(float scroll_y);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetStateStorage(ImGuiStorage* storage);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetTabItemClosed(byte* tab_or_docked_window_label);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetTooltip(byte* fmt);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowCollapsedBool(byte collapsed, ImGuiCond cond);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowCollapsedStr(byte* name, byte collapsed, ImGuiCond cond);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowFocusNil();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowFocusStr(byte* name);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowFontScale(float scale);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowPosVec2(Vector2 pos, ImGuiCond cond);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowPosStr(byte* name, Vector2 pos, ImGuiCond cond);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowSizeVec2(Vector2 size, ImGuiCond cond);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowSizeStr(byte* name, Vector2 size, ImGuiCond cond);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowAboutWindow(byte* p_open);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowDemoWindow(byte* p_open);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowFontSelector(byte* label);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowMetricsWindow(byte* p_open);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowStyleEditor(ImGuiStyle* @ref);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igShowStyleSelector(byte* label);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowUserGuide();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderAngle(byte* label, float* v_rad, float v_degrees_min, float v_degrees_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat(byte* label, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat2(byte* label, Vector2* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat3(byte* label, Vector3* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat4(byte* label, Vector4* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt2(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt3(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt4(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSmallButton(byte* label);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSpacing();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStyleColorsClassic(ImGuiStyle* dst);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStyleColorsDark(ImGuiStyle* dst);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStyleColorsLight(ImGuiStyle* dst);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTabItemButton(byte* label, ImGuiTabItemFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern int igTableGetColumnCount();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableColumnFlags igTableGetColumnFlags(int column_n);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern int igTableGetColumnIndex();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igTableGetColumnNameInt(int column_n);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern int igTableGetRowIndex();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSortSpecs* igTableGetSortSpecs();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableHeader(byte* label);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableHeadersRow();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTableNextColumn();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableNextRow(ImGuiTableRowFlags row_flags, float min_row_height);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetBgColor(ImGuiTableBgTarget target, uint color, int column_n);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTableSetColumnIndex(int column_n);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetupColumn(byte* label, ImGuiTableColumnFlags flags, float init_width_or_weight, uint user_id);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetupScrollFreeze(int cols, int rows);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igText(byte* fmt);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextColored(Vector4 col, byte* fmt);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextDisabled(byte* fmt);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextUnformatted(byte* text, byte* text_end);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextWrapped(byte* fmt);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeStr(byte* label);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeStrStr(byte* str_id, byte* fmt);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodePtr(void* ptr_id, byte* fmt);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeExStr(byte* label, ImGuiTreeNodeFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeExStrStr(byte* str_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeExPtr(void* ptr_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePop();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePushStr(byte* str_id);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePushPtr(void* ptr_id);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUnindent(float indent_w);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdatePlatformWindows();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValueBool(byte* prefix, byte b);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValueInt(byte* prefix, int v);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValueUint(byte* prefix, uint v);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValueFloat(byte* prefix, float v, byte* float_format);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igVSliderFloat(byte* label, Vector2 size, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igVSliderInt(byte* label, Vector2 size, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igVSliderScalar(byte* label, Vector2 size, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_destroy(ImColor* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_HSV(ImColor* pOut, float h, float s, float v, float a);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColorNil();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColorInt(int r, int g, int b, int a);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColorU32(uint rgba);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColorFloat(float r, float g, float b, float a);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColorVec4(Vector4 col);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_SetHSV(ImColor* self, float h, float s, float v, float a);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawCmd_destroy(ImDrawCmd* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawCmd* ImDrawCmd_ImDrawCmd();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_Clear(ImDrawData* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_DeIndexAllBuffers(ImDrawData* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_destroy(ImDrawData* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawData* ImDrawData_ImDrawData();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_ScaleClipRects(ImDrawData* self, Vector2 fb_scale);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImDrawList__CalcCircleAutoSegmentCount(ImDrawList* self, float radius);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__ClearFreeMemory(ImDrawList* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__OnChangedClipRect(ImDrawList* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__OnChangedTextureID(ImDrawList* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__OnChangedVtxOffset(ImDrawList* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__PathArcToFastEx(ImDrawList* self, Vector2 center, float radius, int a_min_sample, int a_max_sample, int a_step);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__PathArcToN(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__PopUnusedDrawCmd(ImDrawList* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__ResetForNewFrame(ImDrawList* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddBezierCubic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int num_segments);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddBezierQuadratic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness, int num_segments);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCallback(ImDrawList* self, IntPtr callback, void* callback_data);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCircle(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCircleFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddConvexPolyFilled(ImDrawList* self, Vector2* points, int num_points, uint col);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddDrawCmd(ImDrawList* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImage(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImageQuad(ImDrawList* self, IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImageRounded(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding, ImDrawFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddLine(ImDrawList* self, Vector2 p1, Vector2 p2, uint col, float thickness);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddNgon(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddNgonFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddPolyline(ImDrawList* self, Vector2* points, int num_points, uint col, ImDrawFlags flags, float thickness);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddQuad(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddQuadFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRect(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags, float thickness);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRectFilled(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRectFilledMultiColor(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTextVec2(ImDrawList* self, Vector2 pos, uint col, byte* text_begin, byte* text_end);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTextFontPtr(ImDrawList* self, ImFont* font, float font_size, Vector2 pos, uint col, byte* text_begin, byte* text_end, float wrap_width, Vector4* cpu_fine_clip_rect);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTriangle(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTriangleFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsMerge(ImDrawList* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsSetCurrent(ImDrawList* self, int n);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsSplit(ImDrawList* self, int count);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImDrawList_CloneOutput(ImDrawList* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_destroy(ImDrawList* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_GetClipRectMax(Vector2* pOut, ImDrawList* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_GetClipRectMin(Vector2* pOut, ImDrawList* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImDrawList_ImDrawList(IntPtr shared_data);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathArcTo(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathArcToFast(ImDrawList* self, Vector2 center, float radius, int a_min_of_12, int a_max_of_12);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathBezierCubicCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, Vector2 p4, int num_segments);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathBezierQuadraticCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, int num_segments);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathClear(ImDrawList* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathFillConvex(ImDrawList* self, uint col);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathLineTo(ImDrawList* self, Vector2 pos);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathLineToMergeDuplicate(ImDrawList* self, Vector2 pos);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathRect(ImDrawList* self, Vector2 rect_min, Vector2 rect_max, float rounding, ImDrawFlags flags);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathStroke(ImDrawList* self, uint col, ImDrawFlags flags, float thickness);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PopClipRect(ImDrawList* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PopTextureID(ImDrawList* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimQuadUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimRect(ImDrawList* self, Vector2 a, Vector2 b, uint col);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimRectUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimReserve(ImDrawList* self, int idx_count, int vtx_count);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimUnreserve(ImDrawList* self, int idx_count, int vtx_count);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimWriteIdx(ImDrawList* self, ushort idx);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimWriteVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushClipRect(ImDrawList* self, Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushClipRectFullScreen(ImDrawList* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushTextureID(ImDrawList* self, IntPtr texture_id);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Clear(ImDrawListSplitter* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_ClearFreeMemory(ImDrawListSplitter* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_destroy(ImDrawListSplitter* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawListSplitter* ImDrawListSplitter_ImDrawListSplitter();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Merge(ImDrawListSplitter* self, ImDrawList* draw_list);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_SetCurrentChannel(ImDrawListSplitter* self, ImDrawList* draw_list, int channel_idx);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Split(ImDrawListSplitter* self, ImDrawList* draw_list, int count);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_AddGlyph(ImFont* self, ImFontConfig* src_cfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_AddRemapChar(ImFont* self, ushort dst, ushort src, byte overwrite_dst);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_BuildLookupTable(ImFont* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_CalcTextSizeA(Vector2* pOut, ImFont* self, float size, float max_width, float wrap_width, byte* text_begin, byte* text_end, byte** remaining);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImFont_CalcWordWrapPositionA(ImFont* self, float scale, byte* text, byte* text_end, float wrap_width);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_ClearOutputData(ImFont* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_destroy(ImFont* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyph* ImFont_FindGlyph(ImFont* self, ushort c);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyph* ImFont_FindGlyphNoFallback(ImFont* self, ushort c);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImFont_GetCharAdvance(ImFont* self, ushort c);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImFont_GetDebugName(ImFont* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_GrowIndex(ImFont* self, int new_size);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFont_ImFont();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFont_IsGlyphRangeUnused(ImFont* self, uint c_begin, uint c_last);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFont_IsLoaded(ImFont* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_RenderChar(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, ushort c);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_RenderText(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, byte* text_begin, byte* text_end, float wrap_width, byte cpu_fine_clip);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_SetFallbackChar(ImFont* self, ushort c);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_SetGlyphVisible(ImFont* self, ushort c, byte visible);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImFontAtlas_AddCustomRectFontGlyph(ImFontAtlas* self, ImFont* font, ushort id, int width, int height, float advance_x, Vector2 offset);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImFontAtlas_AddCustomRectRegular(ImFontAtlas* self, int width, int height);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFont(ImFontAtlas* self, ImFontConfig* font_cfg);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontDefault(ImFontAtlas* self, ImFontConfig* font_cfg);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* self, byte* filename, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* self, byte* compressed_font_data_base85, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* self, void* compressed_font_data, int compressed_font_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* self, void* font_data, int font_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlas_Build(ImFontAtlas* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_CalcCustomRectUV(ImFontAtlas* self, ImFontAtlasCustomRect* rect, Vector2* out_uv_min, Vector2* out_uv_max);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_Clear(ImFontAtlas* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearFonts(ImFontAtlas* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearInputData(ImFontAtlas* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearTexData(ImFontAtlas* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_destroy(ImFontAtlas* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlasCustomRect* ImFontAtlas_GetCustomRectByIndex(ImFontAtlas* self, int index);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesChineseFull(ImFontAtlas* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesCyrillic(ImFontAtlas* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesDefault(ImFontAtlas* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesJapanese(ImFontAtlas* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesKorean(ImFontAtlas* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesThai(ImFontAtlas* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesVietnamese(ImFontAtlas* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlas_GetMouseCursorTexData(ImFontAtlas* self, ImGuiMouseCursor cursor, Vector2* out_offset, Vector2* out_size, Vector2* out_uv_border, Vector2* out_uv_fill);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, IntPtr* out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, IntPtr* out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlas* ImFontAtlas_ImFontAtlas();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlas_IsBuilt(ImFontAtlas* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_SetTexID(ImFontAtlas* self, IntPtr id);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlasCustomRect_destroy(ImFontAtlasCustomRect* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlasCustomRect* ImFontAtlasCustomRect_ImFontAtlasCustomRect();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlasCustomRect_IsPacked(ImFontAtlasCustomRect* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontConfig_destroy(ImFontConfig* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontConfig* ImFontConfig_ImFontConfig();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddChar(ImFontGlyphRangesBuilder* self, ushort c);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddRanges(ImFontGlyphRangesBuilder* self, ushort* ranges);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddText(ImFontGlyphRangesBuilder* self, byte* text, byte* text_end);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_BuildRanges(ImFontGlyphRangesBuilder* self, ImVector* out_ranges);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_Clear(ImFontGlyphRangesBuilder* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_destroy(ImFontGlyphRangesBuilder* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontGlyphRangesBuilder_GetBit(ImFontGlyphRangesBuilder* self, uint n);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyphRangesBuilder* ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_SetBit(ImFontGlyphRangesBuilder* self, uint n);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_ClearSelection(ImGuiInputTextCallbackData* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_DeleteChars(ImGuiInputTextCallbackData* self, int pos, int bytes_count);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_destroy(ImGuiInputTextCallbackData* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiInputTextCallbackData_HasSelection(ImGuiInputTextCallbackData* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiInputTextCallbackData* ImGuiInputTextCallbackData_ImGuiInputTextCallbackData();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_InsertChars(ImGuiInputTextCallbackData* self, int pos, byte* text, byte* text_end);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_SelectAll(ImGuiInputTextCallbackData* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddInputCharacter(ImGuiIO* self, uint c);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddInputCharactersUTF8(ImGuiIO* self, byte* str);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddInputCharacterUTF16(ImGuiIO* self, ushort c);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_ClearInputCharacters(ImGuiIO* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_destroy(ImGuiIO* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiIO* ImGuiIO_ImGuiIO();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_Begin(ImGuiListClipper* self, int items_count, float items_height);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_destroy(ImGuiListClipper* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_End(ImGuiListClipper* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiListClipper* ImGuiListClipper_ImGuiListClipper();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiListClipper_Step(ImGuiListClipper* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiOnceUponAFrame_destroy(ImGuiOnceUponAFrame* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiOnceUponAFrame* ImGuiOnceUponAFrame_ImGuiOnceUponAFrame();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPayload_Clear(ImGuiPayload* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPayload_destroy(ImGuiPayload* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* ImGuiPayload_ImGuiPayload();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsDataType(ImGuiPayload* self, byte* type);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsDelivery(ImGuiPayload* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsPreview(ImGuiPayload* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPlatformIO_destroy(ImGuiPlatformIO* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPlatformIO* ImGuiPlatformIO_ImGuiPlatformIO();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPlatformMonitor_destroy(ImGuiPlatformMonitor* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPlatformMonitor* ImGuiPlatformMonitor_ImGuiPlatformMonitor();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_BuildSortByKey(ImGuiStorage* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_Clear(ImGuiStorage* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiStorage_GetBool(ImGuiStorage* self, uint key, byte default_val);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiStorage_GetBoolRef(ImGuiStorage* self, uint key, byte default_val);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiStorage_GetFloat(ImGuiStorage* self, uint key, float default_val);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern float* ImGuiStorage_GetFloatRef(ImGuiStorage* self, uint key, float default_val);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiStorage_GetInt(ImGuiStorage* self, uint key, int default_val);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern int* ImGuiStorage_GetIntRef(ImGuiStorage* self, uint key, int default_val);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* ImGuiStorage_GetVoidPtr(ImGuiStorage* self, uint key);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void** ImGuiStorage_GetVoidPtrRef(ImGuiStorage* self, uint key, void* default_val);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetAllInt(ImGuiStorage* self, int val);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetBool(ImGuiStorage* self, uint key, byte val);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetFloat(ImGuiStorage* self, uint key, float val);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetInt(ImGuiStorage* self, uint key, int val);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetVoidPtr(ImGuiStorage* self, uint key, void* val);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStoragePair_destroy(ImGuiStoragePair* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePairInt(uint _key, int _val_i);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePairFloat(uint _key, float _val_f);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePairPtr(uint _key, void* _val_p);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStyle_destroy(ImGuiStyle* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyle* ImGuiStyle_ImGuiStyle();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStyle_ScaleAllSizes(ImGuiStyle* self, float scale_factor);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableColumnSortSpecs_destroy(ImGuiTableColumnSortSpecs* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableColumnSortSpecs* ImGuiTableColumnSortSpecs_ImGuiTableColumnSortSpecs();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableSortSpecs_destroy(ImGuiTableSortSpecs* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSortSpecs* ImGuiTableSortSpecs_ImGuiTableSortSpecs();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_append(ImGuiTextBuffer* self, byte* str, byte* str_end);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_appendf(ImGuiTextBuffer* self, byte* fmt);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_begin(ImGuiTextBuffer* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_c_str(ImGuiTextBuffer* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_clear(ImGuiTextBuffer* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_destroy(ImGuiTextBuffer* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextBuffer_empty(ImGuiTextBuffer* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_end(ImGuiTextBuffer* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextBuffer* ImGuiTextBuffer_ImGuiTextBuffer();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_reserve(ImGuiTextBuffer* self, int capacity);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiTextBuffer_size(ImGuiTextBuffer* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_Build(ImGuiTextFilter* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_Clear(ImGuiTextFilter* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_destroy(ImGuiTextFilter* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_Draw(ImGuiTextFilter* self, byte* label, float width);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextFilter* ImGuiTextFilter_ImGuiTextFilter(byte* default_filter);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_IsActive(ImGuiTextFilter* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_PassFilter(ImGuiTextFilter* self, byte* text, byte* text_end);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextRange_destroy(ImGuiTextRange* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextRange_empty(ImGuiTextRange* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextRange* ImGuiTextRange_ImGuiTextRangeNil();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextRange* ImGuiTextRange_ImGuiTextRangeStr(byte* _b, byte* _e);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextRange_split(ImGuiTextRange* self, byte separator, ImVector* @out);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewport_destroy(ImGuiViewport* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewport_GetCenter(Vector2* pOut, ImGuiViewport* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewport_GetWorkCenter(Vector2* pOut, ImGuiViewport* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* ImGuiViewport_ImGuiViewport();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindowClass_destroy(ImGuiWindowClass* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowClass* ImGuiWindowClass_ImGuiWindowClass();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec2_destroy(Vector2* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2* ImVec2_ImVec2Nil();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2* ImVec2_ImVec2Float(float _x, float _y);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec4_destroy(Vector4* self);
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* ImVec4_ImVec4Nil();
        [DllImport(ImportConfig.DLL_PATH, CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* ImVec4_ImVec4Float(float _x, float _y, float _z, float _w);
    }
}