// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ILaunchUIContextProvider.xml' path='doc/member[@name="ILaunchUIContextProvider"]/*' />
[Guid("0D12C4C8-A3D9-4E24-94C1-0E20C5A956C4")]
[NativeTypeName("struct ILaunchUIContextProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ILaunchUIContextProvider : ILaunchUIContextProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILaunchUIContextProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILaunchUIContextProvider*, Guid*, void**, int>)(lpVtbl[0]))((ILaunchUIContextProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILaunchUIContextProvider*, uint>)(lpVtbl[1]))((ILaunchUIContextProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILaunchUIContextProvider*, uint>)(lpVtbl[2]))((ILaunchUIContextProvider*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ILaunchUIContextProvider.xml' path='doc/member[@name="ILaunchUIContextProvider.UpdateContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT UpdateContext(ILaunchUIContext* context)
    {
        return ((delegate* unmanaged[MemberFunction]<ILaunchUIContextProvider*, ILaunchUIContext*, int>)(lpVtbl[3]))((ILaunchUIContextProvider*)Unsafe.AsPointer(ref this), context);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT UpdateContext(ILaunchUIContext* context);
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

        [NativeTypeName("HRESULT (ILaunchUIContext *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ILaunchUIContext*, int> UpdateContext;
    }
}
