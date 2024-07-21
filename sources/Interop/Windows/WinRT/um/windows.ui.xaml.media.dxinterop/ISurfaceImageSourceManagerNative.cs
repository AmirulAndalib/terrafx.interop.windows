// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISurfaceImageSourceManagerNative.xml' path='doc/member[@name="ISurfaceImageSourceManagerNative"]/*' />
[Guid("4C8798B7-1D88-4A0F-B59B-B93F600DE8C8")]
[NativeTypeName("struct ISurfaceImageSourceManagerNative : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct ISurfaceImageSourceManagerNative : ISurfaceImageSourceManagerNative.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISurfaceImageSourceManagerNative));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISurfaceImageSourceManagerNative*, Guid*, void**, int>)(lpVtbl[0]))((ISurfaceImageSourceManagerNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISurfaceImageSourceManagerNative*, uint>)(lpVtbl[1]))((ISurfaceImageSourceManagerNative*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISurfaceImageSourceManagerNative*, uint>)(lpVtbl[2]))((ISurfaceImageSourceManagerNative*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISurfaceImageSourceManagerNative.xml' path='doc/member[@name="ISurfaceImageSourceManagerNative.FlushAllSurfacesWithDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT FlushAllSurfacesWithDevice(IUnknown* device)
    {
        return ((delegate* unmanaged[MemberFunction]<ISurfaceImageSourceManagerNative*, IUnknown*, int>)(lpVtbl[3]))((ISurfaceImageSourceManagerNative*)Unsafe.AsPointer(ref this), device);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT FlushAllSurfacesWithDevice(IUnknown* device);
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

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, int> FlushAllSurfacesWithDevice;
    }
}
