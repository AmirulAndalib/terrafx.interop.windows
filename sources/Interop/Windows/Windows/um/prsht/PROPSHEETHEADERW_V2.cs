// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='PROPSHEETHEADERW_V2.xml' path='doc/member[@name="PROPSHEETHEADERW_V2"]/*' />
public unsafe partial struct PROPSHEETHEADERW_V2
{
    /// <include file='PROPSHEETHEADERW_V2.xml' path='doc/member[@name="PROPSHEETHEADERW_V2.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='PROPSHEETHEADERW_V2.xml' path='doc/member[@name="PROPSHEETHEADERW_V2.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='PROPSHEETHEADERW_V2.xml' path='doc/member[@name="PROPSHEETHEADERW_V2.hwndParent"]/*' />
    public HWND hwndParent;

    /// <include file='PROPSHEETHEADERW_V2.xml' path='doc/member[@name="PROPSHEETHEADERW_V2.hInstance"]/*' />
    public HINSTANCE hInstance;

    /// <include file='PROPSHEETHEADERW_V2.xml' path='doc/member[@name="PROPSHEETHEADERW_V2.Anonymous1"]/*' />
    [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/include/10.0.22621.0/um/prsht.h:526:5)")]
    public _Anonymous1_e__Union Anonymous1;

    /// <include file='PROPSHEETHEADERW_V2.xml' path='doc/member[@name="PROPSHEETHEADERW_V2.pszCaption"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pszCaption;

    /// <include file='PROPSHEETHEADERW_V2.xml' path='doc/member[@name="PROPSHEETHEADERW_V2.nPages"]/*' />
    public uint nPages;

    /// <include file='PROPSHEETHEADERW_V2.xml' path='doc/member[@name="PROPSHEETHEADERW_V2.Anonymous2"]/*' />
    [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/include/10.0.22621.0/um/prsht.h:526:5)")]
    public _Anonymous2_e__Union Anonymous2;

    /// <include file='PROPSHEETHEADERW_V2.xml' path='doc/member[@name="PROPSHEETHEADERW_V2.Anonymous3"]/*' />
    [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/include/10.0.22621.0/um/prsht.h:526:5)")]
    public _Anonymous3_e__Union Anonymous3;

    /// <include file='PROPSHEETHEADERW_V2.xml' path='doc/member[@name="PROPSHEETHEADERW_V2.pfnCallback"]/*' />
    [NativeTypeName("PFNPROPSHEETCALLBACK")]
    public delegate* unmanaged<HWND, uint, LPARAM, int> pfnCallback;

    /// <include file='PROPSHEETHEADERW_V2.xml' path='doc/member[@name="PROPSHEETHEADERW_V2.Anonymous4"]/*' />
    [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/include/10.0.22621.0/um/prsht.h:527:5)")]
    public _Anonymous4_e__Union Anonymous4;

    /// <include file='PROPSHEETHEADERW_V2.xml' path='doc/member[@name="PROPSHEETHEADERW_V2.hplWatermark"]/*' />
    public HPALETTE hplWatermark;

    /// <include file='PROPSHEETHEADERW_V2.xml' path='doc/member[@name="PROPSHEETHEADERW_V2.Anonymous5"]/*' />
    [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/include/10.0.22621.0/um/prsht.h:533:5)")]
    public _Anonymous5_e__Union Anonymous5;

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.hIcon"]/*' />
    [UnscopedRef]
    public ref HICON hIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.hIcon;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pszIcon"]/*' />
    [UnscopedRef]
    public ref ushort* pszIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.pszIcon;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.nStartPage"]/*' />
    [UnscopedRef]
    public ref uint nStartPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.nStartPage;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pStartPage"]/*' />
    [UnscopedRef]
    public ref ushort* pStartPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.pStartPage;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.ppsp"]/*' />
    [UnscopedRef]
    public ref PROPSHEETPAGEW* ppsp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.ppsp;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.phpage"]/*' />
    [UnscopedRef]
    public ref HPROPSHEETPAGE* phpage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.phpage;
        }
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.hbmWatermark"]/*' />
    [UnscopedRef]
    public ref HBITMAP hbmWatermark
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous4.hbmWatermark;
        }
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.pszbmWatermark"]/*' />
    [UnscopedRef]
    public ref ushort* pszbmWatermark
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous4.pszbmWatermark;
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.hbmHeader"]/*' />
    [UnscopedRef]
    public ref HBITMAP hbmHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous5.hbmHeader;
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.pszbmHeader"]/*' />
    [UnscopedRef]
    public ref ushort* pszbmHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous5.pszbmHeader;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.hIcon"]/*' />
        [FieldOffset(0)]
        public HICON hIcon;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pszIcon"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* pszIcon;
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.nStartPage"]/*' />
        [FieldOffset(0)]
        public uint nStartPage;

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pStartPage"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* pStartPage;
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous3_e__Union
    {
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.ppsp"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCPROPSHEETPAGEW")]
        public PROPSHEETPAGEW* ppsp;

        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.phpage"]/*' />
        [FieldOffset(0)]
        public HPROPSHEETPAGE* phpage;
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous4_e__Union
    {
        /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.hbmWatermark"]/*' />
        [FieldOffset(0)]
        public HBITMAP hbmWatermark;

        /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.pszbmWatermark"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* pszbmWatermark;
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous5_e__Union
    {
        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.hbmHeader"]/*' />
        [FieldOffset(0)]
        public HBITMAP hbmHeader;

        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.pszbmHeader"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* pszbmHeader;
    }
}
