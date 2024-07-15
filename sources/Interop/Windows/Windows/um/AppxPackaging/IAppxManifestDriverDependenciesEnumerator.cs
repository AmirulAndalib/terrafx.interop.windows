// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppxManifestDriverDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestDriverDependenciesEnumerator"]/*' />
[Guid("FE039DB2-467F-4755-8404-8F5EB6865B33")]
[NativeTypeName("struct IAppxManifestDriverDependenciesEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxManifestDriverDependenciesEnumerator : IAppxManifestDriverDependenciesEnumerator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestDriverDependenciesEnumerator));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxManifestDriverDependenciesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestDriverDependenciesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxManifestDriverDependenciesEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestDriverDependenciesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxManifestDriverDependenciesEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestDriverDependenciesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestDriverDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestDriverDependenciesEnumerator.GetCurrent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrent(IAppxManifestDriverDependency** driverDependency)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxManifestDriverDependenciesEnumerator*, IAppxManifestDriverDependency**, int>)(lpVtbl[3]))((IAppxManifestDriverDependenciesEnumerator*)Unsafe.AsPointer(ref this), driverDependency);
    }

    /// <include file='IAppxManifestDriverDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestDriverDependenciesEnumerator.GetHasCurrent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHasCurrent(BOOL* hasCurrent)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxManifestDriverDependenciesEnumerator*, BOOL*, int>)(lpVtbl[4]))((IAppxManifestDriverDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
    }

    /// <include file='IAppxManifestDriverDependenciesEnumerator.xml' path='doc/member[@name="IAppxManifestDriverDependenciesEnumerator.MoveNext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveNext(BOOL* hasNext)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxManifestDriverDependenciesEnumerator*, BOOL*, int>)(lpVtbl[5]))((IAppxManifestDriverDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrent(IAppxManifestDriverDependency** driverDependency);

        [VtblIndex(4)]
        HRESULT GetHasCurrent(BOOL* hasCurrent);

        [VtblIndex(5)]
        HRESULT MoveNext(BOOL* hasNext);
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

        [NativeTypeName("HRESULT (IAppxManifestDriverDependency **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppxManifestDriverDependency**, int> GetCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> GetHasCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> MoveNext;
    }
}
