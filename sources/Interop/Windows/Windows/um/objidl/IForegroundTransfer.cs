// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IForegroundTransfer.xml' path='doc/member[@name="IForegroundTransfer"]/*' />
[Guid("00000145-0000-0000-C000-000000000046")]
[NativeTypeName("struct IForegroundTransfer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IForegroundTransfer : IForegroundTransfer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IForegroundTransfer);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IForegroundTransfer*, Guid*, void**, int>)(lpVtbl[0]))((IForegroundTransfer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IForegroundTransfer*, uint>)(lpVtbl[1]))((IForegroundTransfer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IForegroundTransfer*, uint>)(lpVtbl[2]))((IForegroundTransfer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IForegroundTransfer.xml' path='doc/member[@name="IForegroundTransfer.AllowForegroundTransfer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AllowForegroundTransfer(void* lpvReserved)
    {
        return ((delegate* unmanaged[MemberFunction]<IForegroundTransfer*, void*, int>)(lpVtbl[3]))((IForegroundTransfer*)Unsafe.AsPointer(ref this), lpvReserved);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AllowForegroundTransfer(void* lpvReserved);
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

        [NativeTypeName("HRESULT (void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, int> AllowForegroundTransfer;
    }
}
