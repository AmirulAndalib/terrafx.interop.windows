// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("00000125-0000-0000-C000-000000000046")]
[NativeTypeName("struct IAdviseSink2 : IAdviseSink")]
[NativeInheritance("IAdviseSink")]
public unsafe partial struct IAdviseSink2 : IAdviseSink2.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAdviseSink2*, Guid*, void**, int>)(lpVtbl[0]))((IAdviseSink2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAdviseSink2*, uint>)(lpVtbl[1]))((IAdviseSink2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAdviseSink2*, uint>)(lpVtbl[2]))((IAdviseSink2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void OnDataChange(FORMATETC* pFormatetc, STGMEDIUM* pStgmed)
    {
        ((delegate* unmanaged<IAdviseSink2*, FORMATETC*, STGMEDIUM*, void>)(lpVtbl[3]))((IAdviseSink2*)Unsafe.AsPointer(ref this), pFormatetc, pStgmed);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex)
    {
        ((delegate* unmanaged<IAdviseSink2*, uint, int, void>)(lpVtbl[4]))((IAdviseSink2*)Unsafe.AsPointer(ref this), dwAspect, lindex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void OnRename(IMoniker* pmk)
    {
        ((delegate* unmanaged<IAdviseSink2*, IMoniker*, void>)(lpVtbl[5]))((IAdviseSink2*)Unsafe.AsPointer(ref this), pmk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void OnSave()
    {
        ((delegate* unmanaged<IAdviseSink2*, void>)(lpVtbl[6]))((IAdviseSink2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void OnClose()
    {
        ((delegate* unmanaged<IAdviseSink2*, void>)(lpVtbl[7]))((IAdviseSink2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void OnLinkSrcChange(IMoniker* pmk)
    {
        ((delegate* unmanaged<IAdviseSink2*, IMoniker*, void>)(lpVtbl[8]))((IAdviseSink2*)Unsafe.AsPointer(ref this), pmk);
    }

    public interface Interface : IAdviseSink.Interface
    {
        [VtblIndex(8)]
        void OnLinkSrcChange(IMoniker* pmk);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAdviseSink2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAdviseSink2*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAdviseSink2*, uint> Release;

        [NativeTypeName("void (FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAdviseSink2*, FORMATETC*, STGMEDIUM*, void> OnDataChange;

        [NativeTypeName("void (DWORD, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<IAdviseSink2*, uint, int, void> OnViewChange;

        [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAdviseSink2*, IMoniker*, void> OnRename;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<IAdviseSink2*, void> OnSave;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<IAdviseSink2*, void> OnClose;

        [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAdviseSink2*, IMoniker*, void> OnLinkSrcChange;
    }
}
