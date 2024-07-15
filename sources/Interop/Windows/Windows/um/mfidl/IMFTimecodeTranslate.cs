// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFTimecodeTranslate.xml' path='doc/member[@name="IMFTimecodeTranslate"]/*' />
[Guid("AB9D8661-F7E8-4EF4-9861-89F334F94E74")]
[NativeTypeName("struct IMFTimecodeTranslate : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFTimecodeTranslate : IMFTimecodeTranslate.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimecodeTranslate));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimecodeTranslate*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimecodeTranslate*, uint>)(lpVtbl[1]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimecodeTranslate*, uint>)(lpVtbl[2]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimecodeTranslate.xml' path='doc/member[@name="IMFTimecodeTranslate.BeginConvertTimecodeToHNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginConvertTimecodeToHNS([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pPropVarTimecode, IMFAsyncCallback* pCallback, IUnknown* punkState)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimecodeTranslate*, PROPVARIANT*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[3]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this), pPropVarTimecode, pCallback, punkState);
    }

    /// <include file='IMFTimecodeTranslate.xml' path='doc/member[@name="IMFTimecodeTranslate.EndConvertTimecodeToHNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndConvertTimecodeToHNS(IMFAsyncResult* pResult, [NativeTypeName("MFTIME *")] long* phnsTime)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimecodeTranslate*, IMFAsyncResult*, long*, int>)(lpVtbl[4]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this), pResult, phnsTime);
    }

    /// <include file='IMFTimecodeTranslate.xml' path='doc/member[@name="IMFTimecodeTranslate.BeginConvertHNSToTimecode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT BeginConvertHNSToTimecode([NativeTypeName("MFTIME")] long hnsTime, IMFAsyncCallback* pCallback, IUnknown* punkState)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimecodeTranslate*, long, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[5]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this), hnsTime, pCallback, punkState);
    }

    /// <include file='IMFTimecodeTranslate.xml' path='doc/member[@name="IMFTimecodeTranslate.EndConvertHNSToTimecode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EndConvertHNSToTimecode(IMFAsyncResult* pResult, PROPVARIANT* pPropVarTimecode)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimecodeTranslate*, IMFAsyncResult*, PROPVARIANT*, int>)(lpVtbl[6]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this), pResult, pPropVarTimecode);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BeginConvertTimecodeToHNS([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pPropVarTimecode, IMFAsyncCallback* pCallback, IUnknown* punkState);

        [VtblIndex(4)]
        HRESULT EndConvertTimecodeToHNS(IMFAsyncResult* pResult, [NativeTypeName("MFTIME *")] long* phnsTime);

        [VtblIndex(5)]
        HRESULT BeginConvertHNSToTimecode([NativeTypeName("MFTIME")] long hnsTime, IMFAsyncCallback* pCallback, IUnknown* punkState);

        [VtblIndex(6)]
        HRESULT EndConvertHNSToTimecode(IMFAsyncResult* pResult, PROPVARIANT* pPropVarTimecode);
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

        [NativeTypeName("HRESULT (const PROPVARIANT *, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PROPVARIANT*, IMFAsyncCallback*, IUnknown*, int> BeginConvertTimecodeToHNS;

        [NativeTypeName("HRESULT (IMFAsyncResult *, MFTIME *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMFAsyncResult*, long*, int> EndConvertTimecodeToHNS;

        [NativeTypeName("HRESULT (MFTIME, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, long, IMFAsyncCallback*, IUnknown*, int> BeginConvertHNSToTimecode;

        [NativeTypeName("HRESULT (IMFAsyncResult *, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMFAsyncResult*, PROPVARIANT*, int> EndConvertHNSToTimecode;
    }
}
