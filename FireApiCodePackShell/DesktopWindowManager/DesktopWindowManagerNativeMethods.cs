﻿//Copyright (c) Microsoft Corporation.  All rights reserved.

/* Unmerged change from project 'Shell (net452)'
Before:
using System;
using System.Runtime.InteropServices;
After:
using FireApiCodePackShell.Shell;
using Microsoft.Runtime.Shell.Interop;
*/

/* Unmerged change from project 'Shell (net462)'
Before:
using System;
using System.Runtime.InteropServices;
After:
using FireApiCodePackShell.Shell;
using Microsoft.Runtime.Shell.Interop;
*/

/* Unmerged change from project 'Shell (net472)'
Before:
using System;
using System.Runtime.InteropServices;
After:
using FireApiCodePackShell.Shell;
using Microsoft.Runtime.Shell.Interop;
*/

using FireApiCodePackShell.Shell;
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace FireApiCodePackShell.Internal
{
    internal enum CompositionEnable
    {
        Disable = 0,
        Enable = 1
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct Margins
    {
        public int LeftWidth;      // width of left border that retains its size
        public int RightWidth;     // width of right border that retains its size
        public int TopHeight;      // height of top border that retains its size
        public int BottomHeight;   // height of bottom border that retains its size

        public Margins(bool fullWindow) => LeftWidth = RightWidth = TopHeight = BottomHeight = (fullWindow ? -1 : 0);
    };

    /// <summary>Internal class that contains interop declarations for functions that are not benign and are performance critical.</summary>
    [SuppressUnmanagedCodeSecurity]
    internal static class DesktopWindowManagerNativeMethods
    {
        [DllImport("DwmApi.dll")]
        internal static extern int DwmEnableComposition(
            CompositionEnable compositionAction);

        [DllImport("DwmApi.dll")]
        internal static extern int DwmExtendFrameIntoClientArea(
            IntPtr hwnd,
            ref Margins m);

        [DllImport("DwmApi.dll", PreserveSig = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool DwmIsCompositionEnabled();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetClientRect(IntPtr hwnd, [Out] out NativeRect rect);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetWindowRect(IntPtr hwnd, [Out] out NativeRect rect);
    }

    internal static class DWMMessages
    {
        internal const int WM_DWMCOMPOSITIONCHANGED = 0x031E;
        internal const int WM_DWMNCRENDERINGCHANGED = 0x031F;
    }
}