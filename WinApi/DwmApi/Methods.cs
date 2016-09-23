﻿using System;
using System.Runtime.InteropServices;
using System.Security;
using WinApi.Core;
using WinApi.UxTheme;

namespace WinApi.DwmApi
{
    public static class DwmApiMethods
    {
        public const string LibraryName = "dwmapi";

        [DllImport(LibraryName)]
        public static extern HResult DwmSetWindowAttribute(IntPtr hwnd, DwmWindowAttributeType attr,
            [In] ref int attrValue,
            int attrSize);

        [DllImport(LibraryName)]
        public static extern HResult DwmIsCompositionEnabled(out bool pfEnabled);

        [DllImport(LibraryName)]
        public static extern HResult DwmExtendFrameIntoClientArea(IntPtr hwnd, [In] ref Margin margin);

        [DllImport(LibraryName)]
        public static extern bool DwmDefWindowProc(IntPtr hwnd, uint msg, IntPtr wParam, IntPtr lParam,
            out IntPtr lResult);
    }
}