// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISyncMgrSessionCreator.xml' path='doc/member[@name="ISyncMgrSessionCreator"]/*' />
[Guid("17F48517-F305-4321-A08D-B25A834918FD")]
[NativeTypeName("struct ISyncMgrSessionCreator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrSessionCreator : ISyncMgrSessionCreator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISyncMgrSessionCreator);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSessionCreator*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrSessionCreator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSessionCreator*, uint>)(lpVtbl[1]))((ISyncMgrSessionCreator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSessionCreator*, uint>)(lpVtbl[2]))((ISyncMgrSessionCreator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrSessionCreator.xml' path='doc/member[@name="ISyncMgrSessionCreator.CreateSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateSession([NativeTypeName("LPCWSTR")] char* pszHandlerID, [NativeTypeName("LPCWSTR *")] char** ppszItemIDs, [NativeTypeName("ULONG")] uint cItems, ISyncMgrSyncCallback** ppCallback)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSessionCreator*, char*, char**, uint, ISyncMgrSyncCallback**, int>)(lpVtbl[3]))((ISyncMgrSessionCreator*)Unsafe.AsPointer(ref this), pszHandlerID, ppszItemIDs, cItems, ppCallback);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateSession([NativeTypeName("LPCWSTR")] char* pszHandlerID, [NativeTypeName("LPCWSTR *")] char** ppszItemIDs, [NativeTypeName("ULONG")] uint cItems, ISyncMgrSyncCallback** ppCallback);
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

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR *, ULONG, ISyncMgrSyncCallback **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char**, uint, ISyncMgrSyncCallback**, int> CreateSession;
    }
}
