// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct PROPSHEETHEADERA_V1
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("HWND")]
        public IntPtr hwndParent;

        [NativeTypeName("HINSTANCE")]
        public IntPtr hInstance;

        [NativeTypeName("_PROPSHEETHEADERA_V1::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/prsht.h:473:5)")]
        public _Anonymous1_e__Union Anonymous1;

        public ref IntPtr hIcon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.hIcon, 1));
            }
        }

        public ref sbyte* pszIcon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union* pField = &Anonymous1)
                {
                    return ref pField->pszIcon;
                }
            }
        }

        [NativeTypeName("LPCSTR")]
        public sbyte* pszCaption;

        [NativeTypeName("UINT")]
        public uint nPages;

        [NativeTypeName("_PROPSHEETHEADERA_V1::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/prsht.h:473:5)")]
        public _Anonymous2_e__Union Anonymous2;

        public ref uint nStartPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.nStartPage, 1));
            }
        }

        public ref sbyte* pStartPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union* pField = &Anonymous2)
                {
                    return ref pField->pStartPage;
                }
            }
        }

        [NativeTypeName("_PROPSHEETHEADERA_V1::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/prsht.h:473:5)")]
        public _Anonymous3_e__Union Anonymous3;

        public ref PROPSHEETPAGEA* ppsp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous3_e__Union* pField = &Anonymous3)
                {
                    return ref pField->ppsp;
                }
            }
        }

        public ref IntPtr* phpage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous3_e__Union* pField = &Anonymous3)
                {
                    return ref pField->phpage;
                }
            }
        }

        [NativeTypeName("PFNPROPSHEETCALLBACK")]
        public delegate* unmanaged<IntPtr, uint, nint, int> pfnCallback;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HICON")]
            public IntPtr hIcon;

            [FieldOffset(0)]
            [NativeTypeName("LPCSTR")]
            public sbyte* pszIcon;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT")]
            public uint nStartPage;

            [FieldOffset(0)]
            [NativeTypeName("LPCSTR")]
            public sbyte* pStartPage;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous3_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("LPCPROPSHEETPAGEA")]
            public PROPSHEETPAGEA* ppsp;

            [FieldOffset(0)]
            [NativeTypeName("HPROPSHEETPAGE *")]
            public IntPtr* phpage;
        }
    }
}
