// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppxManifestOSPackageDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestOSPackageDependenciesEnumerator"]/*' />
[Guid("B84E2FC3-F8EC-4BC1-8AE2-156346F5FFEA")]
[NativeTypeName("struct IAppxManifestOSPackageDependenciesEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxManifestOSPackageDependenciesEnumerator : IAppxManifestOSPackageDependenciesEnumerator.Interface, IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_IAppxManifestOSPackageDependenciesEnumerator;

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestOSPackageDependenciesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestOSPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestOSPackageDependenciesEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestOSPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestOSPackageDependenciesEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestOSPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestOSPackageDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestOSPackageDependenciesEnumerator.GetCurrent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrent(IAppxManifestOSPackageDependency** osPackageDependency)
    {
        return ((delegate* unmanaged<IAppxManifestOSPackageDependenciesEnumerator*, IAppxManifestOSPackageDependency**, int>)(lpVtbl[3]))((IAppxManifestOSPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), osPackageDependency);
    }

    /// <include file='IAppxManifestOSPackageDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestOSPackageDependenciesEnumerator.GetHasCurrent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHasCurrent(BOOL* hasCurrent)
    {
        return ((delegate* unmanaged<IAppxManifestOSPackageDependenciesEnumerator*, BOOL*, int>)(lpVtbl[4]))((IAppxManifestOSPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
    }

    /// <include file='IAppxManifestOSPackageDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestOSPackageDependenciesEnumerator.MoveNext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveNext(BOOL* hasNext)
    {
        return ((delegate* unmanaged<IAppxManifestOSPackageDependenciesEnumerator*, BOOL*, int>)(lpVtbl[5]))((IAppxManifestOSPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrent(IAppxManifestOSPackageDependency** osPackageDependency);

        [VtblIndex(4)]
        HRESULT GetHasCurrent(BOOL* hasCurrent);

        [VtblIndex(5)]
        HRESULT MoveNext(BOOL* hasNext);
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

        [NativeTypeName("HRESULT (IAppxManifestOSPackageDependency **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestOSPackageDependency**, int> GetCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetHasCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> MoveNext;
    }
}
