// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='IAppxManifestMainPackageDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestMainPackageDependenciesEnumerator"]/*' />
[Guid("A99C4F00-51D2-4F0F-BA46-7ED5255EBDFF")]
[NativeTypeName("struct IAppxManifestMainPackageDependenciesEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxManifestMainPackageDependenciesEnumerator : IAppxManifestMainPackageDependenciesEnumerator.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestMainPackageDependenciesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestMainPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestMainPackageDependenciesEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestMainPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestMainPackageDependenciesEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestMainPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestMainPackageDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestMainPackageDependenciesEnumerator.GetCurrent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrent(IAppxManifestMainPackageDependency** mainPackageDependency)
    {
        return ((delegate* unmanaged<IAppxManifestMainPackageDependenciesEnumerator*, IAppxManifestMainPackageDependency**, int>)(lpVtbl[3]))((IAppxManifestMainPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), mainPackageDependency);
    }

    /// <include file='IAppxManifestMainPackageDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestMainPackageDependenciesEnumerator.GetHasCurrent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHasCurrent(BOOL* hasCurrent)
    {
        return ((delegate* unmanaged<IAppxManifestMainPackageDependenciesEnumerator*, BOOL*, int>)(lpVtbl[4]))((IAppxManifestMainPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
    }

    /// <include file='IAppxManifestMainPackageDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestMainPackageDependenciesEnumerator.MoveNext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveNext(BOOL* hasNext)
    {
        return ((delegate* unmanaged<IAppxManifestMainPackageDependenciesEnumerator*, BOOL*, int>)(lpVtbl[5]))((IAppxManifestMainPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrent(IAppxManifestMainPackageDependency** mainPackageDependency);

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

        [NativeTypeName("HRESULT (IAppxManifestMainPackageDependency **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestMainPackageDependency**, int> GetCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetHasCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> MoveNext;
    }
}
