// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IExecuteCommandHost.xml' path='doc/member[@name="IExecuteCommandHost"]/*' />
[Guid("4B6832A2-5F04-4C9D-B89D-727A15D103E7")]
[NativeTypeName("struct IExecuteCommandHost : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IExecuteCommandHost : IExecuteCommandHost.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExecuteCommandHost));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IExecuteCommandHost*, Guid*, void**, int>)(lpVtbl[0]))((IExecuteCommandHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IExecuteCommandHost*, uint>)(lpVtbl[1]))((IExecuteCommandHost*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IExecuteCommandHost*, uint>)(lpVtbl[2]))((IExecuteCommandHost*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IExecuteCommandHost.xml' path='doc/member[@name="IExecuteCommandHost.GetUIMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetUIMode(EC_HOST_UI_MODE* pUIMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IExecuteCommandHost*, EC_HOST_UI_MODE*, int>)(lpVtbl[3]))((IExecuteCommandHost*)Unsafe.AsPointer(ref this), pUIMode);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetUIMode(EC_HOST_UI_MODE* pUIMode);
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

        [NativeTypeName("HRESULT (EC_HOST_UI_MODE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EC_HOST_UI_MODE*, int> GetUIMode;
    }
}
