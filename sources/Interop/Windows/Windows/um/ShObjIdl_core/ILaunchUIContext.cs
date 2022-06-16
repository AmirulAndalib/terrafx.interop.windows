// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ILaunchUIContext.xml' path='doc/member[@name="ILaunchUIContext"]/*' />
[Guid("1791E8F6-21C7-4340-882A-A6A93E3FD73B")]
[NativeTypeName("struct ILaunchUIContext : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ILaunchUIContext : ILaunchUIContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILaunchUIContext));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ILaunchUIContext*, Guid*, void**, int>)(lpVtbl[0]))((ILaunchUIContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ILaunchUIContext*, uint>)(lpVtbl[1]))((ILaunchUIContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILaunchUIContext*, uint>)(lpVtbl[2]))((ILaunchUIContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ILaunchUIContext.xml' path='doc/member[@name="ILaunchUIContext.SetAssociatedWindow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetAssociatedWindow(HWND value)
    {
        return ((delegate* unmanaged<ILaunchUIContext*, HWND, int>)(lpVtbl[3]))((ILaunchUIContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILaunchUIContext.xml' path='doc/member[@name="ILaunchUIContext.SetTabGroupingPreference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetTabGroupingPreference([NativeTypeName("DWORD")] uint value)
    {
        return ((delegate* unmanaged<ILaunchUIContext*, uint, int>)(lpVtbl[4]))((ILaunchUIContext*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetAssociatedWindow(HWND value);

        [VtblIndex(4)]
        HRESULT SetTabGroupingPreference([NativeTypeName("DWORD")] uint value);
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

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> SetAssociatedWindow;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetTabGroupingPreference;
    }
}
