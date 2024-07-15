// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IEnumTfContexts.xml' path='doc/member[@name="IEnumTfContexts"]/*' />
[Guid("8F1A7EA6-1654-4502-A86E-B2902344D507")]
[NativeTypeName("struct IEnumTfContexts : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumTfContexts : IEnumTfContexts.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumTfContexts));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumTfContexts*, Guid*, void**, int>)(lpVtbl[0]))((IEnumTfContexts*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumTfContexts*, uint>)(lpVtbl[1]))((IEnumTfContexts*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumTfContexts*, uint>)(lpVtbl[2]))((IEnumTfContexts*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumTfContexts.xml' path='doc/member[@name="IEnumTfContexts.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Clone(IEnumTfContexts** ppEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumTfContexts*, IEnumTfContexts**, int>)(lpVtbl[3]))((IEnumTfContexts*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IEnumTfContexts.xml' path='doc/member[@name="IEnumTfContexts.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfContext** rgContext, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumTfContexts*, uint, ITfContext**, uint*, int>)(lpVtbl[4]))((IEnumTfContexts*)Unsafe.AsPointer(ref this), ulCount, rgContext, pcFetched);
    }

    /// <include file='IEnumTfContexts.xml' path='doc/member[@name="IEnumTfContexts.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumTfContexts*, int>)(lpVtbl[5]))((IEnumTfContexts*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumTfContexts.xml' path='doc/member[@name="IEnumTfContexts.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumTfContexts*, uint, int>)(lpVtbl[6]))((IEnumTfContexts*)Unsafe.AsPointer(ref this), ulCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Clone(IEnumTfContexts** ppEnum);

        [VtblIndex(4)]
        HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfContext** rgContext, [NativeTypeName("ULONG *")] uint* pcFetched);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Skip([NativeTypeName("ULONG")] uint ulCount);
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

        [NativeTypeName("HRESULT (IEnumTfContexts **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEnumTfContexts**, int> Clone;

        [NativeTypeName("HRESULT (ULONG, ITfContext **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, ITfContext**, uint*, int> Next;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Skip;
    }
}
