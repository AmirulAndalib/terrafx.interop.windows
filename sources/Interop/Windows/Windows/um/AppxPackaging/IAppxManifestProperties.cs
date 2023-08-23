// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppxManifestProperties.xml' path='doc/member[@name="IAppxManifestProperties"]/*' />
[Guid("03FAF64D-F26F-4B2C-AAF7-8FE7789B8BCA")]
[NativeTypeName("struct IAppxManifestProperties : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAppxManifestProperties : IAppxManifestProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestProperties*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestProperties*, uint>)(lpVtbl[1]))((IAppxManifestProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestProperties*, uint>)(lpVtbl[2]))((IAppxManifestProperties*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestProperties.xml' path='doc/member[@name="IAppxManifestProperties.GetBoolValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBoolValue([NativeTypeName("LPCWSTR")] char* name, BOOL* value)
    {
        return ((delegate* unmanaged<IAppxManifestProperties*, char*, BOOL*, int>)(lpVtbl[3]))((IAppxManifestProperties*)Unsafe.AsPointer(ref this), name, value);
    }

    /// <include file='IAppxManifestProperties.xml' path='doc/member[@name="IAppxManifestProperties.GetStringValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStringValue([NativeTypeName("LPCWSTR")] char* name, [NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged<IAppxManifestProperties*, char*, char**, int>)(lpVtbl[4]))((IAppxManifestProperties*)Unsafe.AsPointer(ref this), name, value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetBoolValue([NativeTypeName("LPCWSTR")] char* name, BOOL* value);

        [VtblIndex(4)]
        HRESULT GetStringValue([NativeTypeName("LPCWSTR")] char* name, [NativeTypeName("LPWSTR *")] char** value);
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

        [NativeTypeName("HRESULT (LPCWSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, char*, BOOL*, int> GetBoolValue;

        [NativeTypeName("HRESULT (LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, char*, char**, int> GetStringValue;
    }
}
