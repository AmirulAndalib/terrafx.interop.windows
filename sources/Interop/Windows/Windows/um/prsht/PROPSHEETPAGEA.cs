// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='PROPSHEETPAGEA.xml' path='doc/member[@name="PROPSHEETPAGEA"]/*' />
public unsafe partial struct PROPSHEETPAGEA
{
    /// <include file='PROPSHEETPAGEA.xml' path='doc/member[@name="PROPSHEETPAGEA.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='PROPSHEETPAGEA.xml' path='doc/member[@name="PROPSHEETPAGEA.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='PROPSHEETPAGEA.xml' path='doc/member[@name="PROPSHEETPAGEA.hInstance"]/*' />
    public HINSTANCE hInstance;

    /// <include file='PROPSHEETPAGEA.xml' path='doc/member[@name="PROPSHEETPAGEA.Anonymous1"]/*' />
    [NativeTypeName("_PROPSHEETPAGEA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/prsht.h:225:5)")]
    public _Anonymous1_e__Union Anonymous1;

    /// <include file='PROPSHEETPAGEA.xml' path='doc/member[@name="PROPSHEETPAGEA.Anonymous2"]/*' />
    [NativeTypeName("_PROPSHEETPAGEA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/prsht.h:225:5)")]
    public _Anonymous2_e__Union Anonymous2;

    /// <include file='PROPSHEETPAGEA.xml' path='doc/member[@name="PROPSHEETPAGEA.pszTitle"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* pszTitle;

    /// <include file='PROPSHEETPAGEA.xml' path='doc/member[@name="PROPSHEETPAGEA.pfnDlgProc"]/*' />
    [NativeTypeName("DLGPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> pfnDlgProc;

    /// <include file='PROPSHEETPAGEA.xml' path='doc/member[@name="PROPSHEETPAGEA.lParam"]/*' />
    public LPARAM lParam;

    /// <include file='PROPSHEETPAGEA.xml' path='doc/member[@name="PROPSHEETPAGEA.pfnCallback"]/*' />
    [NativeTypeName("LPFNPSPCALLBACKA")]
    public delegate* unmanaged<HWND, uint, PROPSHEETPAGEA*, uint> pfnCallback;

    /// <include file='PROPSHEETPAGEA.xml' path='doc/member[@name="PROPSHEETPAGEA.pcRefParent"]/*' />
    public uint* pcRefParent;

    /// <include file='PROPSHEETPAGEA.xml' path='doc/member[@name="PROPSHEETPAGEA.pszHeaderTitle"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* pszHeaderTitle;

    /// <include file='PROPSHEETPAGEA.xml' path='doc/member[@name="PROPSHEETPAGEA.pszHeaderSubTitle"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* pszHeaderSubTitle;

    /// <include file='PROPSHEETPAGEA.xml' path='doc/member[@name="PROPSHEETPAGEA.hActCtx"]/*' />
    public HANDLE hActCtx;

    /// <include file='PROPSHEETPAGEA.xml' path='doc/member[@name="PROPSHEETPAGEA.Anonymous3"]/*' />
    [NativeTypeName("_PROPSHEETPAGEA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/prsht.h:232:5)")]
    public _Anonymous3_e__Union Anonymous3;

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pszTemplate"]/*' />
    public ref sbyte* pszTemplate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.pszTemplate;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pResource"]/*' />
    public ref DLGTEMPLATE* pResource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.pResource;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.hIcon"]/*' />
    public ref HICON hIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.hIcon;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pszIcon"]/*' />
    public ref sbyte* pszIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.pszIcon;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.hbmHeader"]/*' />
    public ref HBITMAP hbmHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous3.hbmHeader;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.pszbmHeader"]/*' />
    public ref sbyte* pszbmHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous3.pszbmHeader;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pszTemplate"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCSTR")]
        public sbyte* pszTemplate;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pResource"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("PROPSHEETPAGE_RESOURCE")]
        public DLGTEMPLATE* pResource;
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.hIcon"]/*' />
        [FieldOffset(0)]
        public HICON hIcon;

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pszIcon"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCSTR")]
        public sbyte* pszIcon;
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous3_e__Union
    {
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.hbmHeader"]/*' />
        [FieldOffset(0)]
        public HBITMAP hbmHeader;

        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.pszbmHeader"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCSTR")]
        public sbyte* pszbmHeader;
    }
}
