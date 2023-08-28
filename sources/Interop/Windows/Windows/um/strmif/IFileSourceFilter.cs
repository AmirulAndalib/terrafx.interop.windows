// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IFileSourceFilter.xml' path='doc/member[@name="IFileSourceFilter"]/*' />
[Guid("56A868A6-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IFileSourceFilter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFileSourceFilter : IFileSourceFilter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileSourceFilter));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSourceFilter*, Guid*, void**, int>)(lpVtbl[0]))((IFileSourceFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSourceFilter*, uint>)(lpVtbl[1]))((IFileSourceFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSourceFilter*, uint>)(lpVtbl[2]))((IFileSourceFilter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFileSourceFilter.xml' path='doc/member[@name="IFileSourceFilter.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Load([NativeTypeName("LPCOLESTR")] char* pszFileName, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSourceFilter*, char*, AM_MEDIA_TYPE*, int>)(lpVtbl[3]))((IFileSourceFilter*)Unsafe.AsPointer(ref this), pszFileName, pmt);
    }

    /// <include file='IFileSourceFilter.xml' path='doc/member[@name="IFileSourceFilter.GetCurFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCurFile([NativeTypeName("LPOLESTR *")] char** ppszFileName, AM_MEDIA_TYPE* pmt)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSourceFilter*, char**, AM_MEDIA_TYPE*, int>)(lpVtbl[4]))((IFileSourceFilter*)Unsafe.AsPointer(ref this), ppszFileName, pmt);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Load([NativeTypeName("LPCOLESTR")] char* pszFileName, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt);

        [VtblIndex(4)]
        HRESULT GetCurFile([NativeTypeName("LPOLESTR *")] char** ppszFileName, AM_MEDIA_TYPE* pmt);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (LPCOLESTR, const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, AM_MEDIA_TYPE*, int> Load;

        [NativeTypeName("HRESULT (LPOLESTR *, AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, AM_MEDIA_TYPE*, int> GetCurFile;
    }
}
