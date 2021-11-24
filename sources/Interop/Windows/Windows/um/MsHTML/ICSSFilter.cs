// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("3050F3EC-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ICSSFilter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICSSFilter : ICSSFilter.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICSSFilter*, Guid*, void**, int>)(lpVtbl[0]))((ICSSFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICSSFilter*, uint>)(lpVtbl[1]))((ICSSFilter*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICSSFilter*, uint>)(lpVtbl[2]))((ICSSFilter*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSite(ICSSFilterSite* pSink)
    {
        return ((delegate* unmanaged<ICSSFilter*, ICSSFilterSite*, int>)(lpVtbl[3]))((ICSSFilter*)Unsafe.AsPointer(ref this), pSink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnAmbientPropertyChange([NativeTypeName("LONG")] int dispid)
    {
        return ((delegate* unmanaged<ICSSFilter*, int, int>)(lpVtbl[4]))((ICSSFilter*)Unsafe.AsPointer(ref this), dispid);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetSite(ICSSFilterSite* pSink);

        [VtblIndex(4)]
        HRESULT OnAmbientPropertyChange([NativeTypeName("LONG")] int dispid);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ICSSFilter*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ICSSFilter*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ICSSFilter*, uint> Release;

        [NativeTypeName("HRESULT (ICSSFilterSite *) __attribute__((stdcall))")]
        public delegate* unmanaged<ICSSFilter*, ICSSFilterSite*, int> SetSite;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<ICSSFilter*, int, int> OnAmbientPropertyChange;
    }
}
