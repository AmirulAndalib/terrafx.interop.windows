// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IEnumDiscMasterFormats.xml' path='doc/member[@name="IEnumDiscMasterFormats"]/*' />
[Guid("DDF445E1-54BA-11D3-9144-00104BA11C5E")]
[NativeTypeName("struct IEnumDiscMasterFormats : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumDiscMasterFormats : IEnumDiscMasterFormats.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumDiscMasterFormats));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumDiscMasterFormats*, Guid*, void**, int>)(lpVtbl[0]))((IEnumDiscMasterFormats*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumDiscMasterFormats*, uint>)(lpVtbl[1]))((IEnumDiscMasterFormats*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumDiscMasterFormats*, uint>)(lpVtbl[2]))((IEnumDiscMasterFormats*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumDiscMasterFormats.xml' path='doc/member[@name="IEnumDiscMasterFormats.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint cFormats, [NativeTypeName("LPIID")] Guid* lpiidFormatID, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumDiscMasterFormats*, uint, Guid*, uint*, int>)(lpVtbl[3]))((IEnumDiscMasterFormats*)Unsafe.AsPointer(ref this), cFormats, lpiidFormatID, pcFetched);
    }

    /// <include file='IEnumDiscMasterFormats.xml' path='doc/member[@name="IEnumDiscMasterFormats.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint cFormats)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumDiscMasterFormats*, uint, int>)(lpVtbl[4]))((IEnumDiscMasterFormats*)Unsafe.AsPointer(ref this), cFormats);
    }

    /// <include file='IEnumDiscMasterFormats.xml' path='doc/member[@name="IEnumDiscMasterFormats.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumDiscMasterFormats*, int>)(lpVtbl[5]))((IEnumDiscMasterFormats*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumDiscMasterFormats.xml' path='doc/member[@name="IEnumDiscMasterFormats.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumDiscMasterFormats** ppEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumDiscMasterFormats*, IEnumDiscMasterFormats**, int>)(lpVtbl[6]))((IEnumDiscMasterFormats*)Unsafe.AsPointer(ref this), ppEnum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint cFormats, [NativeTypeName("LPIID")] Guid* lpiidFormatID, [NativeTypeName("ULONG *")] uint* pcFetched);

        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint cFormats);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Clone(IEnumDiscMasterFormats** ppEnum);
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

        [NativeTypeName("HRESULT (ULONG, LPIID, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IEnumDiscMasterFormats **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEnumDiscMasterFormats**, int> Clone;
    }
}
