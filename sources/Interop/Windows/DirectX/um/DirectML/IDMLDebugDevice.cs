// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDMLDebugDevice.xml' path='doc/member[@name="IDMLDebugDevice"]/*' />
[Guid("7D6F3AC9-394A-4AC3-92A7-390CC57A8217")]
[NativeTypeName("struct IDMLDebugDevice : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDMLDebugDevice : IDMLDebugDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDMLDebugDevice));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDMLDebugDevice*, Guid*, void**, int>)(lpVtbl[0]))((IDMLDebugDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDMLDebugDevice*, uint>)(lpVtbl[1]))((IDMLDebugDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDMLDebugDevice*, uint>)(lpVtbl[2]))((IDMLDebugDevice*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDMLDebugDevice.xml' path='doc/member[@name="IDMLDebugDevice.SetMuteDebugOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetMuteDebugOutput(BOOL mute)
    {
        ((delegate* unmanaged<IDMLDebugDevice*, BOOL, void>)(lpVtbl[3]))((IDMLDebugDevice*)Unsafe.AsPointer(ref this), mute);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void SetMuteDebugOutput(BOOL mute);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("void (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetMuteDebugOutput;
    }
}
