// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct WNDCLASSA
    {
        public uint style;

        [NativeTypeName("WNDPROC")]
        public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, LRESULT> lpfnWndProc;

        public int cbClsExtra;

        public int cbWndExtra;

        public HINSTANCE hInstance;

        public HICON hIcon;

        public HCURSOR hCursor;

        public HBRUSH hbrBackground;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszMenuName;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszClassName;
    }
}