// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("56A868A6-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IFileSourceFilter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFileSourceFilter : IFileSourceFilter.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileSourceFilter*, Guid*, void**, int>)(lpVtbl[0]))((IFileSourceFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFileSourceFilter*, uint>)(lpVtbl[1]))((IFileSourceFilter*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileSourceFilter*, uint>)(lpVtbl[2]))((IFileSourceFilter*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Load([NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
    {
        return ((delegate* unmanaged<IFileSourceFilter*, ushort*, AM_MEDIA_TYPE*, int>)(lpVtbl[3]))((IFileSourceFilter*)Unsafe.AsPointer(ref this), pszFileName, pmt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCurFile([NativeTypeName("LPOLESTR *")] ushort** ppszFileName, AM_MEDIA_TYPE* pmt)
    {
        return ((delegate* unmanaged<IFileSourceFilter*, ushort**, AM_MEDIA_TYPE*, int>)(lpVtbl[4]))((IFileSourceFilter*)Unsafe.AsPointer(ref this), ppszFileName, pmt);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Load([NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt);

        [VtblIndex(4)]
        HRESULT GetCurFile([NativeTypeName("LPOLESTR *")] ushort** ppszFileName, AM_MEDIA_TYPE* pmt);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IFileSourceFilter*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IFileSourceFilter*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IFileSourceFilter*, uint> Release;

        [NativeTypeName("HRESULT (LPCOLESTR, const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFileSourceFilter*, ushort*, AM_MEDIA_TYPE*, int> Load;

        [NativeTypeName("HRESULT (LPOLESTR *, AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFileSourceFilter*, ushort**, AM_MEDIA_TYPE*, int> GetCurFile;
    }
}
